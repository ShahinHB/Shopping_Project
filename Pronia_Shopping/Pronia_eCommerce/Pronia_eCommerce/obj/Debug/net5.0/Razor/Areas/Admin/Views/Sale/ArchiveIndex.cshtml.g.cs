#pragma checksum "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\ArchiveIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffb5e444aa591c0586866a1cd811b5a825ba1ddd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Sale_ArchiveIndex), @"mvc.1.0.view", @"/Areas/Admin/Views/Sale/ArchiveIndex.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\_ViewImports.cshtml"
using Pronia_eCommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\_ViewImports.cshtml"
using Pronia_eCommerce.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\_ViewImports.cshtml"
using Pronia_eCommerce.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffb5e444aa591c0586866a1cd811b5a825ba1ddd", @"/Areas/Admin/Views/Sale/ArchiveIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5996cabd2335b177708eb01fd0622668daaf9b13", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Sale_ArchiveIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Sale>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-tippy", new global::Microsoft.AspNetCore.Html.HtmlString("Detail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-tippy-inertia", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-tippy-animation", new global::Microsoft.AspNetCore.Html.HtmlString("shift-away"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-tippy-delay", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-tippy-arrow", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-tippy-theme", new global::Microsoft.AspNetCore.Html.HtmlString("sharpborder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-sm btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Sale", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SaleDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<div class=\"row\">\n    <div class=\"col-lg-12 grid-margin stretch-card\">\n        <div class=\"card\">\n            <div class=\"card-body\">\n                <h4 class=\"card-title text-center\" style=\"font-size: 30px !important;\">Archived Sales</h4>\n");
#nullable restore
#line 9 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\ArchiveIndex.cshtml"
                  
                    if (TempData["ArchiveSaleError"] != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p style=\"font-size: 20px !important; padding: 15px !important;\" class=\"alert text-center text-warning\">");
#nullable restore
#line 12 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\ArchiveIndex.cshtml"
                                                                                                                           Write(TempData["ArchiveSaleError"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 13 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\ArchiveIndex.cshtml"

                        TempData["ArchiveSaleError"] = null;
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""table-responsive text-center"">
                    <table class=""table table-bordered table-hover"">
                        <thead>
                            <tr class=""make-it-unvisible"">
                                <th>Invoice NO</th>
                                <th>DATE</th>
                                <th>TOTAL</th>
                                <th>Customer</th>
                                <th>Is User</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 31 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\ArchiveIndex.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\n                                        <td style=\"vertical-align: middle;\"><a class=\"account-order-id\" href=\"#\">");
#nullable restore
#line 34 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\ArchiveIndex.cshtml"
                                                                                                            Write(item.InvoiceNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\n                                        <td style=\"vertical-align: middle;\">");
#nullable restore
#line 35 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\ArchiveIndex.cshtml"
                                                                       Write(item.SaleDate.ToString("MMM d yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td style=\"vertical-align: middle;\">\n");
#nullable restore
#line 37 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\ArchiveIndex.cshtml"
                                              
                                                decimal totalPr = 0;
                                                var prCounts = 0;
                                                foreach (var item2 in item.SaleItems)
                                                {
                                                    totalPr += (item2.Price * item2.Quantity);
                                                    prCounts += item2.Quantity;
                                                }
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
#nullable restore
#line 46 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\ArchiveIndex.cshtml"
                                       Write(totalPr.ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" for ");
#nullable restore
#line 46 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\ArchiveIndex.cshtml"
                                                                   Write(prCounts);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 46 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\ArchiveIndex.cshtml"
                                                                              Write(prCounts>1?" items":" item");

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </td>\n                                        <td style=\"vertical-align: middle;\">");
#nullable restore
#line 48 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\ArchiveIndex.cshtml"
                                                                        Write(item.EndUserId!=null?item.EndUser.Name + " " + item.EndUser.Surname:item.UnregisteredCustomer.FirstName +" "+ item.UnregisteredCustomer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td style=\"vertical-align: middle;\">");
#nullable restore
#line 49 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\ArchiveIndex.cshtml"
                                                                        Write(item.EndUserId==null?"Non-User":"User");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td style=\"vertical-align: middle;\">\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffb5e444aa591c0586866a1cd811b5a825ba1ddd14078", async() => {
                WriteLiteral("<i class=\"fal fa-info-square\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\ArchiveIndex.cshtml"
                                                                                                                                                                                                                                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                        </td>\n                                    </tr>\n");
#nullable restore
#line 54 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Sale\ArchiveIndex.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </tbody>\n                    </table>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Sale>> Html { get; private set; }
    }
}
#pragma warning restore 1591
