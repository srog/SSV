#pragma checksum "D:\Projects\Projects\SSV\CMS\Views\Event\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f25f61b84024cbd1859cc89abfc723c056a97673"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_Index), @"mvc.1.0.view", @"/Views/Event/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Event/Index.cshtml", typeof(AspNetCore.Views_Event_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f25f61b84024cbd1859cc89abfc723c056a97673", @"/Views/Event/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fda46ac6a24f19109ebb784fda558b061b2e80b", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventDay>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 39, true);
            WriteLiteral("\r\n<div>\r\n    <h2>\r\n        Events For: ");
            EndContext();
            BeginContext(57, 29, false);
#line 5 "D:\Projects\Projects\SSV\CMS\Views\Event\Index.cshtml"
               Write(Model.Date.ToString("dd MMM"));

#line default
#line hidden
            EndContext();
            BeginContext(86, 518, true);
            WriteLiteral(@"
    </h2>
</div>
<div>
    <table class=""table-striped"" style=""width: 100%"">
        <thead>
        <tr>
            <th>
                Id
            </th>
            <th>
                Name
            </th>
            <th>
                Description
            </th>
            <th>
                Location
            </th>
            <th>
                Status
            </th>
            <th>
                IsPublic
            </th>
        </tr>
        </thead>

");
            EndContext();
#line 33 "D:\Projects\Projects\SSV\CMS\Views\Event\Index.cshtml"
         foreach (var eventRecord in Model.Events)
        {

#line default
#line hidden
            BeginContext(667, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(728, 14, false);
#line 37 "D:\Projects\Projects\SSV\CMS\Views\Event\Index.cshtml"
               Write(eventRecord.Id);

#line default
#line hidden
            EndContext();
            BeginContext(742, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(810, 16, false);
#line 40 "D:\Projects\Projects\SSV\CMS\Views\Event\Index.cshtml"
               Write(eventRecord.Name);

#line default
#line hidden
            EndContext();
            BeginContext(826, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(894, 23, false);
#line 43 "D:\Projects\Projects\SSV\CMS\Views\Event\Index.cshtml"
               Write(eventRecord.Description);

#line default
#line hidden
            EndContext();
            BeginContext(917, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(985, 20, false);
#line 46 "D:\Projects\Projects\SSV\CMS\Views\Event\Index.cshtml"
               Write(eventRecord.Location);

#line default
#line hidden
            EndContext();
            BeginContext(1005, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1073, 18, false);
#line 49 "D:\Projects\Projects\SSV\CMS\Views\Event\Index.cshtml"
               Write(eventRecord.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1091, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1159, 20, false);
#line 52 "D:\Projects\Projects\SSV\CMS\Views\Event\Index.cshtml"
               Write(eventRecord.IsPublic);

#line default
#line hidden
            EndContext();
            BeginContext(1179, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 55 "D:\Projects\Projects\SSV\CMS\Views\Event\Index.cshtml"

        }

#line default
#line hidden
            BeginContext(1236, 22, true);
            WriteLiteral("    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EventDay> Html { get; private set; }
    }
}
#pragma warning restore 1591