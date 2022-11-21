#pragma checksum "D:\PROJETO\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dce2c41876a780fc32d633ac9a5fde2a4ddad67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Presenca_Index), @"mvc.1.0.view", @"/Views/Presenca/Index.cshtml")]
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
#line 1 "D:\PROJETO\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\_ViewImports.cshtml"
using projeto_rfid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROJETO\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\_ViewImports.cshtml"
using projeto_rfid.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dce2c41876a780fc32d633ac9a5fde2a4ddad67", @"/Views/Presenca/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84139d67d126f0b4306dad0b0cec27cd30ed9525", @"/Views/_ViewImports.cshtml")]
    public class Views_Presenca_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PresencaViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\PROJETO\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""titulo"" style=""display:flex; align-items:center; justify-content:center"">
    <h1 style=""color: #0168B3"">Lista de Presença</h1>
</div>

<div class=""conteudo"" style=""display:flex; align-items:center; justify-content:center; width:100%; margin-top:10px"">
    <div class=""conteudo-2"">
        <a href=""/presenca/Create"">Cadastrar Presença</a>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <a href=""/professor/Configuracoes"">Voltar</a>
        <table class=""table table-responsive table-hover"">
            <tr style=""color: #0168B3"">
                <th>Ações</th>
                <th>Aluno</th>
                <th>Curso</th>
                <th>Matéria</th>
                <th>Professor</th>
                <th>Semestre</th>
                <th>Situação</th>
                <th>Período</th>
                <th>Data / Hora</th>
            </tr>
");
#nullable restore
#line 28 "D:\PROJETO\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Index.cshtml"
             foreach (var presenca in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1101, "\"", 1138, 2);
            WriteAttributeValue("", 1108, "/presenca/Edit?id=", 1108, 18, true);
#nullable restore
#line 32 "D:\PROJETO\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Index.cshtml"
WriteAttributeValue("", 1126, presenca.Id, 1126, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1178, "\"", 1224, 3);
            WriteAttributeValue("", 1185, "javascript:apagarPresenca(", 1185, 26, true);
#nullable restore
#line 33 "D:\PROJETO\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Index.cshtml"
WriteAttributeValue("", 1211, presenca.Id, 1211, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1223, ")", 1223, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Excluir</a>\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 35 "D:\PROJETO\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Index.cshtml"
                   Write(presenca.Id_aluno_fk);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "D:\PROJETO\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Index.cshtml"
                   Write(presenca.Nome_curso_fk);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "D:\PROJETO\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Index.cshtml"
                   Write(presenca.Nome_materia_fk);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "D:\PROJETO\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Index.cshtml"
                   Write(presenca.Id_prof_fk);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "D:\PROJETO\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Index.cshtml"
                   Write(presenca.Semestre_curso_fk);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "D:\PROJETO\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Index.cshtml"
                   Write(presenca.Situacaopresenca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                    \r\n                    <td>");
#nullable restore
#line 41 "D:\PROJETO\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Index.cshtml"
                   Write(presenca.Periodo_curso_fk);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "D:\PROJETO\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Index.cshtml"
                   Write(presenca.Horario_aula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 44 "D:\PROJETO\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </table>

        <script>
            function apagarPresenca(id) {
                if (confirm('Confirma a exclusão do registro?'))
                    location.href = '/presenca/delete?id=' + id;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PresencaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
