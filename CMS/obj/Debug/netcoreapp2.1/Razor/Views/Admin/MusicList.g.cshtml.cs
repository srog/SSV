#pragma checksum "D:\Projects\Projects\SSV\CMS\Views\Admin\MusicList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05984ec1dc187bec47679c3a955c7f6e612c7d5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_MusicList), @"mvc.1.0.view", @"/Views/Admin/MusicList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/MusicList.cshtml", typeof(AspNetCore.Views_Admin_MusicList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05984ec1dc187bec47679c3a955c7f6e612c7d5d", @"/Views/Admin/MusicList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fda46ac6a24f19109ebb784fda558b061b2e80b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_MusicList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CMS.Models.MusicDetails>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateMusic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Projects\Projects\SSV\CMS\Views\Admin\MusicList.cshtml"
  
    ViewData["Title"] = "MusicList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(139, 58, true);
            WriteLiteral("<br />\r\n<br />\r\n\r\n<h2>Admin - Music List</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(197, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b65a231ac854b2f8e0b44f2b6727404", async() => {
                BeginContext(225, 16, true);
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
            BeginContext(245, 10, true);
            WriteLiteral("\r\n</p>\r\n\r\n");
            EndContext();
#line 16 "D:\Projects\Projects\SSV\CMS\Views\Admin\MusicList.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
            BeginContext(284, 32, true);
            WriteLiteral("    <h3>Nothing here yet!</h3>\r\n");
            EndContext();
#line 19 "D:\Projects\Projects\SSV\CMS\Views\Admin\MusicList.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(328, 132, true);
            WriteLiteral("    <table class=\"table-bordered\" style=\"width:100%\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(461, 44, false);
#line 26 "D:\Projects\Projects\SSV\CMS\Views\Admin\MusicList.cshtml"
               Write(Html.DisplayNameFor(model => model.EntityId));

#line default
#line hidden
            EndContext();
            BeginContext(505, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(573, 40, false);
#line 29 "D:\Projects\Projects\SSV\CMS\Views\Admin\MusicList.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(613, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(681, 47, false);
#line 32 "D:\Projects\Projects\SSV\CMS\Views\Admin\MusicList.cshtml"
               Write(Html.DisplayNameFor(model => model.SpotifyLink));

#line default
#line hidden
            EndContext();
            BeginContext(728, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(796, 49, false);
#line 35 "D:\Projects\Projects\SSV\CMS\Views\Admin\MusicList.cshtml"
               Write(Html.DisplayNameFor(model => model.ImageFilePath));

#line default
#line hidden
            EndContext();
            BeginContext(845, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(913, 48, false);
#line 38 "D:\Projects\Projects\SSV\CMS\Views\Admin\MusicList.cshtml"
               Write(Html.DisplayNameFor(model => model.YearReleased));

#line default
#line hidden
            EndContext();
            BeginContext(961, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 44 "D:\Projects\Projects\SSV\CMS\Views\Admin\MusicList.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1124, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1197, 43, false);
#line 48 "D:\Projects\Projects\SSV\CMS\Views\Admin\MusicList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EntityId));

#line default
#line hidden
            EndContext();
            BeginContext(1240, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1320, 39, false);
#line 51 "D:\Projects\Projects\SSV\CMS\Views\Admin\MusicList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1359, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1439, 46, false);
#line 54 "D:\Projects\Projects\SSV\CMS\Views\Admin\MusicList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SpotifyLink));

#line default
#line hidden
            EndContext();
            BeginContext(1485, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1565, 48, false);
#line 57 "D:\Projects\Projects\SSV\CMS\Views\Admin\MusicList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ImageFilePath));

#line default
#line hidden
            EndContext();
            BeginContext(1613, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1693, 47, false);
#line 60 "D:\Projects\Projects\SSV\CMS\Views\Admin\MusicList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.YearReleased));

#line default
#line hidden
            EndContext();
            BeginContext(1740, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1820, 64, false);
#line 63 "D:\Projects\Projects\SSV\CMS\Views\Admin\MusicList.cshtml"
                   Write(Html.ActionLink("Edit", "EditMusic", new { id = item.EntityId }));

#line default
#line hidden
            EndContext();
            BeginContext(1884, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 66 "D:\Projects\Projects\SSV\CMS\Views\Admin\MusicList.cshtml"
            }

#line default
#line hidden
            BeginContext(1951, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 69 "D:\Projects\Projects\SSV\CMS\Views\Admin\MusicList.cshtml"
}

#line default
#line hidden
            BeginContext(1986, 19, true);
            WriteLiteral("<hr />\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2006, 55, false);
#line 72 "D:\Projects\Projects\SSV\CMS\Views\Admin\MusicList.cshtml"
Write(Html.ActionLink("Back to Admin Home", "Index", "Admin"));

#line default
#line hidden
            EndContext();
            BeginContext(2061, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CMS.Models.MusicDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591
