using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_rfid.DAO;
using projeto_rfid.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;

namespace projeto_rfid.Controllers
{
    public class AlunoController : PadraoController<AlunoViewModel>
    {
        public AlunoController()
        {
            DAO = new AlunoDAO();
            GeraProximoId = true;
        }
        public IActionResult Configuracoes()
        {
            return View();
        }
        protected override void ValidaDados(AlunoViewModel model, string operacao)
        {
            base.ValidaDados(model, operacao);
            if(string.IsNullOrEmpty(model.Nome_aluno))
                ModelState.AddModelError("Nome_aluno", "Preencha o nome!");
            if (string.IsNullOrEmpty(model.Nome_curso_fk))
                ModelState.AddModelError("Nome_curso_fk", "Preencha o curso!");
            if (string.IsNullOrEmpty(model.Senha))
                ModelState.AddModelError("Senha", "Preencha a Senha!");
        }
        private void PreparaComboCategorias()
        {
            List<SelectListItem> lista = new List<SelectListItem>();
            AlunoDAO dao = new AlunoDAO();
            foreach (var c in dao.Listagem())
                lista.Add(
                    new SelectListItem(c.Nome_curso_fk, c.Periodo_curso_fk));

            ViewBag.Categorias = lista;
        }
        public IActionResult ExibeConsultaAvancada()
        {
            try
            {
                PreparaComboCategorias();
                ViewBag.Categorias.Insert(0, new SelectListItem("TODAS", "0"));
                return View("ConsultaAvancada");
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.Message));
            }
        }
        public IActionResult ObtemDadosConsultaAvancada(string nome_curso_fk, string periodo_curso_fk)
        {
            try
            {
                AlunoDAO dao = new AlunoDAO();
                if (string.IsNullOrEmpty(nome_curso_fk))
                    nome_curso_fk = "";
                if (string.IsNullOrEmpty(periodo_curso_fk))
                    periodo_curso_fk = "";

                var lista = dao.ConsultaAvancadaAluno(nome_curso_fk, periodo_curso_fk);
                return PartialView("pvGridAlunos", lista);
            }
            catch (Exception erro)
            {
                return Json(new { erro = true, msg = erro.Message });
            }
        }
        
    }    
}
