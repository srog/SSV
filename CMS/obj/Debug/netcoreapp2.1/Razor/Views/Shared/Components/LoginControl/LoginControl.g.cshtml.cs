#pragma checksum "D:\Code\SSV\CMS\Views\Shared\Components\LoginControl\LoginControl.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44ff624e199e74b297f631d130e5b4c1896966f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_LoginControl_LoginControl), @"mvc.1.0.view", @"/Views/Shared/Components/LoginControl/LoginControl.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/LoginControl/LoginControl.cshtml", typeof(AspNetCore.Views_Shared_Components_LoginControl_LoginControl))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44ff624e199e74b297f631d130e5b4c1896966f0", @"/Views/Shared/Components/LoginControl/LoginControl.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fda46ac6a24f19109ebb784fda558b061b2e80b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_LoginControl_LoginControl : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Code\SSV\CMS\Views\Shared\Components\LoginControl\LoginControl.cshtml"
 if (Model.Id == 0)
{

#line default
#line hidden
            BeginContext(39, 9, true);
            WriteLiteral("    <h4> ");
            EndContext();
            BeginContext(49, 41, false);
#line 5 "D:\Code\SSV\CMS\Views\Shared\Components\LoginControl\LoginControl.cshtml"
    Write(Html.ActionLink("Login", "Login", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(90, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 6 "D:\Code\SSV\CMS\Views\Shared\Components\LoginControl\LoginControl.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(109, 17, true);
            WriteLiteral("    <h3>Welcome, ");
            EndContext();
            BeginContext(127, 14, false);
#line 9 "D:\Code\SSV\CMS\Views\Shared\Components\LoginControl\LoginControl.cshtml"
            Write(Model.Username);

#line default
#line hidden
            EndContext();
            BeginContext(141, 16, true);
            WriteLiteral("</h3>\r\n    <h4> ");
            EndContext();
            BeginContext(158, 43, false);
#line 10 "D:\Code\SSV\CMS\Views\Shared\Components\LoginControl\LoginControl.cshtml"
    Write(Html.ActionLink("Logout", "Logout", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(201, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 11 "D:\Code\SSV\CMS\Views\Shared\Components\LoginControl\LoginControl.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
