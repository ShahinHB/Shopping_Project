#pragma checksum "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Account\Roles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35e998e9653ecc9fb3b9ac4e741900ecc2a9bd85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Account_Roles), @"mvc.1.0.view", @"/Areas/Admin/Views/Account/Roles.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35e998e9653ecc9fb3b9ac4e741900ecc2a9bd85", @"/Areas/Admin/Views/Account/Roles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5996cabd2335b177708eb01fd0622668daaf9b13", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Account_Roles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<IdentityRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light mb-3 px-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RoleCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mb-2 btn-sm btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RoleUpdate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""row justify-content-center"">
    <div class=""col-lg-6 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title text-center"" style=""font-size: 30px !important; font-weight: 600 !important;"">Roles</h4>
");
#nullable restore
#line 8 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Account\Roles.cshtml"
                 if (Model.Count < 3)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35e998e9653ecc9fb3b9ac4e741900ecc2a9bd856602", async() => {
                WriteLiteral("Create New Role");
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
            WriteLiteral("\n");
#nullable restore
#line 11 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Account\Roles.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Account\Roles.cshtml"
                  
                    if (TempData["SocialError"] != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p style=\"font-size: 20px !important;\" class=\"alert alert-danger\">");
#nullable restore
#line 15 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Account\Roles.cshtml"
                                                                                     Write(TempData["SocialError"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 16 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Account\Roles.cshtml"

                        TempData["SocialError"] = null;
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""table-responsive"">
                    <table class=""table table-bordered text-center"">
                        <thead>
                            <tr>
                                <th class=""tableTrCustom"">
                                    #
                                </th>
                                <th class=""tableTrCustom"">
                                    Name
                                </th>
                                <th class=""tableTrCustom"">
                                    Edit
                                </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 36 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Account\Roles.cshtml"
                              
                                int counter = 0;
                                foreach (var item in Model)
                                {
                                    counter++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\n                                        <td style=\"font-size: 18px !important; font-weight: 500 !important;\">\n                                            ");
#nullable restore
#line 43 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Account\Roles.cshtml"
                                       Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </td>\n                                        <td style=\"font-size: 18px !important; font-weight: 500 !important;\">\n                                            ");
#nullable restore
#line 46 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Account\Roles.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </td>\n                                        <td>\n");
#nullable restore
#line 49 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Account\Roles.cshtml"
                                             if (item.Name != "Moderator" && item.Name != "SuperAdmin" && item.Name != "Admin")
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35e998e9653ecc9fb3b9ac4e741900ecc2a9bd8512348", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Account\Roles.cshtml"
                                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 52 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Account\Roles.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span>You can\'t Remove, Update this role</span>\n");
#nullable restore
#line 56 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Account\Roles.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\n                                    </tr>\n");
#nullable restore
#line 59 "C:\Users\Shahin\Desktop\Shopping Project\Pronia_Shopping\Pronia_eCommerce\Pronia_eCommerce\Areas\Admin\Views\Account\Roles.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
