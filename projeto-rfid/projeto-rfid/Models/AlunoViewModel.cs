using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_rfid.Models
{
    public class AlunoViewModel
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public double Mensalidade { get; set; }
        public int Cidadeid { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
