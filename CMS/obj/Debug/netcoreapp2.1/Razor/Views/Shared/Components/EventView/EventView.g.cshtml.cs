#pragma checksum "D:\Projects\Projects\SSV\CMS\Views\Shared\Components\EventView\EventView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "341efca8592e9187a0379bdf5fcfe5ef7c6fafa7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_EventView_EventView), @"mvc.1.0.view", @"/Views/Shared/Components/EventView/EventView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/EventView/EventView.cshtml", typeof(AspNetCore.Views_Shared_Components_EventView_EventView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"341efca8592e9187a0379bdf5fcfe5ef7c6fafa7", @"/Views/Shared/Components/EventView/EventView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fda46ac6a24f19109ebb784fda558b061b2e80b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_EventView_EventView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/toggle1_u.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/toggle1_d.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(42, 59, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-1\">\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 101, "\'", 177, 1);
#line 7 "D:\Projects\Projects\SSV\CMS\Views\Shared\Components\EventView\EventView.cshtml"
WriteAttributeValue("", 108, Url.Action("IndexWithOffset", "Home", new { daysOffset = Model - 5}), 108, 69, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(178, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(193, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a936baa163c74cbf9ff137bfd2c8ee6d", async() => {
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
            BeginContext(229, 30, true);
            WriteLiteral("\r\n        </a>\r\n    </div>\r\n\r\n");
            EndContext();
#line 12 "D:\Projects\Projects\SSV\CMS\Views\Shared\Components\EventView\EventView.cshtml"
     for (var index = 0; index < 5; index++)
    {

#line default
#line hidden
            BeginContext(312, 10, true);
            WriteLiteral("        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 322, "\"", 390, 1);
#line 14 "D:\Projects\Projects\SSV\CMS\Views\Shared\Components\EventView\EventView.cshtml"
WriteAttributeValue("", 329, Url.Action("ShowEvents", "Event", new { day = index+Model }), 329, 61, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(391, 55, true);
            WriteLiteral(">\r\n            <div class=\"col-md-1\">\r\n                ");
            EndContext();
            BeginContext(447, 97, false);
#line 16 "D:\Projects\Projects\SSV\CMS\Views\Shared\Components\EventView\EventView.cshtml"
           Write(Component.InvokeAsync("EventDay", new { eventDate = DateTime.Now.AddDays(index + Model) }).Result);

#line default
#line hidden
            EndContext();
            BeginContext(544, 36, true);
            WriteLiteral("\r\n            </div>\r\n        </a>\r\n");
            EndContext();
#line 19 "D:\Projects\Projects\SSV\CMS\Views\Shared\Components\EventView\EventView.cshtml"

    }

#line default
#line hidden
            BeginContext(589, 40, true);
            WriteLiteral("\r\n    <div class=\"col-md-1\">\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 629, "\'", 705, 1);
#line 23 "D:\Projects\Projects\SSV\CMS\Views\Shared\Components\EventView\EventView.cshtml"
WriteAttributeValue("", 636, Url.Action("IndexWithOffset", "Home", new { daysOffset = Model + 5}), 636, 69, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(706, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(721, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1b18d1584d9498482ae37bad67760ac", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(757, 42, true);
            WriteLiteral("\r\n        </a>\r\n    </div>\r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
