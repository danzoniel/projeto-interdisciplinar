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
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;

namespace projeto_rfid.Controllers
{
    public class AlunoController : PadraoController<AlunoViewModel>
    {
        public AlunoController()
        {
            DAO = new AlunoDAO();
            GeraProximoId = true;
        }
        public IActionResult Configuracoes()
        {
            return View();
        }
        protected override void ValidaDados(AlunoViewModel model, string operacao)
        {
            base.ValidaDados(model, operacao);
            if(string.IsNullOrEmpty(model.Nome_aluno))
                ModelState.AddModelError("Nome_aluno", "Preencha o nome!");
            if (string.IsNullOrEmpty(model.Nome_curso_fk))
                ModelState.AddModelError("Nome_curso_fk", "Preencha o curso!");
            if (string.IsNullOrEmpty(model.Senha))
                ModelState.AddModelError("Senha", "Preencha a Senha!");
        }

    }    
}
