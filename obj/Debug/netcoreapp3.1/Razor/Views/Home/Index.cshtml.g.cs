#pragma checksum "C:\Users\HP\source\repos\MVC\Eterna\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65b0ddfc867df3956c549138a475f03f559257aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65b0ddfc867df3956c549138a475f03f559257aa", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06f9f16ba9a954e59c273136506cb2ba79fbb9e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/about.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\HP\source\repos\MVC\Eterna\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- ======= Hero Section ======= -->
<section id=""hero"">
    <div class=""hero-container"">
        <div id=""heroCarousel"" data-bs-interval=""5000"" class=""carousel slide carousel-fade"" data-bs-ride=""carousel"">

            <ol class=""carousel-indicators"" id=""hero-carousel-indicators""></ol>

            <div class=""carousel-inner"" role=""listbox"">
");
#nullable restore
#line 15 "C:\Users\HP\source\repos\MVC\Eterna\Views\Home\Index.cshtml"
                 foreach (Slider sliders in Model.Sliders)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <!-- Slide 1 -->\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 555, "\"", 641, 2);
            WriteAttributeValue("", 563, "carousel-item", 563, 13, true);
#nullable restore
#line 18 "C:\Users\HP\source\repos\MVC\Eterna\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 576, Model.Sliders.FirstOrDefault().Id==sliders.Id ? "active" : "", 577, 64, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", "style=\"", 642, "\"", 697, 4);
            WriteAttributeValue("", 649, "background:", 649, 11, true);
            WriteAttributeValue(" ", 660, "url(assets/img/slide/", 661, 22, true);
#nullable restore
#line 18 "C:\Users\HP\source\repos\MVC\Eterna\Views\Home\Index.cshtml"
WriteAttributeValue("", 682, sliders.Image, 682, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 696, ")", 696, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"carousel-container\">\r\n                            <div class=\"carousel-content\">\r\n                                <h2 class=\"animate__animated animate__fadeInDown\">");
#nullable restore
#line 21 "C:\Users\HP\source\repos\MVC\Eterna\Views\Home\Index.cshtml"
                                                                             Write(sliders.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>");
#nullable restore
#line 21 "C:\Users\HP\source\repos\MVC\Eterna\Views\Home\Index.cshtml"
                                                                                                  Write(sliders.KeyWord);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h2>\r\n                                <p class=\"animate__animated animate__fadeInUp\">");
#nullable restore
#line 22 "C:\Users\HP\source\repos\MVC\Eterna\Views\Home\Index.cshtml"
                                                                          Write(sliders.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1084, "\"", 1111, 1);
#nullable restore
#line 23 "C:\Users\HP\source\repos\MVC\Eterna\Views\Home\Index.cshtml"
WriteAttributeValue("", 1091, sliders.RedirectUrl, 1091, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\"btn-get-started animate__animated animate__fadeInUp\">Read More</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 27 "C:\Users\HP\source\repos\MVC\Eterna\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



            </div>

            <a class=""carousel-control-prev"" href=""#heroCarousel"" role=""button"" data-bs-slide=""prev"">
                <span class=""carousel-control-prev-icon bi bi-chevron-left"" aria-hidden=""true""></span>
            </a>

            <a class=""carousel-control-next"" href=""#heroCarousel"" role=""button"" data-bs-slide=""next"">
                <span class=""carousel-control-next-icon bi bi-chevron-right"" aria-hidden=""true""></span>
            </a>

        </div>
    </div>
</section><!-- End Hero -->

<main id=""main"">

    <!-- ======= Featured Section ======= -->
    <section id=""featured"" class=""featured"">
        <div class=""container"">

            <div class=""row"">
");
#nullable restore
#line 53 "C:\Users\HP\source\repos\MVC\Eterna\Views\Home\Index.cshtml"
                 foreach(Feature feature in Model.Features) {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-lg-4\">\r\n            <div class=\"icon-box\">\r\n              ");
#nullable restore
#line 57 "C:\Users\HP\source\repos\MVC\Eterna\Views\Home\Index.cshtml"
         Write(Html.Raw(feature.Icon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <h3><a");
            BeginWriteAttribute("href", " href=\"", 2236, "\"", 2243, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 58 "C:\Users\HP\source\repos\MVC\Eterna\Views\Home\Index.cshtml"
                          Write(feature.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                <p>");
#nullable restore
#line 59 "C:\Users\HP\source\repos\MVC\Eterna\Views\Home\Index.cshtml"
              Write(feature.Descr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 62 "C:\Users\HP\source\repos\MVC\Eterna\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>

        </div>
    </section><!-- End Featured Section -->
    <!-- ======= About Section ======= -->
    <section id=""about"" class=""about"">
        <div class=""container"">

            <div class=""row"">
                <div class=""col-lg-6"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "65b0ddfc867df3956c549138a475f03f559257aa10354", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""col-lg-6 pt-4 pt-lg-0 content"">
                    <h3>Voluptatem dignissimos provident quasi corporis voluptates sit assumenda.</h3>
                    <p class=""fst-italic"">
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore
                        magna aliqua.
                    </p>
                    <ul>
                        <li><i class=""bi bi-check-circle""></i> Ullamco laboris nisi ut aliquip ex ea commodo consequat.</li>
                        <li><i class=""bi bi-check-circle""></i> Duis aute irure dolor in reprehenderit in voluptate velit.</li>
                        <li><i class=""bi bi-check-circle""></i> Ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate trideta storacalaperda mastiro dolore eu fugiat nulla pariatur.</li>
                    </ul>
                    <p>
               ");
            WriteLiteral(@"         Ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate
                        velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in
                        culpa qui officia deserunt mollit anim id est laborum
                    </p>
                </div>
            </div>

        </div>
    </section><!-- End About Section -->
    <!-- ======= Services Section ======= -->
    <section id=""services"" class=""services"">
        <div class=""container"">

            <div class=""row"">
                <div class=""col-lg-4 col-md-6 d-flex align-items-stretch"">
                    <div class=""icon-box"">
                        <div class=""icon""><i class=""bx bxl-dribbble""></i></div>
                        <h4><a");
            BeginWriteAttribute("href", " href=\"", 4590, "\"", 4597, 0);
            EndWriteAttribute();
            WriteLiteral(@">Lorem Ipsum</a></h4>
                        <p>Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi</p>
                    </div>
                </div>

                <div class=""col-lg-4 col-md-6 d-flex align-items-stretch mt-4 mt-md-0"">
                    <div class=""icon-box"">
                        <div class=""icon""><i class=""bx bx-file""></i></div>
                        <h4><a");
            BeginWriteAttribute("href", " href=\"", 5022, "\"", 5029, 0);
            EndWriteAttribute();
            WriteLiteral(@">Sed ut perspiciatis</a></h4>
                        <p>Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore</p>
                    </div>
                </div>

                <div class=""col-lg-4 col-md-6 d-flex align-items-stretch mt-4 mt-lg-0"">
                    <div class=""icon-box"">
                        <div class=""icon""><i class=""bx bx-tachometer""></i></div>
                        <h4><a");
            BeginWriteAttribute("href", " href=\"", 5469, "\"", 5476, 0);
            EndWriteAttribute();
            WriteLiteral(@">Magni Dolores</a></h4>
                        <p>Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia</p>
                    </div>
                </div>

                <div class=""col-lg-4 col-md-6 d-flex align-items-stretch mt-4"">
                    <div class=""icon-box"">
                        <div class=""icon""><i class=""bx bx-world""></i></div>
                        <h4><a");
            BeginWriteAttribute("href", " href=\"", 5894, "\"", 5901, 0);
            EndWriteAttribute();
            WriteLiteral(@">Nemo Enim</a></h4>
                        <p>At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis</p>
                    </div>
                </div>

                <div class=""col-lg-4 col-md-6 d-flex align-items-stretch mt-4"">
                    <div class=""icon-box"">
                        <div class=""icon""><i class=""bx bx-slideshow""></i></div>
                        <h4><a");
            BeginWriteAttribute("href", " href=\"", 6319, "\"", 6326, 0);
            EndWriteAttribute();
            WriteLiteral(@">Dele cardo</a></h4>
                        <p>Quis consequatur saepe eligendi voluptatem consequatur dolor consequuntur</p>
                    </div>
                </div>

                <div class=""col-lg-4 col-md-6 d-flex align-items-stretch mt-4"">
                    <div class=""icon-box"">
                        <div class=""icon""><i class=""bx bx-arch""></i></div>
                        <h4><a");
            BeginWriteAttribute("href", " href=\"", 6740, "\"", 6747, 0);
            EndWriteAttribute();
            WriteLiteral(@">Divera don</a></h4>
                        <p>Modi nostrum vel laborum. Porro fugit error sit minus sapiente sit aspernatur</p>
                    </div>
                </div>

            </div>

        </div>
    </section><!-- End Services Section -->
    <!-- ======= Clients Section ======= -->
    <section id=""clients"" class=""clients"">
        <div class=""container"">

            <div class=""section-title"">
                <h2>Clients</h2>
                <p>Magnam dolores commodi suscipit. Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate. Et nemo qui impedit suscipit alias ea. Quia fugiat sit in iste officiis commodi quidem hic quas.</p>
            </div>
          
                <div class=""clients-slider swiper"">
                    <div class=""swiper-wrapper align-items-center"">
");
#nullable restore
#line 164 "C:\Users\HP\source\repos\MVC\Eterna\Views\Home\Index.cshtml"
                         foreach (Client client in Model.Clients)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"swiper-slide\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "65b0ddfc867df3956c549138a475f03f559257aa17712", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7806, "~/assets/img/clients/", 7806, 21, true);
#nullable restore
#line 166 "C:\Users\HP\source\repos\MVC\Eterna\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 7827, client.Image, 7827, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 167 "C:\Users\HP\source\repos\MVC\Eterna\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    <div class=\"swiper-pagination\"></div>\r\n                </div>\r\n          \r\n\r\n\r\n        </div>\r\n    </section><!-- End Clients Section -->\r\n\r\n</main><!-- End #main -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
