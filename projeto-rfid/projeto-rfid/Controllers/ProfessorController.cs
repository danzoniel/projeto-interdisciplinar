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
    public class ProfessorController : PadraoController<ProfessorViewModel>
    {
        public ProfessorController()
        {
            DAO = new ProfessorDAO();
            GeraProximoId = true;
        }

        /// <summary>
        /// Converte a imagem recebida no form em um vetor de bytes
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public byte[] ConvertImageToByte(IFormFile file)
        {
            if (file != null)
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    return ms.ToArray();
                }
            else
                return null;
        }

        public IActionResult Configuracoes()
        {
            return View();
        }

        protected override void ValidaDados(ProfessorViewModel model, string operacao)
        {
            base.ValidaDados(model, operacao);
            if (model.Nome == "")
                ModelState.AddModelError("Nome", "Obrigatório");

            //Imagem será obrigatio apenas na inclusão. 
            //Na alteração iremos considerar a que já estava salva.
            if (model.Imagem == null && operacao == "I")
                ModelState.AddModelError("Imagem", "Escolha uma imagem.");
            if (model.Imagem != null && model.Imagem.Length / 1024 / 1024 >= 2)
                ModelState.AddModelError("Imagem", "Imagem limitada a 2 mb.");
            if (ModelState.IsValid)
            {
                //na alteração, se não foi informada a imagem, iremos manter a que já estava salva.
                if (operacao == "A" && model.Imagem == null)
                {
                    ProfessorViewModel cid = DAO.Consulta(model.id);
                    model.ImagemEmByte = cid.ImagemEmByte;
                }
                else
                {
                    model.ImagemEmByte = ConvertImageToByte(model.Imagem);
                }
            }
        }

       /* public IActionResult ExibeConsulta()
        {
            try
            {
                PreparaComboCategorias();
                ViewBag.Categorias.Insert(0, new SelectListItem("TODAS", "0"));
                return View("ConsultaAvancada");
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.Message));
            }
        }*/


    }
}
