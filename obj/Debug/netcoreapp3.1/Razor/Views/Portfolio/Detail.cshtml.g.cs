#pragma checksum "C:\Users\HP\source\repos\MVC\Eterna\Views\Portfolio\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7562c0c6e5f46c0df7bfc958f923f89d3423fc45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_Detail), @"mvc.1.0.view", @"/Views/Portfolio/Detail.cshtml")]
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
#nullable restore
#line 3 "C:\Users\HP\source\repos\MVC\Eterna\Views\_ViewImports.cshtml"
using Eterna.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\source\repos\MVC\Eterna\Views\_ViewImports.cshtml"
using Eterna.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7562c0c6e5f46c0df7bfc958f923f89d3423fc45", @"/Views/Portfolio/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06f9f16ba9a954e59c273136506cb2ba79fbb9e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Portfolio_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Portfolio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 2 "C:\Users\HP\source\repos\MVC\Eterna\Views\Portfolio\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main id=""main"">

    <!-- ======= Breadcrumbs ======= -->
    <section id=""breadcrumbs"" class=""breadcrumbs"">
        <div class=""container"">

            <ol>
                <li><a href=""index.html"">Home</a></li>
                <li>Portfolio Details</li>
            </ol>
            <h2>Portfolio Details</h2>

        </div>
    </section><!-- End Breadcrumbs -->
    <!-- ======= Portfolio Details Section ======= -->
    <section id=""portfolio-details"" class=""portfolio-details"">
        <div class=""container"">

            <div class=""row gy-4"">

                <div class=""col-lg-8"">
                    <div class=""portfolio-details-slider swiper"">
                        <div class=""swiper-wrapper align-items-center"">
");
#nullable restore
#line 29 "C:\Users\HP\source\repos\MVC\Eterna\Views\Portfolio\Detail.cshtml"
                             foreach (Portfolioimage portfolioimage in Model.Portfolioimages)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"swiper-slide\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7562c0c6e5f46c0df7bfc958f923f89d3423fc454774", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1051, "~/assets/img/portfolio/", 1051, 23, true);
#nullable restore
#line 32 "C:\Users\HP\source\repos\MVC\Eterna\Views\Portfolio\Detail.cshtml"
AddHtmlAttributeValue("", 1074, portfolioimage.Image, 1074, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 34 "C:\Users\HP\source\repos\MVC\Eterna\Views\Portfolio\Detail.cshtml"


                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                        <div class=""swiper-pagination""></div>
                    </div>
                </div>

                <div class=""col-lg-4"">
                    <div class=""portfolio-info"">
                        <h3>");
#nullable restore
#line 46 "C:\Users\HP\source\repos\MVC\Eterna\Views\Portfolio\Detail.cshtml"
                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <ul>\r\n                          \r\n                            <li><strong>Category</strong> :Web,Programming</li>\r\n                           \r\n\r\n                            <li><strong>Client</strong>: ");
#nullable restore
#line 52 "C:\Users\HP\source\repos\MVC\Eterna\Views\Portfolio\Detail.cshtml"
                                                    Write(Model.Client);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li><strong>Project date</strong>: ");
#nullable restore
#line 53 "C:\Users\HP\source\repos\MVC\Eterna\Views\Portfolio\Detail.cshtml"
                                                          Write(Model.Date.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li><strong>Project URL</strong>: <a href=\"#\">");
#nullable restore
#line 54 "C:\Users\HP\source\repos\MVC\Eterna\Views\Portfolio\Detail.cshtml"
                                                                     Write(Model.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                        </ul>\r\n                    </div>\r\n                    <div class=\"portfolio-description\">\r\n                        <h2>");
#nullable restore
#line 58 "C:\Users\HP\source\repos\MVC\Eterna\Views\Portfolio\Detail.cshtml"
                       Write(Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                        <p>
                            Autem ipsum nam porro corporis rerum. Quis eos dolorem eos itaque inventore commodi labore quia quia. Exercitationem repudiandae officiis neque suscipit non officia eaque itaque enim. Voluptatem officia accusantium nesciunt est omnis tempora consectetur dignissimos. Sequi nulla at esse enim cum deserunt eius.
                        </p>
                    </div>
                </div>

            </div>

        </div>
    </section><!-- End Portfolio Details Section -->

</main><!-- End #main -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Portfolio> Html { get; private set; }
    }
}
#pragma warning restore 1591