using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_rfid.Models
{
    public class CursoViewModel : PadraoViewModel
    {
        public string Nome_curso { get; set; }
        public string Periodo { get; set; }
    }
}
