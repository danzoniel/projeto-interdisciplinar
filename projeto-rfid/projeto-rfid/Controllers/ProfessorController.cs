using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_rfid.DAO;
using projeto_rfid.Models;
using System.ComponentModel.DataAnnotations;

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
                ProfessorDAO dao = new ProfessorDAO();

                //professor.IdProfessor = dao.ProximoId(); -> Função com erro

                return View("Form", professor);
            }
            catch
            {
                return View("Error");
            }

        }

        public IActionResult Salvar(ProfessorViewModel professor, string Operacao)
        {
            try
            {
                ValidaDados(professor, Operacao);
                if (ModelState.IsValid == false)
                {
                    ViewBag.Operacao = Operacao;
                    return View("Form", professor);
                }
                else
                {
                    ProfessorDAO dao = new ProfessorDAO();
                    if (Operacao == "I")
                        dao.Inserir(professor);
                    else
                        dao.Alterar(professor);

                    return RedirectToAction("lista");
                }
            }
            catch (Exception erro)
            {
                return View("Error");

            }

        }
        /*
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

        }*/

        public IActionResult Alterar(int id)
        {
            var DAO = new ProfessorDAO();
            var professor = DAO.Consulta(id);
            return View("Form", professor);
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

        private void ValidaDados(ProfessorViewModel professor, string operacao)
        {
            ModelState.Clear(); // limpa os erros criados automaticamente pelo Asp.net (que podem estar com msg em inglês)
            ProfessorDAO dao = new ProfessorDAO();
            if (operacao == "I" && dao.Consulta(professor.IdProfessor) != null)
                ModelState.AddModelError("Id", "Código já está em uso.");
            if (operacao == "A" && dao.Consulta(professor.IdProfessor) == null)
                ModelState.AddModelError("Id", "Aluno não existe.");
            if (professor.IdProfessor <= 0)
                ModelState.AddModelError("Id", "Id inválido!");
            if (string.IsNullOrEmpty(professor.nomeProfessor))
                ModelState.AddModelError("Nome", "Preencha o nome.");
        }
    }
}
