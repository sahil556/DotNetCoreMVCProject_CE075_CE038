#pragma checksum "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8817f928f489b1798afdb53ed76fe0cfa107a3fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(IndiaMirror.Pages.Views.Admin.Views_Admin_index), @"mvc.1.0.view", @"/Views/Admin/index.cshtml")]
namespace IndiaMirror.Pages.Views.Admin
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
#line 1 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\_ViewImports.cshtml"
using IndiaMirror;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8817f928f489b1798afdb53ed76fe0cfa107a3fe", @"/Views/Admin/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5c646f747b32c579d847bc8ecc5e91f394ec5cf", @"/_ViewImports.cshtml")]
    public class Views_Admin_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IndiaMirror.Models.Advertisement>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Reject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
  
    ViewData["Title"] = "index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<nav class=""navbar fixed-top navbar-expand-lg navbar-dark  bg-dark"">
    <div class=""container-fluid"">
        <a class=""navbar-brand"" href=""#"">NewsDaily</a>
        <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse""
                data-bs-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false""
                aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>
        <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
            <ul class=""navbar-nav me-auto mb-2 mb-lg-0"">
                <li class='nav-item'><a class='nav-link' href=""/News""> Home</a></li>
            </ul>
        </div>
    </div>
</nav>

<h1>Advertisements</h1>

<div class=""table-responsive"">
    <table class=""table align-middle mb-0 bg-white"">
        <thead class=""bg-light"">
                    <tr>
                        <th>
                            ");
#nullable restore
#line 29 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                       Write(Html.DisplayNameFor(model => model.user_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 32 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                       Write(Html.DisplayNameFor(model => model.image_url));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 35 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                       Write(Html.DisplayNameFor(model => model.business_url));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 38 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                       Write(Html.DisplayNameFor(model => model.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 41 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                       Write(Html.DisplayNameFor(model => model.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 44 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                       Write(Html.DisplayNameFor(model => model.category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 47 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                       Write(Html.DisplayNameFor(model => model.status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 50 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                       Write(Html.DisplayNameFor(model => model.reason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 53 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                       Write(Html.DisplayNameFor(model => model.start_time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 56 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                       Write(Html.DisplayNameFor(model => model.end_time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 59 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                       Write(Html.DisplayNameFor(model => model.ctr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 62 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                       Write(Html.DisplayNameFor(model => model.views));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 65 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                       Write(Html.DisplayNameFor(model => model.payment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 71 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 75 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.user_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <div class=\"d-flex align-items-center\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=", 3300, "", 3350, 1);
#nullable restore
#line 79 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
WriteAttributeValue("", 3305, Html.DisplayFor(modelItem => item.image_url), 3305, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "\r\n                                         alt=\"", 3350, "\"", 3398, 0);
            EndWriteAttribute();
            WriteLiteral(@"
                                         style=""width: 80px; height: 60px""
                                         class=""rounded"" />
                                </div>
                            </td>
                            <td>
                                <button type=""button"" class=""btn btn-dark""><a target=""_blank""");
            BeginWriteAttribute("href", " href=", 3740, "", 3794, 1);
#nullable restore
#line 86 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
WriteAttributeValue("", 3746, Html.DisplayFor(modelItem => item.business_url), 3746, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-decoration:none; color:white\">Visit</a></button>\r\n\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 90 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 93 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 96 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 99 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 102 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.reason));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 105 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.start_time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 108 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.end_time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 111 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ctr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 114 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.views));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 117 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.payment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8817f928f489b1798afdb53ed76fe0cfa107a3fe15777", async() => {
                WriteLiteral("<button class=\"btn btn-warning my-1\">Edit</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 120 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8817f928f489b1798afdb53ed76fe0cfa107a3fe18024", async() => {
                WriteLiteral("<button class=\"btn btn-danger my-1\">Reject</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 121 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 124 "C:\Users\sahil\source\repos\IndiaMirror-repo\IndiaMirror\Views\Admin\index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>x\r\n            </table>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IndiaMirror.Models.Advertisement>> Html { get; private set; }
    }
}
#pragma warning restore 1591
