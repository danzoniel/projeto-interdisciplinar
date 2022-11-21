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
    public class CartaoController : PadraoController<CartaoViewModel>
    {
        public CartaoController()
        {
            DAO = new CartaoDAO();
            GeraProximoId = true;
        }

        protected override void ValidaDados(CartaoViewModel model, string operacao)
        {
            base.ValidaDados(model, operacao);
            if (string.IsNullOrEmpty(model.Codigo_Cartao))
                ModelState.AddModelError("Codigo_Cartao", "Preencha o Código do cartão!");
            if (string.IsNullOrEmpty(model.Id_aluno_fk))
                ModelState.AddModelError("Id_aluno_fk", "Preencha o id do Aluno!");
        }
    }
}
