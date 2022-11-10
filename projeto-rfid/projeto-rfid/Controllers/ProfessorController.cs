using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_rfid.DAO;
using projeto_rfid.Models;

namespace projeto_rfid.Controllers
{
    public class ProfessorController : Controller
    {
        public IActionResult lista()
        {
            ProfessorDAO dao = new ProfessorDAO();
            List<ProfessorViewModel> lista = dao.Listagem();
            return View(lista);
        
        }
    }
}
