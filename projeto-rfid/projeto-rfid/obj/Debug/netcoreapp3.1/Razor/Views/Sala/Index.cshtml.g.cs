#pragma checksum "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Sala\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "717b28849167aac1c3adf4f7d1c224e4fe2c69fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sala_Index), @"mvc.1.0.view", @"/Views/Sala/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"717b28849167aac1c3adf4f7d1c224e4fe2c69fd", @"/Views/Sala/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84139d67d126f0b4306dad0b0cec27cd30ed9525", @"/Views/_ViewImports.cshtml")]
    public class Views_Sala_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SalaViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Sala\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""titulo"" style=""display:flex; align-items:center; justify-content:center"">
    <h1 style=""color: #0168B3"">Lista Salas</h1>
</div>

<div class=""conteudo"" style=""display:flex; align-items:center; justify-content:center; width:100%; margin-top:10px"">
    <div class=""conteudo-2"">
        <a href=""/sala/Create"">Cadastrar novo Sala</a>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <a href=""/professor/Configuracoes"">Voltar</a>
        <table class=""table table-responsive table-hover"">
            <tr style=""color: #0168B3"">
                <th>Ações</th>
                <th>Sala</th>
            </tr>
");
#nullable restore
#line 21 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Sala\Index.cshtml"
             foreach (var sala in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 839, "\"", 868, 2);
            WriteAttributeValue("", 846, "/sala/Edit?id=", 846, 14, true);
#nullable restore
#line 25 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Sala\Index.cshtml"
WriteAttributeValue("", 860, sala.Id, 860, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 908, "\"", 946, 3);
            WriteAttributeValue("", 915, "javascript:apagarSala(", 915, 22, true);
#nullable restore
#line 26 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Sala\Index.cshtml"
WriteAttributeValue("", 937, sala.Id, 937, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 945, ")", 945, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Excluir</a>\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Sala\Index.cshtml"
                   Write(sala.Numero_sala);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 30 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Sala\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </table>

        <script>
            function apagarSala(id) {
                if (confirm('Confirma a exclusão do registro?'))
                    location.href = '/sala/delete?id=' + id;
            }
        </script>

    </div>
</div>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SalaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591