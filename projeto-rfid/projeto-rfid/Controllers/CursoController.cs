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
    public class CursoController : PadraoController<CursoViewModel>
    {
        public CursoController()
        {
            DAO = new CursoDAO();
            GeraProximoId = true;
        }
        public IActionResult Configuracoes()
        {
            return View();
        }
        protected override void ValidaDados(CursoViewModel model, string operacao)
        {
            base.ValidaDados(model, operacao);
            if(string.IsNullOrEmpty(model.Nome_curso))
                ModelState.AddModelError("Nome_curso", "Preencha o nome do curso!");
            if (string.IsNullOrEmpty(model.Periodo))
                ModelState.AddModelError("Periodo", "Preencha o Periodo!");
            if (model.Semestre == 0)
                ModelState.AddModelError("Semestre", "O semestre está inválido!");
        }
    }    
}
