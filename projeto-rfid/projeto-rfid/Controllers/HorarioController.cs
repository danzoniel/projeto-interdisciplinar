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
    public class HorarioController : PadraoController<HorarioViewModel>
    {
        public HorarioController()
        {
            DAO = new HorarioDAO();
            GeraProximoId = true;
        }

        public IActionResult Horarios()
        {
            return View();
        }
    }
}
