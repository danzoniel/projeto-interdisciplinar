using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_rfid.Models
{
    public class HorarioViewModel : PadraoViewModel
    {
        public DateTime horario_aula { get; set; }
    }
}
