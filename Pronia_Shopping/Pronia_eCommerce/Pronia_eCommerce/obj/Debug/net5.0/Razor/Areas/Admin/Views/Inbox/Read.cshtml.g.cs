#pragma checksum "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ebab2b6adcc7e95a5c2e83f5f89c4d1d1711faa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Inbox_Read), @"mvc.1.0.view", @"/Areas/Admin/Views/Inbox/Read.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ebab2b6adcc7e95a5c2e83f5f89c4d1d1711faa", @"/Areas/Admin/Views/Inbox/Read.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5996cabd2335b177708eb01fd0622668daaf9b13", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Inbox_Read : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmSendEmail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-light w-25"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Inbox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Message..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("exampleFormControlTextarea1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Read", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<div class=\"container\">\n    <div class=\"row justify-content-center\">\n        <div class=\"col-lg-12 text-left\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ebab2b6adcc7e95a5c2e83f5f89c4d1d1711faa8902", async() => {
                WriteLiteral("Go back to Messages");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n\n        <div class=\"col-lg-7 pt-5 pb-2\" style=\"text-align: center; font-size: 25px; color: white; font-weight: 600;\">\n            Message\n        </div>\n");
#nullable restore
#line 13 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"
         if (TempData["EmailError"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p style=\"font-size: 20px !important;\" class=\"alert text-center p-2 col-lg-6 text-warning\">");
#nullable restore
#line 15 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"
                                                                                                  Write(TempData["EmailError"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 16 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"

            TempData["EmailError"] = null;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-lg-7"">
            <div class=""card text-center"">
                <div class=""card-header alert alert-light py-2"">
                    <div>
                        <div style=""color: white;"">
                            Full Name: <span style=""font-weight: 300 !important; color: #c8edff !important; "">");
#nullable restore
#line 24 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"
                                                                                                         Write(Model.message.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 24 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"
                                                                                                                                  Write(Model.message.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                        </div>\n                        <div style=\"color: white;\">\n                            Email: <span style=\"font-weight: 300 !important; color: #c8edff !important; \">");
#nullable restore
#line 27 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"
                                                                                                     Write(Model.message.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                        </div>\n                        <div style=\"color: white;\">\n                            Phone: <span style=\"color: #c8edff !important;\">");
#nullable restore
#line 30 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"
                                                                       Write(Model.message.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </div>
                    </div>
                </div>
                <div class=""card-body"" id=""cstmscrlbr"" style=""max-height: 280px; overflow: auto;"">
                    <p class=""card-text"" style="" padding: 10px; text-align: justify;"">");
#nullable restore
#line 35 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"
                                                                                 Write(Model.message.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                </div>\n                <div class=\"card-footer\" style=\" display: flex; flex-direction: row; justify-content: space-around; align-items: center;\">\n                    <small style=\"color: #a0e2ff !important;\">\n");
#nullable restore
#line 39 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"
                          
                            var date = (DateTime.Now - Model.message.CreatedDate);
                            if (date.Days == 0)
                            {
                                if (date.Hours == 0)
                                {
                                    if (date.Minutes == 0)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"
                                    Write(date.Seconds);

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"
                                                    Write(" seconds before");

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"
                                                                            
                                    }
                                    else
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"
                                    Write(date.Minutes);

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"
                                                    Write(" minutes before");

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"
                                                                            
                                    }
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"
                                Write(date.Hours);

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"
                                              Write(" hours before");

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"
                                                                    
                                }
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"
                            Write(date.Days);

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"
                                         Write(" days before");

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"
                                                              
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </small>
                    <div>
                        <a class=""btn btn-sm btn-outline-info"" style="" text-decoration: none;"" data-toggle=""collapse"" href=""#multiCollapseExample1"" role=""button"" aria-expanded=""false"" aria-controls=""multiCollapseExample1"">Send Email</a>
                    </div>
                </div>
            </div>
            <div class=""collapse multi-collapse"" id=""multiCollapseExample1"">
                <div class=""card card-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ebab2b6adcc7e95a5c2e83f5f89c4d1d1711faa19908", async() => {
                WriteLiteral("\n                        <div class=\"mb-3\">\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ebab2b6adcc7e95a5c2e83f5f89c4d1d1711faa20239", async() => {
                    WriteLiteral("Message Content");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 74 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.sendingMessage);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ebab2b6adcc7e95a5c2e83f5f89c4d1d1711faa21951", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 75 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.sendingMessage);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ebab2b6adcc7e95a5c2e83f5f89c4d1d1711faa23888", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 76 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.sendingMessage);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        </div>\n                        <div class=\"mb-3 text-right\">\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4ebab2b6adcc7e95a5c2e83f5f89c4d1d1711faa25618", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 79 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.EmailAddress);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"
                                                                          WriteLiteral(Model.message.Email);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4ebab2b6adcc7e95a5c2e83f5f89c4d1d1711faa28171", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 80 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MsgId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Inbox\Read.cshtml"
                                                            WriteLiteral(Model.message.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            <button class=\"btn btn-sm btn-light w-25\" type=\"submit\">Send</button>\n                        </div>\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n    </div>\n\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmSendEmail> Html { get; private set; }
    }
}
#pragma warning restore 1591