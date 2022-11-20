using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_rfid.Models
{
    public class AlunoViewModel : PadraoViewModel
    {        
        public string Nome_aluno { get; set; }
        public string Nome_curso_fk { get; set; }
        public string Periodo_curso_fk { get; set; }
        public int Semestre_curso_fk { get; set; }
        public string Senha { get; set; }
    }
}
