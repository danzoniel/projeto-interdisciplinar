using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_rfid.Models
{
    public class CartaoViewModel : PadraoViewModel
    {
        public string Codigo_Cartao { get; set; }
        public string Id_aluno_fk { get; set; }
    }
}
