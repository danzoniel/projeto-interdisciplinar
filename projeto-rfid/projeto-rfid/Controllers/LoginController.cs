using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
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
        protected bool ExigeAutenticacao { get; set; } = true;
        public override void OnActionExecuting(ActionExecutingContext context)
        {

                if (HelperController.VerificaAlunoLogado(HttpContext.Session))
                    ViewBag.LogadoAluno = true;
                base.OnActionExecuting(context);
            
        }

        public IActionResult Index()
        {
            return View();

        }

        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            ViewBag.LogadoAluno = true;
            return View();
        }

        public IActionResult FazLogin(AlunoViewModel aluno, string returnUrl)
        {            
            if (aluno.Id == 0822000059 && aluno.Senha == "Admin123")
            {
                HttpContext.Session.SetString("Logado", "true");
                ViewBag.LogadoAluno = true;
                return RedirectToAction("Configuracoes", "Professor");
            }

            var achou = AlunoDAO.ValidarLogin(aluno.Id, aluno.Senha);

            if (achou == true)
            {
                ViewBag.LogadoAluno = true;
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
