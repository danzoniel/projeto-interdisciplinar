#pragma checksum "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Materia\Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9872625eaa857734f628cddffcc0e408af1f6b39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Materia_Form), @"mvc.1.0.view", @"/Views/Materia/Form.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9872625eaa857734f628cddffcc0e408af1f6b39", @"/Views/Materia/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84139d67d126f0b4306dad0b0cec27cd30ed9525", @"/Views/_ViewImports.cshtml")]
    public class Views_Materia_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MateriaViewModel>
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
#line 2 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Materia\Form.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    List<SelectListItem> itemsSelect = ViewBag.Tudo;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Materia\Form.cshtml"
 if (ViewBag.Operacao == "I")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"titulo\" style=\"display:flex; align-items:center; justify-content:center\">\r\n        <h1 style=\"color: #0168B3\">Cadastrar Mat??ria</h1>\r\n    </div>\r\n");
#nullable restore
#line 12 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Materia\Form.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"titulo\" style=\"display:flex; align-items:center; justify-content:center\">\r\n        <h1 style=\"color: #0168B3\">Editar Mat??ria</h1>\r\n    </div>\r\n");
#nullable restore
#line 18 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Materia\Form.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9872625eaa857734f628cddffcc0e408af1f6b396530", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"Operacao\"");
                BeginWriteAttribute("value", " value=\"", 704, "\"", 729, 1);
#nullable restore
#line 23 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Materia\Form.cshtml"
WriteAttributeValue("", 712, ViewBag.Operacao, 712, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n    <div class=\"conteudo\" style=\"width:65%\">\r\n        <label for=\"id\" class=\"control-label\" style=\"color: #0168B3\">ID</label>\r\n\r\n");
#nullable restore
#line 28 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Materia\Form.cshtml"
         if (ViewBag.Operacao == "I")
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"number\" Name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 958, "\"", 975, 1);
#nullable restore
#line 30 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Materia\Form.cshtml"
WriteAttributeValue("", 966, Model.Id, 966, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control disabled\" readonly />\r\n            <!--<input asp-for=\"id\" class=\"form-control\" />-->\r\n");
#nullable restore
#line 32 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Materia\Form.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"number\" Name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 1162, "\"", 1179, 1);
#nullable restore
#line 35 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Materia\Form.cshtml"
WriteAttributeValue("", 1170, Model.Id, 1170, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control disabled\" readonly />\r\n            <!--<input asp-for=\"Id\" class=\"form-control\" readonly />-->\r\n");
#nullable restore
#line 37 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Materia\Form.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <label for=\"Nome\" class=\"control-label\" style=\"color: #0168B3\">Nome da Mat??ria</label>\r\n        <input type=\"text\" Name=\"Nome\"");
                BeginWriteAttribute("value", " value=\"", 1444, "\"", 1463, 1);
#nullable restore
#line 40 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Materia\Form.cshtml"
WriteAttributeValue("", 1452, Model.Nome, 1452, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n        <!--<input asp-validation-for=\"Nome\" class=\"form-control\" />-->\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9872625eaa857734f628cddffcc0e408af1f6b399899", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 42 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Materia\Form.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Nome);

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
                WriteLiteral("\r\n        <br />\r\n\r\n        <label for=\"Nome_professor\" class=\"control-label\" style=\"color: #0168B3\">Professor</label>\r\n        <input type=\"text\" Name=\"Nome_professor\"");
                BeginWriteAttribute("value", " value=\"", 1798, "\"", 1827, 1);
#nullable restore
#line 46 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Materia\Form.cshtml"
WriteAttributeValue("", 1806, Model.Nome_professor, 1806, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n        <!--<input asp-validation-for=\"Nome\" class=\"form-control\" />-->\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9872625eaa857734f628cddffcc0e408af1f6b3912266", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 48 "C:\Users\Dan\Desktop\projeto-interdisciplinar\projeto-rfid\projeto-rfid\Views\Materia\Form.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Nome_professor);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MateriaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
