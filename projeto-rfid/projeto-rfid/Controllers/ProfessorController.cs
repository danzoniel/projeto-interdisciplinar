using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_rfid.DAO;
using projeto_rfid.Models;
using System.ComponentModel.DataAnnotations;

namespace projeto_rfid.Controllers
{
    public class ProfessorController : PadraoController<ProfessorViewModel>
    {
        public ProfessorController()
        {
            DAO = new ProfessorDAO();
            GeraProximoId = true;
        }
        protected override void ValidaDados(ProfessorViewModel model, string operacao)
        {
            base.ValidaDados(model, operacao);
            if (model.Nome == "")
                ModelState.AddModelError("Nome", "Obrigatório");
        }

    }
}
