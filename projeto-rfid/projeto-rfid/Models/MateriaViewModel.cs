using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_rfid.Models
{
    public class MateriaViewModel : PadraoViewModel
    {
        public string Nome { get; set; }
        public string Nome_professor { get; set; }

    }
}
