using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_rfid.Models
{
    public class LoginViewModel : PadraoViewModel
    {
        public string SenhaHash { get; set; }

    }
}
