using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using projeto_rfid.Models;

namespace projeto_rfid.DAO
{
    public class HorarioDAO : PadraoDAO<HorarioViewModel>
    {
        protected override SqlParameter[] CriaParametros(HorarioViewModel model)
        {

            SqlParameter[] parametros =
            {
                 new SqlParameter("horario_aula", model.horario_aula)
            };

            return parametros;
        }


        protected override HorarioViewModel MontaModel(DataRow registro)
        {
            HorarioViewModel c = new HorarioViewModel
            {
                horario_aula = Convert.ToDateTime(registro["horario_aula"])
            };

            return c;
        }

        protected override void SetTabela()
        {
            Tabela = "horario_aula";
        }
    }
}
