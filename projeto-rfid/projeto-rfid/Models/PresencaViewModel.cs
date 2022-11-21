using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_rfid.Models
{
    public class PresencaViewModel : PadraoViewModel
    {        
        public int Id_aluno_fk { get; set; }
        public string Nome_curso_fk { get; set; }
        public string Periodo_curso_fk { get; set; }
        public int Semestre_curso_fk { get; set; }
        public string Nome_materia_fk { get; set; }
        public string Nome_professor { get; set; }
        public string Situacaopresenca { get; set; }
        public DateTime Horario_aula { get; set; }
    }
}
