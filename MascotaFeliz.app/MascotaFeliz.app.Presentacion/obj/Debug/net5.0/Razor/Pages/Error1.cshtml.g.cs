#pragma checksum "D:\misionTIC2022\Desarrollo de software\MascotaFeliz\MascotaFeliz.app\MascotaFeliz.app.Presentacion\Pages\Error1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d16b8f6bdc4e48b2b4c2e75230fc3b1e0c9d3888"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.app.Presentacion.Pages.Pages_Error1), @"mvc.1.0.razor-page", @"/Pages/Error1.cshtml")]
namespace MascotaFeliz.app.Presentacion.Pages
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
#line 1 "D:\misionTIC2022\Desarrollo de software\MascotaFeliz\MascotaFeliz.app\MascotaFeliz.app.Presentacion\Pages\_ViewImports.cshtml"
using MascotaFeliz.app.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d16b8f6bdc4e48b2b4c2e75230fc3b1e0c9d3888", @"/Pages/Error1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14be1b96d3890ab3665ad9189d6e9b36bbb9a15c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Error1 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\misionTIC2022\Desarrollo de software\MascotaFeliz\MascotaFeliz.app\MascotaFeliz.app.Presentacion\Pages\Error1.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "D:\misionTIC2022\Desarrollo de software\MascotaFeliz\MascotaFeliz.app\MascotaFeliz.app.Presentacion\Pages\Error1.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>Ocurrió un problema al ejecutar su solicitud.</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Error1Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Error1Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Error1Model>)PageContext?.ViewData;
        public Error1Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591