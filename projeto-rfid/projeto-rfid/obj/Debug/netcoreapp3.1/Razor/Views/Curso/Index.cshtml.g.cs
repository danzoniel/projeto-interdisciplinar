#pragma checksum "D:\PROJETO\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Curso\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d5d8ed26638fd1088ee4bcec593ecd42dda0867"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curso_Index), @"mvc.1.0.view", @"/Views/Curso/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d5d8ed26638fd1088ee4bcec593ecd42dda0867", @"/Views/Curso/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84139d67d126f0b4306dad0b0cec27cd30ed9525", @"/Views/_ViewImports.cshtml")]
    public class Views_Curso_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CursoViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\PROJETO\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Curso\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""titulo"" style=""display:flex; align-items:center; justify-content:center"">
    <h1 style=""color: #0168B3"">Lista Curso</h1>
</div>

<div class=""conteudo"" style=""display:flex; align-items:center; justify-content:center; width:100%; margin-top:10px"">
    <div class=""conteudo-2"">
        <a href=""/curso/Create"">Cadastrar novo Curso</a>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <a href=""/professor/Configuracoes"">Voltar</a>
        <table class=""table table-responsive table-hover"">
            <tr style=""color: #0168B3"">
                <th>Ações</th>
                <th>Curso</th>
                <th>Período</th>
                <th>Semestre</th>
            </tr>
");
#nullable restore
#line 23 "D:\PROJETO\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Curso\Index.cshtml"
             foreach (var curso in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 913, "\"", 944, 2);
            WriteAttributeValue("", 920, "/curso/Edit?id=", 920, 15, true);
#nullable restore
#line 27 "D:\PROJETO\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Curso\Index.cshtml"
WriteAttributeValue("", 935, curso.Id, 935, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 984, "\"", 1024, 3);
            WriteAttributeValue("", 991, "javascript:apagarCurso(", 991, 23, true);
#nullable restore
#line 28 "D:\PROJETO\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Curso\Index.cshtml"
WriteAttributeValue("", 1014, curso.Id, 1014, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1023, ")", 1023, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Excluir</a>\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 30 "D:\PROJETO\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Curso\Index.cshtml"
                   Write(curso.Nome_curso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "D:\PROJETO\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Curso\Index.cshtml"
                   Write(curso.Periodo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "D:\PROJETO\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Curso\Index.cshtml"
                   Write(curso.Semestre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 34 "D:\PROJETO\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Curso\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </table>

        <script>
            function apagarCurso(id) {
                if (confirm('Confirma a exclusão do registro?'))
                    location.href = '/Professor/delete?id=' + id;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CursoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
