using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using projeto_rfid.Models;

namespace projeto_rfid.DAO
{
    public class AulaDAO : PadraoDAO<AulaViewModel>
    {
        protected override SqlParameter[] CriaParametros(AulaViewModel model)
        {
            SqlParameter[] parametros =
            {
                 new SqlParameter("id", model.Id),
                 new SqlParameter("horario_aula", model.Horario_aula),
                 new SqlParameter("nome_materia_fk", model.Nome_materia_fk),
                 new SqlParameter("id_prof_fk", model.Id_prof_fk),
                 new SqlParameter("numero_sala_fk", model.Numero_sala_fk),
            };

            return parametros;
        }
        protected override AulaViewModel MontaModel(DataRow registro)
        {
            AulaViewModel c = new AulaViewModel()
            {
                Id = Convert.ToInt32(registro["id"]),
                Horario_aula = Convert.ToDateTime(registro["horario_aula"]),
                Nome_materia_fk = registro["Nome_materia_fk"].ToString(),
                Id_prof_fk = Convert.ToInt32(registro["id_prof_fk"]),
                Numero_sala_fk = Convert.ToInt32(registro["numero_sala_fk"]),
            };

            return c;
        }
        protected override void SetTabela()
        {
            Tabela = "aula";
        }
    }
}