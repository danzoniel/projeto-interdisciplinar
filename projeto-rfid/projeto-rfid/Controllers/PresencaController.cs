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
using System.Data.SqlTypes;

namespace projeto_rfid.Controllers
{
    public class PresencaController : PadraoController<PresencaViewModel>
    {
        public PresencaController()
        {
            DAO = new PresencaDAO();
            GeraProximoId = true;
        }
        public IActionResult Configuracoes()
        {
            return View();
        }
        protected override void ValidaDados(PresencaViewModel model, string operacao)
        {
            base.ValidaDados(model, operacao);
            if (string.IsNullOrEmpty(model.Nome_curso_fk))
                ModelState.AddModelError("Nome_curso_fk", "Preencha o Curso!");
            if (string.IsNullOrEmpty(model.Nome_materia_fk))
                ModelState.AddModelError("Nome_materia_fk", "Preencha a matéria!");
            if (string.IsNullOrEmpty(model.Periodo_curso_fk))
                ModelState.AddModelError("Periodo_curso_fk", "Preencha o período!");
            if (model.Id_aluno_fk == 0)
                ModelState.AddModelError("Id_aluno_fk", "Preencha o RA do aluno!");
            if (string.IsNullOrEmpty(model.Nome_professor))
                ModelState.AddModelError("nome_professor", "Preencha o Nome do professor!");
            if (model.Semestre_curso_fk == 0)
                ModelState.AddModelError("Semestre_curso_fk", "Preencha o semestre!");
            if (model.Horario_aula > DateTime.Now)
                ModelState.AddModelError("Horario_aula", "Data Inválida");
        }
        private void PreparaComboCategorias()
        {
            List<SelectListItem> lista = new List<SelectListItem>();
            PresencaDAO dao = new PresencaDAO();
            foreach (var c in dao.Listagem())
                lista.Add(
                    new SelectListItem(c.Nome_curso_fk, c.Semestre_curso_fk.ToString()));

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
        public IActionResult ObtemDadosConsultaAvancada(string nome_curso_fk, int semestre_curso_fk, DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                PresencaDAO dao = new PresencaDAO();
                if (string.IsNullOrEmpty(nome_curso_fk))
                    nome_curso_fk = "";
                if (dataInicial.Date == Convert.ToDateTime("01/01/0001"))
                    dataInicial = SqlDateTime.MinValue.Value;
                if (dataFinal.Date == Convert.ToDateTime("01/01/0001"))
                    dataFinal = SqlDateTime.MaxValue.Value;


                var lista = dao.ConsultaAvancadaPresenca(nome_curso_fk, semestre_curso_fk, dataInicial, dataFinal);
                return PartialView("pvGridPresenca", lista);
            }
            catch (Exception erro)
            {
                return Json(new { erro = true, msg = erro.Message });
            }
        }
    }
}