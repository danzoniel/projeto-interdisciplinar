using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using projeto_rfid.DAO;
using projeto_rfid.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_rfid.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        public IActionResult FazLogin(AlunoViewModel aluno, string returnUrl)
        {            
            if (aluno.Id == 0822000059 && aluno.Senha == "Admin123")
            {
                HttpContext.Session.SetString("Logado", "true");
                return RedirectToAction("Configuracoes", "Professor");
            }

            var achou = AlunoDAO.ValidarLogin(aluno.Id, aluno.Senha);

            if (achou == true)
            {
                HttpContext.Session.SetString("Logado", "true");
                return RedirectToAction("index", "Aluno");
            }
            else
            {
                ViewBag.Erro = "Usuário ou senha inválidos!";
                return View("Index");
            }

            /*
            if (usuario == "admin" && senha == "1234")
            {
                HttpContext.Session.SetString("Logado", "true");
                return RedirectToAction("index", "Aluno");
            }
            else
            {
                ViewBag.Erro = "Usuário ou senha inválidos!";
                return View("Index");
            }
            */
        }
        
        public IActionResult LogOff()
        { 
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Index");
            }
        }
    }
}
