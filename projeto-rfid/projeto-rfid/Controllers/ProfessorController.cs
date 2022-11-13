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

        public IActionResult Create()
        {
            ViewBag.Operacao = "I";
            try
            {
                ProfessorViewModel professor = new ProfessorViewModel();
                return View("Cadastro", professor);

                ProfessorDAO dao = new ProfessorDAO();
                professor.IdProfessor = dao.ProximoId();

                return View("Cadastro", professor);
            }
            catch
            {
                return View("Error");
            }

        }

        public IActionResult Salvar(ProfessorViewModel professor)
        {
                ProfessorDAO dao = new ProfessorDAO();
                dao.Inserir(professor);
                return RedirectToAction("lista");
        }

        public IActionResult SalvarUpdate(ProfessorViewModel professor)
        {
            try
            {
                ProfessorDAO dao = new ProfessorDAO();

                if (dao.Consulta(professor.IdProfessor) == null)
                    dao.Inserir(professor);
                else
                    dao.Alterar(professor);

                return RedirectToAction("lista");
            }

            catch (Exception erro)
            {
                return View("erro");
            }

        }

        public IActionResult Alterar(int id)
        {
            var DAO = new ProfessorDAO();
            var professor = DAO.Consulta(id);
            return View("Alterar", professor);
        }

        public IActionResult Update(ProfessorViewModel professor)
        {
            ViewBag.Operacao = "A";

            ProfessorDAO dao = new ProfessorDAO();
            dao.Alterar(professor);
            return RedirectToAction("lista");

        }
        public IActionResult Delete(int id)
        {
            try
            {
                ProfessorDAO dao = new ProfessorDAO();
                dao.Excluir(id);
                return RedirectToAction("lista");
            }
            catch (Exception erro)
            {
                return View("error");
            }

        }
    }
}
