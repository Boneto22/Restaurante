#pragma checksum "C:\Users\Dylan\Documents\Proyectos\restaurante\restaurante\restaurante.app.webapp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "238bd75aaef5409bd2406d1fa10f0e6c4f54778c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Restaurante.App.WebApp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Restaurante.App.WebApp.Pages
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
#line 1 "C:\Users\Dylan\Documents\Proyectos\restaurante\restaurante\restaurante.app.webapp\Pages\_ViewImports.cshtml"
using Restaurante.App.WebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"238bd75aaef5409bd2406d1fa10f0e6c4f54778c", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"206c7b2f286d12b43683d2fa297be3ea100894d1", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Dylan\Documents\Proyectos\restaurante\restaurante\restaurante.app.webapp\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Inicio contenido -->
<section class=""message d-flex align-items-center section-bg bg-light"">
    <div class=""container"">
        <div class=""row justify-content-between gy-5"">
            <!-- Inicio Mensaje -->
            <div
                class=""col-lg-5 order-2 order-lg-1 d-flex flex-column justify-content-center align-items-center align-items-lg-start text-center text-lg-start p-4 "">
                <div class=""row m-2"">
                    <h2 class=""col-12"">Bienvenido</h2>
                    <br />
                    <span class=""col-12 span-text"">Disfruta de la comida</span>
                </div>
                <p class=""min-text"">
                    Sed autem laudantium dolores. Voluptatem itaque ea consequatur eveniet.
                    Eum quas beatae cumque eum quaerat.
                </p>
            </div> <!-- Final Mensaje Mensaje -->
            <div class=""col-lg-5 order-1 order-lg-2 text-center text-lg-start"">
                <img src=""Img/Burger-Food.p");
            WriteLiteral("ng\" class=\"img-fluid\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section> <!-- Final Contenido -->\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
