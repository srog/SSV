#pragma checksum "D:\Projects\Projects\SSV\CMS\Views\Shared\Components\RecentActivity\RecentActivity.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0672cd33811d180f6e4e73dd1bb87c9f8a34186"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_RecentActivity_RecentActivity), @"mvc.1.0.view", @"/Views/Shared/Components/RecentActivity/RecentActivity.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/RecentActivity/RecentActivity.cshtml", typeof(AspNetCore.Views_Shared_Components_RecentActivity_RecentActivity))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0672cd33811d180f6e4e73dd1bb87c9f8a34186", @"/Views/Shared/Components/RecentActivity/RecentActivity.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fda46ac6a24f19109ebb784fda558b061b2e80b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_RecentActivity_RecentActivity : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Activity>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 302, true);
            WriteLiteral(@"
<table class=""table-bordered"" style=""width:100%"">
    <thead>
        <tr>
            <th>
                Activity
            </th>
            <th>
                When
            </th>
            <th>
                Who
            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 18 "D:\Projects\Projects\SSV\CMS\Views\Shared\Components\RecentActivity\RecentActivity.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(364, 50, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=", 414, "", 460, 1);
#line 21 "D:\Projects\Projects\SSV\CMS\Views\Shared\Components\RecentActivity\RecentActivity.cshtml"
WriteAttributeValue("", 420, Html.DisplayFor(modelItem => item.Link), 420, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(460, 24, true);
            WriteLiteral("> \r\n                    ");
            EndContext();
            BeginContext(485, 39, false);
#line 22 "D:\Projects\Projects\SSV\CMS\Views\Shared\Components\RecentActivity\RecentActivity.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(524, 134, true);
            WriteLiteral("\r\n                </a>\r\n\r\n            </td>\r\n            <td>\r\n                \r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(659, 44, false);
#line 30 "D:\Projects\Projects\SSV\CMS\Views\Shared\Components\RecentActivity\RecentActivity.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateAdded));

#line default
#line hidden
            EndContext();
            BeginContext(703, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(759, 43, false);
#line 33 "D:\Projects\Projects\SSV\CMS\Views\Shared\Components\RecentActivity\RecentActivity.cshtml"
           Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
            EndContext();
            BeginContext(802, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 36 "D:\Projects\Projects\SSV\CMS\Views\Shared\Components\RecentActivity\RecentActivity.cshtml"
}

#line default
#line hidden
            BeginContext(841, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Activity>> Html { get; private set; }
    }
}
#pragma warning restore 1591
