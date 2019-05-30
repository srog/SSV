#pragma checksum "D:\Projects\Projects\SSV\CMS\Views\Admin\MovieList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d4fb30055515269474ea09a4724a55e1514a63e"
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
#line 1 "D:\Projects\Projects\SSV\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#line 2 "D:\Projects\Projects\SSV\CMS\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d4fb30055515269474ea09a4724a55e1514a63e", @"/Views/Admin/MovieList.cshtml")]
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
#line 3 "D:\Projects\Projects\SSV\CMS\Views\Admin\MovieList.cshtml"
  
    ViewData["Title"] = "Movie List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(140, 34, true);
            WriteLiteral("\r\n<h1>All Movies</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(174, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5c01b1f49f64468b6d9eee6604029f8", async() => {
                BeginContext(202, 16, true);
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
            BeginContext(222, 98, true);
            WriteLiteral("\r\n</p>\r\n<hr/>\r\n\r\n<table class=\"table-bordered\">\r\n    <thead>\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(321, 44, false);
#line 19 "D:\Projects\Projects\SSV\CMS\Views\Admin\MovieList.cshtml"
       Write(Html.DisplayNameFor(model => model.EntityId));

#line default
#line hidden
            EndContext();
            BeginContext(365, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(409, 40, false);
#line 22 "D:\Projects\Projects\SSV\CMS\Views\Admin\MovieList.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(449, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(493, 44, false);
#line 25 "D:\Projects\Projects\SSV\CMS\Views\Admin\MovieList.cshtml"
       Write(Html.DisplayNameFor(model => model.ImdbLink));

#line default
#line hidden
            EndContext();
            BeginContext(537, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(581, 49, false);
#line 28 "D:\Projects\Projects\SSV\CMS\Views\Admin\MovieList.cshtml"
       Write(Html.DisplayNameFor(model => model.ImageFilePath));

#line default
#line hidden
            EndContext();
            BeginContext(630, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(674, 46, false);
#line 31 "D:\Projects\Projects\SSV\CMS\Views\Admin\MovieList.cshtml"
       Write(Html.DisplayNameFor(model => model.ImdbRating));

#line default
#line hidden
            EndContext();
            BeginContext(720, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(764, 48, false);
#line 34 "D:\Projects\Projects\SSV\CMS\Views\Admin\MovieList.cshtml"
       Write(Html.DisplayNameFor(model => model.YearReleased));

#line default
#line hidden
            EndContext();
            BeginContext(812, 74, true);
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 40 "D:\Projects\Projects\SSV\CMS\Views\Admin\MovieList.cshtml"
     foreach (var item in Model) {

#line default
#line hidden
            BeginContext(922, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(971, 43, false);
#line 43 "D:\Projects\Projects\SSV\CMS\Views\Admin\MovieList.cshtml"
           Write(Html.DisplayFor(modelItem => item.EntityId));

#line default
#line hidden
            EndContext();
            BeginContext(1014, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1070, 39, false);
#line 46 "D:\Projects\Projects\SSV\CMS\Views\Admin\MovieList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1109, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1165, 43, false);
#line 49 "D:\Projects\Projects\SSV\CMS\Views\Admin\MovieList.cshtml"
           Write(Html.DisplayFor(modelItem => item.ImdbLink));

#line default
#line hidden
            EndContext();
            BeginContext(1208, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1264, 48, false);
#line 52 "D:\Projects\Projects\SSV\CMS\Views\Admin\MovieList.cshtml"
           Write(Html.DisplayFor(modelItem => item.ImageFilePath));

#line default
#line hidden
            EndContext();
            BeginContext(1312, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1368, 45, false);
#line 55 "D:\Projects\Projects\SSV\CMS\Views\Admin\MovieList.cshtml"
           Write(Html.DisplayFor(modelItem => item.ImdbRating));

#line default
#line hidden
            EndContext();
            BeginContext(1413, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1469, 47, false);
#line 58 "D:\Projects\Projects\SSV\CMS\Views\Admin\MovieList.cshtml"
           Write(Html.DisplayFor(modelItem => item.YearReleased));

#line default
#line hidden
            EndContext();
            BeginContext(1516, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1572, 62, false);
#line 61 "D:\Projects\Projects\SSV\CMS\Views\Admin\MovieList.cshtml"
           Write(Html.ActionLink("Edit", "EditMovie", new { id=item.EntityId }));

#line default
#line hidden
            EndContext();
            BeginContext(1634, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 64 "D:\Projects\Projects\SSV\CMS\Views\Admin\MovieList.cshtml"
    }

#line default
#line hidden
            BeginContext(1677, 42, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<hr/>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1720, 48, false);
#line 69 "D:\Projects\Projects\SSV\CMS\Views\Admin\MovieList.cshtml"
Write(Html.ActionLink("Back to home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(1768, 11, true);
            WriteLiteral(";\r\n</div>\r\n");
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
