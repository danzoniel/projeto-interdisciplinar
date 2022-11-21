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
    public class AulaController : PadraoController<AulaViewModel>
    {
        public AulaController()
        {
            DAO = new AulaDAO();
            GeraProximoId = true;
        }
        public IActionResult Configuracoes()
        {
            return View();
        }
        protected override void ValidaDados(AulaViewModel model, string operacao)
        {
            base.ValidaDados(model, operacao);
            if (string.IsNullOrEmpty(model.Nome_materia_fk))
                ModelState.AddModelError("Nome_materia_fk", "Preencha o nome da matéria!");
            if (string.IsNullOrEmpty(model.Nome_professor))
                ModelState.AddModelError("nome_professor", "Professor Inválido!");
            if (model.Numero_sala_fk == 0)
                ModelState.AddModelError("Numero_sala_fk", "Sala Inválida!");
        }
    }    
}
