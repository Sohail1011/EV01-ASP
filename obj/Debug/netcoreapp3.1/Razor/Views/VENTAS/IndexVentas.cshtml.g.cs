#pragma checksum "E:\4° Ciclo\Herramientas de Programación 2\Desarrollos de ASP.NET\EV01\Views\VENTAS\IndexVentas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aeb9ae42e9b85275860b6f87efcc15ff3bee2864"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VENTAS_IndexVentas), @"mvc.1.0.view", @"/Views/VENTAS/IndexVentas.cshtml")]
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
#line 1 "E:\4° Ciclo\Herramientas de Programación 2\Desarrollos de ASP.NET\EV01\Views\_ViewImports.cshtml"
using EV01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\4° Ciclo\Herramientas de Programación 2\Desarrollos de ASP.NET\EV01\Views\_ViewImports.cshtml"
using EV01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aeb9ae42e9b85275860b6f87efcc15ff3bee2864", @"/Views/VENTAS/IndexVentas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d36c3ae7a87c810778f7d2868bc450b99ab8132", @"/Views/_ViewImports.cshtml")]
    public class Views_VENTAS_IndexVentas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EV01.Models.VENTAS>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateEntradas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\4° Ciclo\Herramientas de Programación 2\Desarrollos de ASP.NET\EV01\Views\VENTAS\IndexVentas.cshtml"
  
    ViewData["Title"] = "IndexEntradas";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>IndexVentas</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeb9ae42e9b85275860b6f87efcc15ff3bee28643776", async() => {
                WriteLiteral("Nueva Venta");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "E:\4° Ciclo\Herramientas de Programación 2\Desarrollos de ASP.NET\EV01\Views\VENTAS\IndexVentas.cshtml"
           Write(Html.DisplayNameFor(model => model.NroVentas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "E:\4° Ciclo\Herramientas de Programación 2\Desarrollos de ASP.NET\EV01\Views\VENTAS\IndexVentas.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaVentas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "E:\4° Ciclo\Herramientas de Programación 2\Desarrollos de ASP.NET\EV01\Views\VENTAS\IndexVentas.cshtml"
           Write(Html.DisplayNameFor(model => model.Medicamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "E:\4° Ciclo\Herramientas de Programación 2\Desarrollos de ASP.NET\EV01\Views\VENTAS\IndexVentas.cshtml"
           Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "E:\4° Ciclo\Herramientas de Programación 2\Desarrollos de ASP.NET\EV01\Views\VENTAS\IndexVentas.cshtml"
           Write(Html.DisplayNameFor(model => model.Cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "E:\4° Ciclo\Herramientas de Programación 2\Desarrollos de ASP.NET\EV01\Views\VENTAS\IndexVentas.cshtml"
           Write(Html.DisplayNameFor(model => model.Importe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "E:\4° Ciclo\Herramientas de Programación 2\Desarrollos de ASP.NET\EV01\Views\VENTAS\IndexVentas.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "E:\4° Ciclo\Herramientas de Programación 2\Desarrollos de ASP.NET\EV01\Views\VENTAS\IndexVentas.cshtml"
               Write(item.NroVentas);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "E:\4° Ciclo\Herramientas de Programación 2\Desarrollos de ASP.NET\EV01\Views\VENTAS\IndexVentas.cshtml"
               Write(Html.DisplayFor(modelItem => item.FechaVentas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "E:\4° Ciclo\Herramientas de Programación 2\Desarrollos de ASP.NET\EV01\Views\VENTAS\IndexVentas.cshtml"
               Write(Html.DisplayFor(modelItem => item.Medicamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "E:\4° Ciclo\Herramientas de Programación 2\Desarrollos de ASP.NET\EV01\Views\VENTAS\IndexVentas.cshtml"
               Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "E:\4° Ciclo\Herramientas de Programación 2\Desarrollos de ASP.NET\EV01\Views\VENTAS\IndexVentas.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "E:\4° Ciclo\Herramientas de Programación 2\Desarrollos de ASP.NET\EV01\Views\VENTAS\IndexVentas.cshtml"
               Write(Html.DisplayFor(modelItem => item.Importe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "E:\4° Ciclo\Herramientas de Programación 2\Desarrollos de ASP.NET\EV01\Views\VENTAS\IndexVentas.cshtml"
               Write(Html.ActionLink("Editar", "EditVentas", new { id = item.NroVentas }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 60 "E:\4° Ciclo\Herramientas de Programación 2\Desarrollos de ASP.NET\EV01\Views\VENTAS\IndexVentas.cshtml"
               Write(Html.ActionLink("Detalle", "DetailsVentas",
                                                /**/
                                           new { id = item.NroVentas }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 63 "E:\4° Ciclo\Herramientas de Programación 2\Desarrollos de ASP.NET\EV01\Views\VENTAS\IndexVentas.cshtml"
               Write(Html.ActionLink("Eliminar", "DeleteVentas", new { id = item.NroVentas }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 66 "E:\4° Ciclo\Herramientas de Programación 2\Desarrollos de ASP.NET\EV01\Views\VENTAS\IndexVentas.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EV01.Models.VENTAS>> Html { get; private set; }
    }
}
#pragma warning restore 1591