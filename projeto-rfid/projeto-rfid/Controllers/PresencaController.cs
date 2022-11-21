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
    }
}