using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using projeto_rfid.DAO;
using projeto_rfid.Models;
using projeto_rfid.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        public override IActionResult Save(AlunoViewModel model, string Operacao)
        {
            try
            {
                ValidaDados(model, Operacao);
                if (ModelState.IsValid == false)
                {
                    ViewBag.Operacao = Operacao;
                    PreencheDadosParaView(Operacao, model);
                    return View(NomeViewForm, model);
                }
                else
                {
                    if (Operacao == "I")
                    {
                        AlunoDAO novoAlunoDAO = new AlunoDAO();
                        DAO.Insert(model);
                        LoginViewModel modelLogin = new LoginViewModel()
                        {
                            Id = model.Id,
                            SenhaHash = PasswordHasher.Encrypt("0001")
                        };
                        LoginDAO login = new LoginDAO();
                        login.Insert(modelLogin);
                        TempData["AlertMessage"] = "Dado salvo com sucesso...! ";
                       
                        return RedirectToAction("Create");
                    }
                    else
                    {
                        DAO.Update(model);
                        return RedirectToAction("Home", "Index");
                    }

                }
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

    }    
}
