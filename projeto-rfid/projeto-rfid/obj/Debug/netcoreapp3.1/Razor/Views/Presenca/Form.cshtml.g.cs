#pragma checksum "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70034ac51559385c8ed049acb798405ff697b44a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Presenca_Form), @"mvc.1.0.view", @"/Views/Presenca/Form.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70034ac51559385c8ed049acb798405ff697b44a", @"/Views/Presenca/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84139d67d126f0b4306dad0b0cec27cd30ed9525", @"/Views/_ViewImports.cshtml")]
    public class Views_Presenca_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PresencaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Save", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:flex; align-items:center; width:100%; justify-content: center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Form.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Form.cshtml"
 if (ViewBag.Operacao == "I")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"titulo\" style=\"display:flex; align-items:center; justify-content:center\">\r\n        <h1 style=\"color: #0168B3\">Cadastrar Presença</h1>\r\n    </div>\r\n");
#nullable restore
#line 11 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Form.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"titulo\" style=\"display:flex; align-items:center; justify-content:center\">\r\n        <h1 style=\"color: #0168B3\">Editar Presença</h1>\r\n    </div>\r\n");
#nullable restore
#line 17 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Form.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70034ac51559385c8ed049acb798405ff697b44a6488", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"Operacao\"");
                BeginWriteAttribute("value", " value=\"", 653, "\"", 678, 1);
#nullable restore
#line 22 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Form.cshtml"
WriteAttributeValue("", 661, ViewBag.Operacao, 661, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n    <div class=\"conteudo\" style=\"width:65%\">\r\n        <label for=\"id\" class=\"control-label\" style=\"color: #0168B3\">ID</label>\r\n\r\n");
#nullable restore
#line 27 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Form.cshtml"
         if (ViewBag.Operacao == "I")
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"number\" Name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 907, "\"", 924, 1);
#nullable restore
#line 29 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Form.cshtml"
WriteAttributeValue("", 915, Model.Id, 915, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control disabled\" readonly />\r\n            <!--<input asp-for=\"id\" class=\"form-control\" />-->\r\n");
#nullable restore
#line 31 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Form.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"number\" Name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 1111, "\"", 1128, 1);
#nullable restore
#line 34 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Form.cshtml"
WriteAttributeValue("", 1119, Model.Id, 1119, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control disabled\" readonly />\r\n            <!--<input asp-for=\"Id\" class=\"form-control\" readonly />-->\r\n");
#nullable restore
#line 36 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Form.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <label for=\"Id_aluno_fk\" class=\"control-label\" style=\"color: #0168B3\">RA Aluno</label>\r\n        <input type=\"number\" Name=\"Id_aluno_fk\"");
                BeginWriteAttribute("value", " value=\"", 1402, "\"", 1428, 1);
#nullable restore
#line 39 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Form.cshtml"
WriteAttributeValue("", 1410, Model.Id_aluno_fk, 1410, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n        <!--<input asp-validation-for=\"Nome\" class=\"form-control\" />-->\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70034ac51559385c8ed049acb798405ff697b44a9880", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 41 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Form.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id_aluno_fk);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <br />\r\n\r\n        <label for=\"Id_prof_fk\" class=\"control-label\" style=\"color: #0168B3\">RA Professor</label>\r\n        <input type=\"number\" Name=\"Id_prof_fk\"");
                BeginWriteAttribute("value", " value=\"", 1767, "\"", 1792, 1);
#nullable restore
#line 45 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Form.cshtml"
WriteAttributeValue("", 1775, Model.Id_prof_fk, 1775, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n        <!--<input asp-validation-for=\"Nome\" class=\"form-control\" />-->\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70034ac51559385c8ed049acb798405ff697b44a12249", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 47 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Form.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id_prof_fk);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <br />\r\n\r\n        <label for=\"Nome_curso_fk\" class=\"control-label\" style=\"color: #0168B3\">Curso</label>\r\n        <input type=\"text\" Name=\"Nome_curso_fk\"");
                BeginWriteAttribute("value", " value=\"", 2127, "\"", 2155, 1);
#nullable restore
#line 51 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Form.cshtml"
WriteAttributeValue("", 2135, Model.Nome_curso_fk, 2135, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n        <!--<input asp-validation-for=\"Nome\" class=\"form-control\" />-->\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70034ac51559385c8ed049acb798405ff697b44a14618", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 53 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Form.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Nome_curso_fk);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <br />\r\n\r\n        <label for=\"Nome_materia_fk\" class=\"control-label\" style=\"color: #0168B3\">Matéria</label>\r\n        <input type=\"text\" Name=\"Nome_materia_fk\"");
                BeginWriteAttribute("value", " value=\"", 2499, "\"", 2529, 1);
#nullable restore
#line 57 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Form.cshtml"
WriteAttributeValue("", 2507, Model.Nome_materia_fk, 2507, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n        <!--<input asp-validation-for=\"Nome\" class=\"form-control\" />-->\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70034ac51559385c8ed049acb798405ff697b44a16998", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 59 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Form.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Nome_materia_fk);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <br />\r\n\r\n        <label for=\"Periodo_curso_fk\" class=\"control-label\" style=\"color: #0168B3\">Período</label>\r\n        <input type=\"text\" Name=\"Periodo_curso_fk\"");
                BeginWriteAttribute("value", " value=\"", 2877, "\"", 2908, 1);
#nullable restore
#line 63 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Form.cshtml"
WriteAttributeValue("", 2885, Model.Periodo_curso_fk, 2885, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n        <!--<input asp-validation-for=\"Nome\" class=\"form-control\" />-->\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70034ac51559385c8ed049acb798405ff697b44a19383", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 65 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Form.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Periodo_curso_fk);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <br />\r\n\r\n        <label for=\"Semestre_curso_fk\" class=\"control-label\" style=\"color: #0168B3\">Semestre</label>\r\n        <input type=\"number\" Name=\"Semestre_curso_fk\"");
                BeginWriteAttribute("value", " value=\"", 3262, "\"", 3294, 1);
#nullable restore
#line 69 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Form.cshtml"
WriteAttributeValue("", 3270, Model.Semestre_curso_fk, 3270, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n        <!--<input asp-validation-for=\"Nome\" class=\"form-control\" />-->\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70034ac51559385c8ed049acb798405ff697b44a21775", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 71 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Form.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Semestre_curso_fk);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <br />\r\n\r\n        <label for=\"Situacaopresenca\" class=\"control-label\" style=\"color: #0168B3\">Situação</label>\r\n        <input type=\"text\" Name=\"Situacaopresenca\"");
                BeginWriteAttribute("value", " value=\"", 3645, "\"", 3676, 1);
#nullable restore
#line 75 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Form.cshtml"
WriteAttributeValue("", 3653, Model.Situacaopresenca, 3653, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n        <!--<input asp-validation-for=\"Nome\" class=\"form-control\" />-->\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70034ac51559385c8ed049acb798405ff697b44a24163", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 77 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Form.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Situacaopresenca);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <br />\r\n\r\n        <label for=\"Horario_aula\" class=\"control-label\" style=\"color: #0168B3\">Data / Hora</label>\r\n        <input type=\"datetime-local\" Name=\"Horario_aula\"");
                BeginWriteAttribute("value", " value=\"", 4031, "\"", 4087, 1);
#nullable restore
#line 81 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Form.cshtml"
WriteAttributeValue("", 4039, Model.Horario_aula.ToString("yyyy-MM-dd HH:mm"), 4039, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\"/>\r\n        <!--<input asp-validation-for=\"Nome\" class=\"form-control\" />-->\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70034ac51559385c8ed049acb798405ff697b44a26579", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 83 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Presenca\Form.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Horario_aula);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        <br />

        <div class=""buttons"" style=""display:flex; justify-content:space-between"">
            <input type=""submit"" value=""Salvar"" class=""btn btn-success"" style=""width:100%; margin-top:1.5rem"" />
        </div>
    </div>
    <br />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PresencaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
