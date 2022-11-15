using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace projeto_rfid.Models
{
    public class ProfessorViewModel
    {
        [Required]
        public int IdProfessor { get; set; }
        public string nomeProfessor { get; set; }


    }
}
