using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace projeto_rfid.Models
{
    public class AulaViewModel : PadraoViewModel
    {
        public DateTime Horario_aula { get; set; }
        public string Nome_materia_fk { get; set; }
        public int Numero_sala_fk { get; set; }
        public string Nome_professor { get; set; }

    }
}
