
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using projeto_rfid.DAO;
using projeto_rfid.Models;
using projeto_rfid.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;


namespace projeto_rfid.Controllers
{
    public class LoginController : PadraoController<LoginViewModel>
    {
        public LoginController()
        {
            DAO = new LoginDAO();
            GeraProximoId = false;
            ExigeAutenticacao = false;
        }

        public IActionResult FazLogin(LoginViewModel model)
        {
            try
            {

                if (model.SenhaHash == "Admin123" && model.Id == 0822000059)
                {
                    HttpContext.Session.SetString("LogadoAluno", "true");
                    return RedirectToAction("index", "Home");
                }

                if (DAO.Consulta(Convert.ToInt32(model.Id)) == null)
                {
                    TempData["LoginMessage"] = "Usuário ou senha inválidos!";
                    return RedirectToAction("index", "Home");
                }

                if (Convert.ToInt32(model.Id) == DAO.Consulta(Convert.ToInt32(model.Id)).Id &&
                     model.SenhaHash == PasswordHasher.Decrypt(DAO.Consulta(Convert.ToInt32(model.Id)).SenhaHash))
                {
                    if (model.SenhaHash == "0001")
                    {
                        TempData["PasswordMessage"] = "Crie uma nova senha!";
                        return RedirectToAction("index", "Home");
                    }

                    if (model.Id.ToString().Substring(0, 1) == "2")
                    {
                        HttpContext.Session.SetString("LogadoProfessor", "true");
                    }
                    else
                    {
                        HttpContext.Session.SetString("LogadoAluno", "true");
                    }

                    return RedirectToAction("index", "Home");
                }
                else
                {
                    TempData["LoginMessage"] = "Usuário ou senha inválidos!";
                    return RedirectToAction("index", "Home");
                }
            }
            catch (Exception err)
            {
                return View("Error", new ErrorViewModel(err.ToString()));
            }
        }

        /*
        public override void OnActionExecuting(ActionExecutingContext context)
        {

                if (HelperController.VerificaAlunoLogado(HttpContext.Session))
                    ViewBag.LogadoAluno = true;
                base.OnActionExecuting(context);
            
        }
        */

        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            ViewBag.LogadoAluno = true;
            return View();
        }

       

        /*public IActionResult FazLogin(AlunoViewModel aluno, string returnUrl)
        {

            ViewBag.LogadoAluno = true;

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
            
        }*/

        public IActionResult LogOff()
        {
            try
            {
                HttpContext.Session.Clear();
                return RedirectToAction("index", "Home");
            }
            catch (Exception err)
            {
                return View("Error", new ErrorViewModel(err.ToString()));
            }
        }
    }
}

