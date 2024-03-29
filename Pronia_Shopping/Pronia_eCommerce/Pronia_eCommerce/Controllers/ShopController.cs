﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Pronia_eCommerce.Data;
using Pronia_eCommerce.Models;
using Pronia_eCommerce.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Pronia_eCommerce.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public ShopController(AppDbContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index(VmProductSearch Search)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (!User.IsInRole("User"))
                {
                    return RedirectToAction("Logout", "Account");
                }
            }

            VmProduct model = new();
            if (Search == null || Search.Page == null)
            {
                Search.Page = 1;
            }
            double PageItemCount = 9;
            List<Product> products = _context.Products.Where(p => (Search.SearchData != null ? p.Name.Contains(Search.SearchData) : true)&&
                                                       (Search.SearchCategory!=null?p.ProductCatId==Search.SearchCategory&&p.ProductSizeToProducts.Any(p=>p.Quantity>0):true)&&
                                                       (Search.SearchTag!=null?p.ProductTagToProducts.Any(pt=>pt.ProductTagId==Search.SearchTag&&pt.Product.ProductSizeToProducts.Any(p => p.Quantity > 0)) :true)&&
                                                       (Search.minValue!=null&&Search.maxValue!=null?p.ProductSizeToProducts.Any(pt=>(pt.Price <= Search.minValue) && (pt.Price >= Search.maxValue)&&pt.Quantity>0):true)&&
                                                       (Search.SearchSize!=null?p.ProductSizeToProducts.Any(ps=>(ps.ProductSizeId == Search.SearchSize) && (ps.Quantity>=1)):true))
                                                      .Include(p => p.ProductCat)
                                                      .Include(p => p.ProductImages)
                                                      .Include(p => p.ProductTagToProducts)
                                                      .ThenInclude(pt => pt.ProductTag)
                                                      .Include(p => p.ProductSizeToProducts)
                                                      .ThenInclude(ps => ps.ProductSize)
                                                      .Include(r=>r.Ratings).Where(p => p.Archived == false).OrderByDescending(p=>p.CreatedDate).ToList();



            var PrdTTP = _context.ProductTagToProducts.ToList().GroupBy(d => d.ProductTagId).OrderByDescending(d=>d.Select(w=>w.ProductTag).Count());

            List<int> w = new();
            List<ProductTag> Prdtg = new();
            foreach (var item in PrdTTP)
            {
                w.Add(item.Key);
            }

            foreach (var item in w.Take(5))
            {
                Prdtg.Add(_context.ProductTags.Find(item));
            }



            int pageCount = (int)Math.Ceiling(Convert.ToDecimal(products.Count / PageItemCount));
            model.Products = products.Skip(((int)Search.Page - 1) * (int)PageItemCount).Take((int)PageItemCount).ToList();
            model.Setting = _context.Setting.FirstOrDefault();
            model.SiteSocial = _context.SiteSocials.ToList();
            model.ProductCats = _context.ProductCats.ToList();
            model.ProductTags = Prdtg;
            model.ProductSizes = _context.ProductSizes.ToList();
            ViewBag.PageCount = pageCount;
            ViewBag.Page = Search.Page;
            ViewBag.ProductCount = products.Count;
            model.Search = Search;
            model.Banner = _context.Banners.FirstOrDefault(p => p.Page == "Shop Main");
            model.collectionS = _context.CollectionS.FirstOrDefault();

            if (User.Identity.IsAuthenticated)
            {
                string oldData = _context.EndUsers.Find(_userManager.GetUserId(User)).UserFavourite;

                if (!string.IsNullOrEmpty(oldData))
                {
                    model.Favourite = oldData.Split("-").ToList();
                }
            }
            else
            {
                string oldData = Request.Cookies["favourites"];

                if (!string.IsNullOrEmpty(oldData))
                {
                    model.Favourite = oldData.Split("-").ToList();
                }
            }
            


            return View(model);
        }

        public IActionResult SingleProduct(int? Id)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (!User.IsInRole("User"))
                {
                    return RedirectToAction("Logout", "Account");
                }
            }

            if (Id!=null)
            {
                if (_context.Products.Find(Id)!=null)
                {
                    VmProduct model2 = new();
                    model2.Setting = _context.Setting.FirstOrDefault();
                    model2.SiteSocial = _context.SiteSocials.ToList();
                    model2.SingleProduct = _context.Products.Include(p => p.ProductImages)
                                               .Include(p => p.ProductCat)
                                               .Include(p => p.ProductTagToProducts)
                                               .ThenInclude(pt => pt.ProductTag)
                                               .Include(p => p.ProductSizeToProducts)
                                               .ThenInclude(ps => ps.ProductSize)
                                               .Include(p => p.ProductComments)
                                               .ThenInclude(pc => pc.CommentPost)
                                               .Include(p=>p.ProductComments)
                                               .ThenInclude(pc=>pc.User)
                                               .FirstOrDefault(p => p.Id == Id);

                    model2.RatingStars = _context.RatingStars.Where(r => r.ProductId == Id).ToList();
                    model2.Banner = _context.Banners.FirstOrDefault(p => p.Page == "Shop Detail");
                   
                    string oldData = Request.Cookies["favourites"];

                    if (!string.IsNullOrEmpty(oldData))
                    {
                        model2.Favourite = oldData.Split("-").ToList();
                    }

                    return View(model2);
                }
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");

        }

        public IActionResult GetProductInfo(int? id)
        {
            if (id!=null)
            {
                if (_context.Products.Find(id) != null)
                {
                    Product product2 = new();
                    product2 = _context.Products.Include(p=>p.ProductImages).Include(p=>p.ProductSizeToProducts).ThenInclude(pp=>pp.ProductSize).Include(p=>p.Ratings).FirstOrDefault(p => p.Id == id);

                    return Json(new { data = product2 });
                }
            }
            
            return Json(false);
        }

        public IActionResult PostComment(CommentPost commentPost)
        {
            if (ModelState.IsValid)
            {
                _context.CommentPosts.Add(commentPost);
                _context.SaveChanges();

                ProductComment Pcomment = new();
                Pcomment.ProductId = commentPost.ProductId;
                Pcomment.CommentPostId = commentPost.Id;
                Pcomment.CreatedDate = DateTime.Now;
                Pcomment.Content = commentPost.Content;

                _context.ProductComments.Add(Pcomment);
                _context.SaveChanges();


            }
            else
            {
                if (_signInManager.IsSignedIn(User)&& commentPost.FullName == null && commentPost.Email == null && commentPost.Content != null)
                {
                    commentPost.FullName = "";
                    commentPost.Email = "";
                    _context.CommentPosts.Add(commentPost);
                    _context.SaveChanges();
                    ProductComment comment = new();
                    comment.ProductId = commentPost.ProductId;
                    comment.CommentPostId = commentPost.Id;
                    comment.UserId = _userManager.GetUserId(User);
                    comment.CreatedDate = DateTime.Now;
                    comment.Content = commentPost.Content;

                    _context.ProductComments.Add(comment);
                    _context.SaveChanges();
                }
            }

            return RedirectToAction("SingleProduct", new { Id = commentPost.ProductId });

        }

        public IActionResult ReviewPost(string userEmail, string userName, string userSurname, string productId, string ratingValue)
        {
            VmResponse response = new();

            if (User.Identity.IsAuthenticated&&userEmail=="user"&&userName=="user"&&userSurname=="user")
            {

                int prid = Int16.Parse(productId);
                int ratval = Int16.Parse(ratingValue);
                if (_context.Products.Find(prid) != null)
                {
                    if (ratval >= 1 && ratval <= 5)
                    {

                        RatingStar ratingStars = new();

                        var usrM = _context.EndUsers.Find(_userManager.GetUserId(User)).Email;
                        var usrN = _context.EndUsers.Find(_userManager.GetUserId(User)).Name;
                        var usrS = _context.EndUsers.Find(_userManager.GetUserId(User)).Surname;

                        var hasIp = _context.RatingStars.Where(r => r.ProductId == prid).Any(p => (p.UserEmail == usrM) && (p.UserName == usrN) && (p.UserSurname == usrS));
                        if (hasIp)
                        {
                            _context.RatingStars.Where(r => r.ProductId == prid && r.UserEmail == usrM && r.UserName == usrN && r.UserSurname == usrS).FirstOrDefault().ProductId = prid;
                            _context.RatingStars.Where(r => r.ProductId == prid && r.UserEmail == usrM && r.UserName == usrN && r.UserSurname == usrS).FirstOrDefault().Star = ratval;
                            _context.RatingStars.Where(r => r.ProductId == prid && r.UserEmail == usrM && r.UserName == usrN && r.UserSurname == usrS).FirstOrDefault().UserEmail = usrM;

                            _context.SaveChanges();

                            response.Changed = "change";
                            response.StarsCount = _context.RatingStars.Where(r => r.ProductId == prid && r.UserEmail == usrM && r.UserName == usrN && r.UserSurname == usrS).FirstOrDefault().Star;
                            response.Products = _context.Products.Include(pr => pr.Ratings).Where(r => r.Id == prid).ToList();

                            return Json(response);
                        }
                        else
                        {
                            ratingStars.ProductId = prid;
                            ratingStars.Star = ratval;
                            ratingStars.UserEmail = usrM;
                            ratingStars.UserName = usrN;
                            ratingStars.UserSurname = usrS;
                            _context.RatingStars.Add(ratingStars);
                            _context.SaveChanges();

                            response.Success = "ok";
                            response.StarsCount = _context.RatingStars.Where(r => r.ProductId == prid && r.UserEmail == usrM && r.UserName == usrN && r.UserSurname == usrS).FirstOrDefault().Star;
                            response.Products = _context.Products.Include(pr => pr.Ratings).Where(r => r.Id == prid).ToList();
                            return Json(response);
                        }


                    }
                    else
                    {
                        response.Error = "error";
                        return Json(response);
                    }


                }
                else
                {
                    response.Error = "error";
                    return Json(response);
                }

            }
            else
            {
                if (userEmail != null)
                {
                    int prid = Int16.Parse(productId);
                    int ratval = Int16.Parse(ratingValue);
                    if (_context.Products.Find(prid) != null)
                    {
                        if (ratval >= 1 && ratval <= 5)
                        {

                            RatingStar ratingStars = new();
                            var hasIp = _context.RatingStars.Where(r => r.ProductId == prid).Any(p => (p.UserEmail == userEmail) && (p.UserName == userName) && (p.UserSurname == userSurname));
                            if (hasIp)
                            {
                                _context.RatingStars.Where(r => r.ProductId == prid && r.UserEmail == userEmail && r.UserName == userName && r.UserSurname == userSurname).FirstOrDefault().ProductId = prid;
                                _context.RatingStars.Where(r => r.ProductId == prid && r.UserEmail == userEmail && r.UserName == userName && r.UserSurname == userSurname).FirstOrDefault().Star = ratval;
                                _context.RatingStars.Where(r => r.ProductId == prid && r.UserEmail == userEmail && r.UserName == userName && r.UserSurname == userSurname).FirstOrDefault().UserEmail = userEmail;

                                _context.SaveChanges();

                                response.Changed = "change";
                                response.StarsCount = _context.RatingStars.Where(r => r.ProductId == prid && r.UserEmail == userEmail && r.UserName == userName && r.UserSurname == userSurname).FirstOrDefault().Star;
                                response.Products = _context.Products.Include(pr => pr.Ratings).Where(r => r.Id == prid).ToList();

                                return Json(response);
                            }
                            else
                            {
                                ratingStars.ProductId = prid;
                                ratingStars.Star = ratval;
                                ratingStars.UserEmail = userEmail;
                                ratingStars.UserName = userName;
                                ratingStars.UserSurname = userSurname;
                                _context.RatingStars.Add(ratingStars);
                                _context.SaveChanges();

                                response.Success = "ok";
                                response.StarsCount = _context.RatingStars.Where(r => r.ProductId == prid && r.UserEmail == userEmail && r.UserName == userName && r.UserSurname == userSurname).FirstOrDefault().Star;
                                response.Products = _context.Products.Include(pr => pr.Ratings).Where(r => r.Id == prid).ToList();
                                return Json(response);
                            }


                        }
                        else
                        {
                            response.Error = "error";
                            return Json(response);
                        }


                    }
                    else
                    {
                        response.Error = "error";
                        return Json(response);
                    }
                }
                else
                {
                    response.Error = "error";
                    return Json(response);
                }
            }



           

        }

        public IActionResult AddToWishlist(string productId)
        {

            if (productId!=null)
            {
                if (_context.Products.Find(Int32.Parse(productId)) != null)
                {
                    if (_context.Products.Any(p => p.Id == Int16.Parse(productId)))
                    {
                        if (User.Identity.IsAuthenticated)
                        {
                            EndUser endUser = _context.EndUsers.Find(_userManager.GetUserId(User));

                            string oldData = endUser.UserFavourite;
                            string newData = null;

                            VmResponse response = new();

                            if (string.IsNullOrEmpty(oldData))
                            {
                                newData = productId;
                                response.Success = "Added";
                            }
                            else
                            {
                                List<string> favouriteList = oldData.Split("-").ToList();
                                if (favouriteList.Any(f => f == productId))
                                {
                                    favouriteList.Remove(productId);
                                    newData = string.Join("-", favouriteList);
                                    response.Changed = "Removed";
                                }
                                else
                                {
                                    newData = oldData + "-" + productId;
                                    response.Success = "Added";
                                }
                            }

                            endUser.UserFavourite = newData;
                            _context.EndUsers.Update(endUser);
                            _context.SaveChanges();
                            return Json(response);
                        }
                        else
                        {
                            string oldData = Request.Cookies["favourites"];
                            string newData = null;
                            VmResponse response = new();
                            if (string.IsNullOrEmpty(oldData))
                            {
                                newData = productId;
                                response.Success = "Added";
                            }
                            else
                            {
                                List<string> favouriteList = oldData.Split("-").ToList();
                                if (favouriteList.Any(f => f == productId))
                                {
                                    favouriteList.Remove(productId);
                                    newData = string.Join("-", favouriteList);
                                    response.Changed = "Removed";
                                }
                                else
                                {
                                    newData = oldData + "-" + productId;
                                    response.Success = "Added";
                                }
                            }

                            CookieOptions options = new()
                            {
                                Expires = DateTime.Now.AddMonths(1)
                            };

                            Response.Cookies.Append("favourites", newData, options);

                            return Json(response);
                        }
                    }
                    else
                    {
                        VmResponse response = new();
                        response.Error = "Error";

                        return Json(response);
                    }
                }
                else
                {
                    VmResponse response = new();
                    response.Error = "Error";

                    return Json(response);
                }
            }
            else
            {
                VmResponse response = new();
                response.Error = "Error";

                return Json(response);
            }


        }

        public IActionResult RemoveFromWishlist(int? Id)
        {
            if (User.Identity.IsAuthenticated)
            {
                string oldData = _context.EndUsers.Find(_userManager.GetUserId(User)).UserFavourite;
                string newData = null;

                if (!string.IsNullOrEmpty(oldData))
                {
                    List<string> favouriteList = oldData.Split("-").ToList();
                    if (favouriteList.Any(f => f == Id.ToString()))
                    {
                        favouriteList.Remove(Id.ToString());
                        newData = string.Join("-", favouriteList);
                        _context.EndUsers.Find(_userManager.GetUserId(User)).UserFavourite = newData;
                        _context.SaveChanges();
                        return RedirectToAction("index", "Wishlist");
                    }
                    else
                    {
                        return RedirectToAction("index");
                    }
                }
                else
                {
                    return RedirectToAction("index");
                }
            }
            else
            {
                string oldData = Request.Cookies["favourites"];
                string newData = null;

                if (!string.IsNullOrEmpty(oldData))
                {
                    List<string> favouriteList = oldData.Split("-").ToList();
                    if (favouriteList.Any(f => f == Id.ToString()))
                    {
                        favouriteList.Remove(Id.ToString());
                        newData = string.Join("-", favouriteList);
                    }
                    else
                    {
                        return RedirectToAction("index");
                    }
                }
                else
                {
                    return RedirectToAction("index");
                }

                CookieOptions options = new()
                {
                    Expires = DateTime.Now.AddMonths(1)
                };

                Response.Cookies.Append("favourites", newData, options);

                return RedirectToAction("index", "Wishlist");
            }
        }

        public IActionResult RefreshRating(string userEmail) {


            VmResponse response = new();
            response.StarsCounts = _context.RatingStars.Where(r =>r.UserEmail == userEmail).ToList();



            return Json(response); 
        
        
        
        }

        public IActionResult GetRatingValue(int id)
        {
            List<RatingStar> r = new();
            if (_context.Products.Find(id) != null)
            {
                var model = _context.Products.Include(r => r.Ratings).FirstOrDefault(p => p.Id == id);
                r = model.Ratings;
                return Json(r);
            }
            else
            {
                return Json(r);
            }
        }

    }
}
