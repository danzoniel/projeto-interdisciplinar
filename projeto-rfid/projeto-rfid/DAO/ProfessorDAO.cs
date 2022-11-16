using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using projeto_rfid.Models;

namespace projeto_rfid.DAO
{
    public class ProfessorDAO : PadraoDAO<ProfessorViewModel>
    {

        protected override SqlParameter[] CriaParametros(ProfessorViewModel model)
        {
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("id", model.Id);
            parametros[1] = new SqlParameter("nome", model.Nome);

            return parametros;
        }


        protected override ProfessorViewModel MontaModel(DataRow registro)
        {
            ProfessorViewModel c = new ProfessorViewModel()
            {
                Id = Convert.ToInt32(registro["id"]),
                Nome = registro["nome"].ToString()
            };
            return c;
        }

        protected override void SetTabela()
        {
            Tabela = "professor";
        }
    }
}
