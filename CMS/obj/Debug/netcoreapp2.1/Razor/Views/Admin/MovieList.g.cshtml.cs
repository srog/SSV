#pragma checksum "D:\Code\SSV\CMS\Views\Admin\MovieList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7233a249b0e99aacfac0a379895abba2765015c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_MovieList), @"mvc.1.0.view", @"/Views/Admin/MovieList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/MovieList.cshtml", typeof(AspNetCore.Views_Admin_MovieList))]
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
#line 1 "D:\Code\SSV\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#line 2 "D:\Code\SSV\CMS\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7233a249b0e99aacfac0a379895abba2765015c", @"/Views/Admin/MovieList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fda46ac6a24f19109ebb784fda558b061b2e80b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_MovieList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CMS.Models.MovieDetails>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateMovie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Code\SSV\CMS\Views\Admin\MovieList.cshtml"
  
    ViewData["Title"] = "Movie List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(140, 58, true);
            WriteLiteral("<br />\r\n<br />\r\n\r\n<h2>Admin - Movie List</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(198, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45f0d61042c64fc8964fafb200e5c57f", async() => {
                BeginContext(226, 16, true);
                WriteLiteral("Create New Entry");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(246, 16, true);
            WriteLiteral("\r\n</p>\r\n<hr />\r\n");
            EndContext();
#line 16 "D:\Code\SSV\CMS\Views\Admin\MovieList.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
            BeginContext(291, 32, true);
            WriteLiteral("    <h3>Nothing here yet!</h3>\r\n");
            EndContext();
#line 19 "D:\Code\SSV\CMS\Views\Admin\MovieList.cshtml"
}
else
{


#line default
#line hidden
            BeginContext(337, 113, true);
            WriteLiteral("    <table class=\"table-bordered\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(451, 44, false);
#line 27 "D:\Code\SSV\CMS\Views\Admin\MovieList.cshtml"
               Write(Html.DisplayNameFor(model => model.EntityId));

#line default
#line hidden
            EndContext();
            BeginContext(495, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(563, 40, false);
#line 30 "D:\Code\SSV\CMS\Views\Admin\MovieList.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(603, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(671, 44, false);
#line 33 "D:\Code\SSV\CMS\Views\Admin\MovieList.cshtml"
               Write(Html.DisplayNameFor(model => model.ImdbLink));

#line default
#line hidden
            EndContext();
            BeginContext(715, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(783, 49, false);
#line 36 "D:\Code\SSV\CMS\Views\Admin\MovieList.cshtml"
               Write(Html.DisplayNameFor(model => model.ImageFilePath));

#line default
#line hidden
            EndContext();
            BeginContext(832, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(900, 46, false);
#line 39 "D:\Code\SSV\CMS\Views\Admin\MovieList.cshtml"
               Write(Html.DisplayNameFor(model => model.ImdbRating));

#line default
#line hidden
            EndContext();
            BeginContext(946, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1014, 48, false);
#line 42 "D:\Code\SSV\CMS\Views\Admin\MovieList.cshtml"
               Write(Html.DisplayNameFor(model => model.YearReleased));

#line default
#line hidden
            EndContext();
            BeginContext(1062, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 48 "D:\Code\SSV\CMS\Views\Admin\MovieList.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1225, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1298, 43, false);
#line 52 "D:\Code\SSV\CMS\Views\Admin\MovieList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EntityId));

#line default
#line hidden
            EndContext();
            BeginContext(1341, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1421, 39, false);
#line 55 "D:\Code\SSV\CMS\Views\Admin\MovieList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1460, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1540, 43, false);
#line 58 "D:\Code\SSV\CMS\Views\Admin\MovieList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ImdbLink));

#line default
#line hidden
            EndContext();
            BeginContext(1583, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1663, 48, false);
#line 61 "D:\Code\SSV\CMS\Views\Admin\MovieList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ImageFilePath));

#line default
#line hidden
            EndContext();
            BeginContext(1711, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1791, 45, false);
#line 64 "D:\Code\SSV\CMS\Views\Admin\MovieList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ImdbRating));

#line default
#line hidden
            EndContext();
            BeginContext(1836, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1916, 47, false);
#line 67 "D:\Code\SSV\CMS\Views\Admin\MovieList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.YearReleased));

#line default
#line hidden
            EndContext();
            BeginContext(1963, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2043, 64, false);
#line 70 "D:\Code\SSV\CMS\Views\Admin\MovieList.cshtml"
                   Write(Html.ActionLink("Edit", "EditMovie", new { id = item.EntityId }));

#line default
#line hidden
            EndContext();
            BeginContext(2107, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 73 "D:\Code\SSV\CMS\Views\Admin\MovieList.cshtml"
            }

#line default
#line hidden
            BeginContext(2174, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 76 "D:\Code\SSV\CMS\Views\Admin\MovieList.cshtml"
}

#line default
#line hidden
            BeginContext(2209, 19, true);
            WriteLiteral("<hr />\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2229, 55, false);
#line 79 "D:\Code\SSV\CMS\Views\Admin\MovieList.cshtml"
Write(Html.ActionLink("Back to Admin Home", "Index", "Admin"));

#line default
#line hidden
            EndContext();
            BeginContext(2284, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CMS.Models.MovieDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591
