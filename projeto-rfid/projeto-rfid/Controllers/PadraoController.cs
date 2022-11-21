using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_rfid.DAO;
using projeto_rfid.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;


namespace projeto_rfid.Controllers
{
    public class PadraoController<T> : Controller where T : PadraoViewModel
    {
        protected PadraoDAO<T> DAO { get; set; }
        protected bool GeraProximoId { get; set; }
        protected string NomeViewIndex { get; set; } = "index";
        protected string NomeViewForm { get; set; } = "form";
        protected bool ExigeAutenticacao { get; set; } = true;


        public IActionResult Index()
        {
            ViewBag.Tudo = DAO.Listagem();
            try
            {
                var lista = DAO.Listagem();
                return View(NomeViewIndex, lista);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        public virtual IActionResult Create()
        {
            try
            {
                ViewBag.Operacao = "I";
                T model = Activator.CreateInstance(typeof(T)) as T;
                PreencheDadosParaView("I", model);
                return View(NomeViewForm, model);
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        protected virtual void PreencheDadosParaView(string Operacao, T model)
        {
            if (GeraProximoId && Operacao == "I")
                model.Id = DAO.ProximoId();
        }

        public virtual IActionResult Save(T model, string Operacao)
        {
            try
            {
                ValidaDados(model, Operacao);
                if (ModelState.IsValid == false)
                {
                    ViewBag.Operacao = Operacao;
                    PreencheDadosParaView(Operacao, model);
                    return View(NomeViewForm, model);
                }
                else
                {
                    if (Operacao == "I")
                        DAO.Insert(model);
                    else
                        DAO.Update(model);
                    return RedirectToAction(NomeViewIndex);
                }
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        protected virtual void ValidaDados(T model, string operacao)
        {
            ModelState.Clear();
            if (operacao == "I" && DAO.Consulta(model.Id) != null)
                ModelState.AddModelError("id", "Código já está em uso!");
            if (operacao == "A" && DAO.Consulta(model.Id) == null)
                ModelState.AddModelError("id", "Este registro não existe!");
            if (model.Id <= 0)
                ModelState.AddModelError("id", "id inválido!");
        }

        public IActionResult Edit(int id)
        {
            try
            {
                ViewBag.Operacao = "A";
                var model = DAO.Consulta(id);
                if (model == null)
                    return RedirectToAction(NomeViewIndex);
                else
                {
                    PreencheDadosParaView("A", model);
                    return View(NomeViewForm, model);
                }
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

        public IActionResult Delete(int id)
        {
            try
            {
                DAO.Delete(id);
                return RedirectToAction(NomeViewIndex);
            }
            catch (Exception)
            {
                return View("Error");
            }

        }
    }
}
