using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_rfid.DAO;
using projeto_rfid.Models;

namespace projeto_rfid.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            AlunoDAO dao = new AlunoDAO();
            List<AlunoViewModel> lista = dao.Listagem();
            return View(lista);
        }

        public IActionResult Create()
        {
            AlunoViewModel aluno = new AlunoViewModel();
            aluno.DataNascimento = DateTime.Now;
            return View("Form", aluno);
        }

        public IActionResult Salvar(AlunoViewModel aluno)
        {
            AlunoDAO dao = new AlunoDAO();
            dao.Inserir(aluno);
            return RedirectToAction("index");
        }


    }
}
