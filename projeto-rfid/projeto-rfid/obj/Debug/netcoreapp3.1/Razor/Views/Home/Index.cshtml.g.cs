#pragma checksum "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "800090ab41473317e002f620f417bbef596a5d4d"
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
#line 1 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\_ViewImports.cshtml"
using projeto_rfid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\_ViewImports.cshtml"
using projeto_rfid.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"800090ab41473317e002f620f417bbef596a5d4d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84139d67d126f0b4306dad0b0cec27cd30ed9525", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""titulo"" style=""display:flex; align-items:center; justify-content:center"">
    <h1 style=""color: #0168B3"">Sistema de Chamada</h1>
</div>
<div class=""container"">
    <div class=""m-5"">
        <h3 style=""color: #0168B3"" class=""m-5 text-center"">Bem - Vindo</h3>
        <img class=""imagemTamanho float-left mb-2"" />
        <p class=""textoTamanho"">
            Registre sua chamada também de forma simple e rápida por meio do nosso site!<br />                    

        </p>
    </div>
</div>
<div>
    <canvas id=""myChart""></canvas>
</div>

<script src=""https://cdn.jsdelivr.net/npm/chart.js""></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
