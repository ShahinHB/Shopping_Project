#pragma checksum "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63030486444ac77cac1b57c87ac21b1a2e4d6840"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Views\_ViewImports.cshtml"
using Pronia_eCommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Views\_ViewImports.cshtml"
using Pronia_eCommerce.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Views\_ViewImports.cshtml"
using Pronia_eCommerce.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63030486444ac77cac1b57c87ac21b1a2e4d6840", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2240b6d17866a4e578f5b5afbfbc1eb100814d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmContact>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("First Name*"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("input-field"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Last Name*"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Phone"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "email", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Email*"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Message"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("textarea-field"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Message", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- #region Breadcrump Area -->\n<section id=\"breadcrump\">\n    <div class=\"breadcrumb-wrapper\"");
            BeginWriteAttribute("style", " style=\"", 111, "\"", 180, 4);
            WriteAttributeValue("", 119, "background-image:", 119, 17, true);
            WriteAttributeValue(" ", 136, "url(\'/img/bg-image/", 137, 20, true);
#nullable restore
#line 4 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Views\Contact\Index.cshtml"
WriteAttributeValue("", 156, Model.Banner.BgImage, 156, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 177, "\');", 177, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\n        <div class=\"container h-100\">\n            <div class=\"row h-100\">\n                <div class=\"col-lg-12\">\n                    <div class=\"breadcrumb-content\">\n                        <h2 class=\"breadcrumb-page\">");
#nullable restore
#line 9 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Views\Contact\Index.cshtml"
                                               Write(Model.Banner.Page);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                        <ul>\n                            <li>\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63030486444ac77cac1b57c87ac21b1a2e4d684010564", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </li>\n                            <li>");
#nullable restore
#line 14 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Views\Contact\Index.cshtml"
                           Write(Model.Banner.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- #endregion Breadcrump Area End -->
<!-- #region Contact -->
<div class=""contact-full pt-100 pb-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
");
#nullable restore
#line 28 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Views\Contact\Index.cshtml"
                  
                    if (TempData["MessageError"] != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p style=\"font-size: 20px !important;\" class=\"alert alert-danger text-danger text-center\">");
#nullable restore
#line 31 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Views\Contact\Index.cshtml"
                                                                                                             Write(TempData["MessageError"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 32 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Views\Contact\Index.cshtml"
                        TempData["MessageError"] = null;
                    }
                    if (TempData["MessageSuccess"] != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p style=\"font-size: 20px !important; background-color: #abd47459 !important;\" class=\"alert alert-success text-success text-center\">");
#nullable restore
#line 36 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Views\Contact\Index.cshtml"
                                                                                                                                                       Write(TempData["MessageSuccess"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 37 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Views\Contact\Index.cshtml"
                        TempData["MessageSuccess"] = null;
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"contact-wrapper\">\n                    <div class=\"contact-info\"");
            BeginWriteAttribute("style", " style=\"", 1778, "\"", 1850, 4);
            WriteAttributeValue("", 1786, "background-image:", 1786, 17, true);
            WriteAttributeValue(" ", 1803, "url(\'/img/bg-image/", 1804, 20, true);
#nullable restore
#line 41 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Views\Contact\Index.cshtml"
WriteAttributeValue("", 1823, Model.ContactUs.BgImage, 1823, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1847, "\');", 1847, 3, true);
            EndWriteAttribute();
            WriteLiteral(@">
                        <h2 class=""contact-title"">Contact Info:</h2>
                        <p class=""contact-desc"">
                            Fill the form amd our teaam will get to back
                            to you within 24 hours.
                        </p>
                        <ul class=""contact-list"">
                            <li>
                                <i class=""fal fa-phone-alt""></i>
                                <a");
            BeginWriteAttribute("href", " href=\"", 2307, "\"", 2342, 2);
            WriteAttributeValue("", 2314, "tel://", 2314, 6, true);
#nullable restore
#line 50 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Views\Contact\Index.cshtml"
WriteAttributeValue("", 2320, Model.ContactUs.Phone, 2320, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 50 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Views\Contact\Index.cshtml"
                                                                  Write(Model.ContactUs.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                            </li>\n                            <li>\n                                <i class=\"fal fa-envelope\"></i>\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2536, "\"", 2574, 2);
            WriteAttributeValue("", 2543, "mailto://", 2543, 9, true);
#nullable restore
#line 54 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Views\Contact\Index.cshtml"
WriteAttributeValue("", 2552, Model.ContactUs.Email, 2552, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 54 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Views\Contact\Index.cshtml"
                                                                     Write(Model.ContactUs.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                            </li>\n                            <li>\n                                <i class=\"fal fa-map-marker-alt\"></i>\n                                <span>");
#nullable restore
#line 58 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Views\Contact\Index.cshtml"
                                 Write(Model.ContactUs.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                            </li>\n                        </ul>\n                    </div>\n\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63030486444ac77cac1b57c87ac21b1a2e4d684018364", async() => {
                WriteLiteral("\n\n                        <div class=\"group-input\">\n                            <div class=\"form-field mb-30 mr-35 mb-lg-0\">\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "63030486444ac77cac1b57c87ac21b1a2e4d684018784", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 67 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Message.FirstName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            </div>\n                            <div class=\"form-field mb-30\">\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "63030486444ac77cac1b57c87ac21b1a2e4d684020620", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 70 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Message.LastName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            </div>\n                        </div>\n                        <div class=\"group-input mb-30\">\n                            <div class=\"form-field mb-30 mr-35 mb-lg-0\">\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "63030486444ac77cac1b57c87ac21b1a2e4d684022560", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 75 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Message.Phone);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            </div>\n                            <div class=\"form-field\">\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "63030486444ac77cac1b57c87ac21b1a2e4d684024386", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#nullable restore
#line 78 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Message.Email);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            </div>\n                        </div>\n                        <div class=\"form-field mb-5\">\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63030486444ac77cac1b57c87ac21b1a2e4d684026457", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 82 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Message.Content);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                        <div class=""contact-button-wrap"">
                            <button type=""submit"" class=""btn"">
                                Post Comment
                            </button>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n<!-- #endregion Contact End -->\n<div class=\"contact-with-map\">\n    <div class=\"contact-map\">\n        <iframe class=\"contact-map-size\"");
            BeginWriteAttribute("src", " src=\"", 4755, "\"", 4785, 1);
#nullable restore
#line 98 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Views\Contact\Index.cshtml"
WriteAttributeValue("", 4761, Model.ContactUs.MapLink, 4761, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 4786, "\"", 4804, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\">\n        </iframe>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmContact> Html { get; private set; }
    }
}
#pragma warning restore 1591
