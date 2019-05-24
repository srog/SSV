#pragma checksum "D:\Code\CMS\CMS\Views\Blog\Blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "629209c16b0a1153cb1b5aa5d9850fb56b7531cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Blog), @"mvc.1.0.view", @"/Views/Blog/Blog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Blog.cshtml", typeof(AspNetCore.Views_Blog_Blog))]
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
#line 1 "D:\Code\CMS\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#line 2 "D:\Code\CMS\CMS\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"629209c16b0a1153cb1b5aa5d9850fb56b7531cc", @"/Views/Blog/Blog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fda46ac6a24f19109ebb784fda558b061b2e80b", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CMS.Models.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Code\CMS\CMS\Views\Blog\Blog.cshtml"
  
    ViewData["Title"] = "Blog";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(113, 15, true);
            WriteLiteral("\r\n\r\n<h2>Blog - ");
            EndContext();
            BeginContext(129, 10, false);
#line 9 "D:\Code\CMS\CMS\Views\Blog\Blog.cshtml"
      Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(139, 14, true);
            WriteLiteral("</h2>\r\n\r\n<p>\r\n");
            EndContext();
#line 12 "D:\Code\CMS\CMS\Views\Blog\Blog.cshtml"
     using (Html.BeginForm("CreateBlogItem", "Blog", new { blogId = Model.Id }, FormMethod.Post))
    {


#line default
#line hidden
            BeginContext(261, 154, true);
            WriteLiteral("        <table class=\"table-bordered\" style=\"width:100%\">\r\n            <thead>\r\n                <tr>\r\n\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(416, 66, false);
#line 20 "D:\Code\CMS\CMS\Views\Blog\Blog.cshtml"
                   Write(Html.DisplayNameFor(model => model.Items.FirstOrDefault().Created));

#line default
#line hidden
            EndContext();
            BeginContext(482, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(562, 68, false);
#line 23 "D:\Code\CMS\CMS\Views\Blog\Blog.cshtml"
                   Write(Html.DisplayNameFor(model => model.Items.FirstOrDefault().CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(630, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(710, 63, false);
#line 26 "D:\Code\CMS\CMS\Views\Blog\Blog.cshtml"
                   Write(Html.DisplayNameFor(model => model.Items.FirstOrDefault().Text));

#line default
#line hidden
            EndContext();
            BeginContext(773, 126, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 32 "D:\Code\CMS\CMS\Views\Blog\Blog.cshtml"
                 foreach (var item in Model.Items)
                {

#line default
#line hidden
            BeginContext(970, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1055, 42, false);
#line 36 "D:\Code\CMS\CMS\Views\Blog\Blog.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Created));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1189, 44, false);
#line 39 "D:\Code\CMS\CMS\Views\Blog\Blog.cshtml"
                       Write(Html.DisplayFor(modelItem => item.CreatedBy));

#line default
#line hidden
            EndContext();
            BeginContext(1233, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1325, 39, false);
#line 42 "D:\Code\CMS\CMS\Views\Blog\Blog.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Text));

#line default
#line hidden
            EndContext();
            BeginContext(1364, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1456, 65, false);
#line 45 "D:\Code\CMS\CMS\Views\Blog\Blog.cshtml"
                       Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1521, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(1554, 71, false);
#line 46 "D:\Code\CMS\CMS\Views\Blog\Blog.cshtml"
                       Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1625, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(1658, 69, false);
#line 47 "D:\Code\CMS\CMS\Views\Blog\Blog.cshtml"
                       Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1727, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 50 "D:\Code\CMS\CMS\Views\Blog\Blog.cshtml"
                }

#line default
#line hidden
            BeginContext(1806, 56, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <br />\r\n");
            EndContext();
            BeginContext(1871, 46, false);
#line 54 "D:\Code\CMS\CMS\Views\Blog\Blog.cshtml"
   Write(Html.TextAreaFor(b => b.NewItem, 5, 100, null));

#line default
#line hidden
            EndContext();
            BeginContext(1919, 62, true);
            WriteLiteral("        <input name=\"Create\" type=\"submit\" value=\"Submit\" />\r\n");
            EndContext();
#line 56 "D:\Code\CMS\CMS\Views\Blog\Blog.cshtml"

    }

#line default
#line hidden
            BeginContext(1990, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CMS.Models.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
