#pragma checksum "D:\Code\SSV\CMS\Views\Blog\Blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7ffa253ef118ddf301e84734de8b43940fb67d8"
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
#line 1 "D:\Code\SSV\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#line 2 "D:\Code\SSV\CMS\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7ffa253ef118ddf301e84734de8b43940fb67d8", @"/Views/Blog/Blog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fda46ac6a24f19109ebb784fda558b061b2e80b", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CMS.Models.Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/divider1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("h3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Code\SSV\CMS\Views\Blog\Blog.cshtml"
  
    ViewData["Title"] = "Blog";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(113, 149, true);
            WriteLiteral("\r\n<br /><br /><br /><br /><br />\r\n\r\n<div style=\"width:60%\" class=\"table-bordered\">\r\n    <hr />\r\n    <label class=\"h2\"><strong>Blog Details:</strong> ");
            EndContext();
            BeginContext(263, 10, false);
#line 12 "D:\Code\SSV\CMS\Views\Blog\Blog.cshtml"
                                                Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(273, 74, true);
            WriteLiteral("</label>\r\n    <br />\r\n    <label class=\"h4\"><strong>Created on: </strong> ");
            EndContext();
            BeginContext(348, 13, false);
#line 14 "D:\Code\SSV\CMS\Views\Blog\Blog.cshtml"
                                               Write(Model.Created);

#line default
#line hidden
            EndContext();
            BeginContext(361, 73, true);
            WriteLiteral("</label>\r\n    <br />\r\n    <label class=\"h4\"><strong>Written By:</strong> ");
            EndContext();
            BeginContext(435, 23, false);
#line 16 "D:\Code\SSV\CMS\Views\Blog\Blog.cshtml"
                                              Write(Model.CreatedByFullName);

#line default
#line hidden
            EndContext();
            BeginContext(458, 31, true);
            WriteLiteral("</label>\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(489, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4c4c6e599331400f8ab86926aadd42d2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(524, 59, true);
            WriteLiteral("\r\n</div>\r\n\r\n<label class=\"h4\">Create new entry:</label>\r\n\r\n");
            EndContext();
            BeginContext(584, 54, false);
#line 25 "D:\Code\SSV\CMS\Views\Blog\Blog.cshtml"
Write(Html.TextAreaFor(Model => Model.NewItem, 3, 100, null));

#line default
#line hidden
            EndContext();
            BeginContext(638, 63, true);
            WriteLiteral("\r\n<input name=\"Create\" type=\"submit\" value=\"Post\" />\r\n\r\n\r\n<p>\r\n");
            EndContext();
#line 30 "D:\Code\SSV\CMS\Views\Blog\Blog.cshtml"
     using (Html.BeginForm("CreateBlogItem", "Blog", new { blogId = Model.Id }, FormMethod.Post))
    {

#line default
#line hidden
            BeginContext(807, 14, true);
            WriteLiteral("        <ol>\r\n");
            EndContext();
#line 33 "D:\Code\SSV\CMS\Views\Blog\Blog.cshtml"
             foreach (var item in Model.Items)
            {

#line default
#line hidden
            BeginContext(884, 149, true);
            WriteLiteral("                <li style=\"background-image:repeating-linear-gradient()\">\r\n                    <div class=\"h5\">\r\n                        Created on: ");
            EndContext();
            BeginContext(1034, 42, false);
#line 37 "D:\Code\SSV\CMS\Views\Blog\Blog.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Created));

#line default
#line hidden
            EndContext();
            BeginContext(1076, 62, true);
            WriteLiteral("\r\n                        <br />\r\n                        By: ");
            EndContext();
            BeginContext(1139, 52, false);
#line 39 "D:\Code\SSV\CMS\Views\Blog\Blog.cshtml"
                       Write(Html.DisplayFor(modelItem => item.CreatedByFullName));

#line default
#line hidden
            EndContext();
            BeginContext(1191, 140, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"h4\" style=\"font-family:\'Bodoni MT\'; font-size:22px\">\r\n                        ");
            EndContext();
            BeginContext(1332, 39, false);
#line 42 "D:\Code\SSV\CMS\Views\Blog\Blog.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Text));

#line default
#line hidden
            EndContext();
            BeginContext(1371, 92, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"h4\">\r\n                        ");
            EndContext();
            BeginContext(1464, 83, false);
#line 45 "D:\Code\SSV\CMS\Views\Blog\Blog.cshtml"
                   Write(Html.ActionLink("Delete", "DeleteItem", new { id = item.Id, blogId = item.BlogId }));

#line default
#line hidden
            EndContext();
            BeginContext(1547, 81, true);
            WriteLiteral("\r\n                    </div>\r\n                    <hr />\r\n                </li>\r\n");
            EndContext();
#line 49 "D:\Code\SSV\CMS\Views\Blog\Blog.cshtml"
            }

#line default
#line hidden
            BeginContext(1643, 42, true);
            WriteLiteral("        </ol>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(1685, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d3dbed16afad4967b563b0269d57cd5e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1720, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 54 "D:\Code\SSV\CMS\Views\Blog\Blog.cshtml"
    }

#line default
#line hidden
            BeginContext(1745, 17, true);
            WriteLiteral("</p>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1762, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "858a6b2c88bd4ae880a7e0f0f1357219", async() => {
                BeginContext(1795, 17, true);
                WriteLiteral("Back to Blog Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1816, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CMS.Models.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
