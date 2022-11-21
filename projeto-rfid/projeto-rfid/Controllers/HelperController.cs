using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_rfid.Controllers
{
    public class HelperController : Controller
    {
        public static Boolean VerificaAlunoLogado(ISession session)
        {
            string logado = session.GetString("LogadoAluno");
            if (logado == null)
                return false;
            else
                return true;
        }
    }
}
