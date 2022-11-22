using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projeto_rfid.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace projeto_rfid.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            try
            {
                if (HelperController.VerificaAlunoLogado(HttpContext.Session))
                    ViewBag.LogadoAluno = true;

                return View();
            }
            catch(Exception err)
            {
                return View("Error", new ErrorViewModel(err.ToString()));
            }
            
        }

        public IActionResult Sobre()
        {
            try
            {
                if (HelperController.VerificaAlunoLogado(HttpContext.Session))
                    ViewBag.LogadoAluno = true;

                return View();
            }
            catch (Exception err)
            {
                return View("Error", new ErrorViewModel(err.ToString()));
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
