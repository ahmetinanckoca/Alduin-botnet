#pragma checksum "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66c24c0d136b312532706ba2690e979be2c3e586"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66c24c0d136b312532706ba2690e979be2c3e586", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df02d679023bc56e9cc697f1d66d605b9a4371f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/dragon logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 193, true);
            WriteLiteral("    <div class=\"contatiner d-flex justify-content-center\">\r\n        <div class=\"medium-board\">\r\n            <div class=\"text-center\">\r\n                <div class=\"col-12\"><h1 class=\"display-4\">");
            EndContext();
            BeginContext(239, 19, false);
#line 7 "E:\project\Alduin-botnet\Alduin\Alduin.Web\Views\Home\Index.cshtml"
                                                     Write(ViewData["Welcome"]);

#line default
#line hidden
            EndContext();
            BeginContext(258, 95, true);
            WriteLiteral("</h1></div>\r\n                <hr />\r\n                <div class=\"col-12\">\r\n                    ");
            EndContext();
            BeginContext(353, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "66c24c0d136b312532706ba2690e979be2c3e5864842", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(401, 2839, true);
            WriteLiteral(@"

                </div>
                <hr />
                <div class=""row"">
                    <div class=""col-4"">Coded by: Mogyiii</div>
                    <div class=""col-4""><a href=""https://github.com/mogyiii/Alduin-botnet/blob/master/LICENSE"" class=""btn btn-outline-primary"">LICENSE</a></div>
                    <div class=""col-4"">Version: Alfpha 0.2</div>
                </div>
                <hr />
                <div class=""row mt-5 mb-5"">
                    <div class=""col-3"">
                        <a href=""https://github.com/mogyiii/Alduin-botnet"">
                            <div class=""titles"">
                                <p>
                                    Source code
                                </p>
                                <img src=""https://github.githubassets.com/images/modules/logos_page/Octocat.png"" width=""50"" />
                            </div>
                        </a>
                    </div>
                    <div class=""col-3"">");
            WriteLiteral(@"
                        <a href=""https://github.com/mogyiii/Alduin-botnet/wiki"">
                            <div class=""titles"">
                                <p>
                                    Wiki
                                </p>
                                <img src=""https://upload.wikimedia.org/wikipedia/en/thumb/8/80/Wikipedia-logo-v2.svg/220px-Wikipedia-logo-v2.svg.png"" width=""50"" />
                            </div>
                        </a>
                    </div>
                    <div class=""col-3"">
                        <a href=""https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=2A2ATBMR8CJUC&source=url"">
                            <div class=""titles"">
                                <p>
                                    Donate
                                    with
                                    Paypal
                                </p>
                                <img src=""https://www.paypalobjects.com/digitalassets/c/");
            WriteLiteral(@"website/marketing/na/us/logo-center/Badge_1.png"" width=""50"" />
                            </div>
                        </a>
                    </div>
                    <div class=""col-3"">
                        <a href=""/Home/Monero"">
                            <div class=""titles"">
                                <p>
                                    Donate
                                    Me
                                    Monero
                                </p>
                                <img src=""https://web.getmonero.org/press-kit/symbols/monero-symbol-480.png"" width=""50"" />
                            </div>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
