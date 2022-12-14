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
    public class MateriaController : PadraoController<MateriaViewModel>
    {
        public MateriaController()
        {
            DAO = new MateriaDAO();
            GeraProximoId = true;
        }
        protected override void ValidaDados(MateriaViewModel model, string operacao)
        {
            base.ValidaDados(model, operacao);
            if (string.IsNullOrEmpty(model.Nome))
                ModelState.AddModelError("Nome", "Preencha o nome!");
            if (string.IsNullOrEmpty(model.Nome_professor))
                ModelState.AddModelError("nome_professor", "Preencha o nome do Professor!");
        }
    }
}