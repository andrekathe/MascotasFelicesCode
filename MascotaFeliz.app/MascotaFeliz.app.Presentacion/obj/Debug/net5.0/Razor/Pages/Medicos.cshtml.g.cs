#pragma checksum "D:\misionTIC2022\Desarrollo de software\MascotaFeliz\MascotaFeliz.app\MascotaFeliz.app.Presentacion\Pages\Medicos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "544d2fbade5c03b4621e7609b3fc5d309860fd7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.app.Presentacion.Pages.Pages_Medicos), @"mvc.1.0.razor-page", @"/Pages/Medicos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"544d2fbade5c03b4621e7609b3fc5d309860fd7f", @"/Pages/Medicos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14be1b96d3890ab3665ad9189d6e9b36bbb9a15c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Medicos : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Listado de Medicos</h1>\r\n<table class=\"table\">\r\n");
#nullable restore
#line 7 "D:\misionTIC2022\Desarrollo de software\MascotaFeliz\MascotaFeliz.app\MascotaFeliz.app.Presentacion\Pages\Medicos.cshtml"
     foreach (var medico in Model.Medicos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 10 "D:\misionTIC2022\Desarrollo de software\MascotaFeliz\MascotaFeliz.app\MascotaFeliz.app.Presentacion\Pages\Medicos.cshtml"
           Write(medico.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 11 "D:\misionTIC2022\Desarrollo de software\MascotaFeliz\MascotaFeliz.app\MascotaFeliz.app.Presentacion\Pages\Medicos.cshtml"
           Write(medico.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 13 "D:\misionTIC2022\Desarrollo de software\MascotaFeliz\MascotaFeliz.app\MascotaFeliz.app.Presentacion\Pages\Medicos.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.app.Presentacion.Pages.MedicosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.app.Presentacion.Pages.MedicosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.app.Presentacion.Pages.MedicosModel>)PageContext?.ViewData;
        public MascotaFeliz.app.Presentacion.Pages.MedicosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
