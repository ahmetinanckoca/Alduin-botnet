#pragma checksum "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\Stream.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0598646100d63fae900e6375b15a2c793fe2a524"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_List_Stream), @"mvc.1.0.view", @"/Views/List/Stream.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/List/Stream.cshtml", typeof(AspNetCore.Views_List_Stream))]
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
#line 1 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\_ViewImports.cshtml"
using Alduin.Web;

#line default
#line hidden
#line 2 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\_ViewImports.cshtml"
using Alduin.Web.Models;

#line default
#line hidden
#line 4 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0598646100d63fae900e6375b15a2c793fe2a524", @"/Views/List/Stream.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df02d679023bc56e9cc697f1d66d605b9a4371f2", @"/Views/_ViewImports.cshtml")]
    public class Views_List_Stream : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StreamModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(20, 178, true);
            WriteLiteral("<div class=\"container d-flex justify-content-center\">\r\n    <div class=\"wide-board\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12 text-center\">\r\n                <h2>");
            EndContext();
            BeginContext(199, 20, false);
#line 6 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\Stream.cshtml"
               Write(Localizer["Streams"]);

#line default
#line hidden
            EndContext();
            BeginContext(219, 167, true);
            WriteLiteral("</h2>\r\n                <hr />\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <div id=\"list\"></div>\r\n");
            EndContext();
#line 13 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\Stream.cshtml"
                 for(int i = 0; i < Model.NewVariables.Length; i++)
                {

#line default
#line hidden
            BeginContext(474, 117, true);
            WriteLiteral("                    <div class=\"row\">\r\n                        <div class=\"col-12\">\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 591, "\"", 653, 3);
            WriteAttributeValue("", 597, "http://", 597, 7, true);
#line 17 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\Stream.cshtml"
WriteAttributeValue("", 604, Model.NewVariables[i].Domain, 604, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 633, ":50371/GetScreenShot", 633, 20, true);
            EndWriteAttribute();
            BeginContext(654, 144, true);
            WriteLiteral(" class=\"screenshot\" />\r\n                        </div>\r\n                        <div class=\"col-12\">\r\n                            <h3>Bot name: ");
            EndContext();
            BeginContext(799, 26, false);
#line 20 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\Stream.cshtml"
                                     Write(Model.NewVariables[i].Name);

#line default
#line hidden
            EndContext();
            BeginContext(825, 99, true);
            WriteLiteral("</h3>\r\n                        </div>\r\n                        <hr />\r\n                    </div>\r\n");
            EndContext();
#line 24 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\List\Stream.cshtml"
                }

#line default
#line hidden
            BeginContext(943, 56, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(999, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0598646100d63fae900e6375b15a2c793fe2a5246276", async() => {
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
            BeginContext(1050, 25, true);
            WriteLiteral("\r\n<script>\r\n\r\n</script>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StreamModel> Html { get; private set; }
    }
}
#pragma warning restore 1591