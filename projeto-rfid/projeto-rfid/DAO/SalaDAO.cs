using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using projeto_rfid.Models;

namespace projeto_rfid.DAO
{
    public class SalaDAO : PadraoDAO<SalaViewModel>
    {
        protected override SqlParameter[] CriaParametros(SalaViewModel model)
        {
            SqlParameter[] parametros =
            {
                 new SqlParameter("id", model.Id),
                 new SqlParameter("numero_sala", model.Numero_sala)
            };

            return parametros;
        }
        protected override SalaViewModel MontaModel(DataRow registro)
        {
            SalaViewModel c = new SalaViewModel()
            {
                Id = Convert.ToInt32(registro["id"]),
                Numero_sala = Convert.ToInt32(registro["Numero_sala"]),
            };

            return c;
        }
        protected override void SetTabela()
        {
            Tabela = "sala";
        }
    }
}