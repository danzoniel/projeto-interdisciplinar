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
    public class SalaController : PadraoController<SalaViewModel>
    {
        public SalaController()
        {
            DAO = new SalaDAO();
            GeraProximoId = true;
        }
        public IActionResult Configuracoes()
        {
            return View();
        }
        protected override void ValidaDados(SalaViewModel model, string operacao)
        {
            base.ValidaDados(model, operacao);
            if(model.Numero_sala == 0)
                ModelState.AddModelError("Numero_sala", "A sala não pode ser nula!");
        }
    }    
}
