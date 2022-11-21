using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using projeto_rfid.Models;

namespace projeto_rfid.DAO
{
    public class PresencaDAO : PadraoDAO<PresencaViewModel>
    {
        protected override SqlParameter[] CriaParametros(PresencaViewModel model)
        {
            SqlParameter[] parametros =
            {
                 new SqlParameter("id", model.Id),
                 new SqlParameter("id_aluno_fk", model.Id_aluno_fk),
                 new SqlParameter("nome_curso_fk", model.Nome_curso_fk),
                 new SqlParameter("nome_materia_fk", model.Nome_materia_fk),
                 new SqlParameter("id_prof_fk", model.Id_prof_fk),
                 new SqlParameter("periodo_curso_fk", model.Periodo_curso_fk),
                 new SqlParameter("semestre_curso_fk", model.Semestre_curso_fk),
                 new SqlParameter("situacaopresenca", model.Situacaopresenca),
                 new SqlParameter("horario_aula", model.Horario_aula),
            };

            return parametros;
        }
        protected override PresencaViewModel MontaModel(DataRow registro)
        {
            PresencaViewModel c = new PresencaViewModel()
            {
                Id = Convert.ToInt32(registro["id"]),
                Id_aluno_fk = Convert.ToInt32(registro["id_aluno_fk"]),
                Nome_curso_fk = registro["nome_curso_fk"].ToString(),
                Nome_materia_fk = registro["nome_materia_fk"].ToString(),
                Id_prof_fk = Convert.ToInt32(registro["id_prof_fk"]),
                Periodo_curso_fk = registro["Periodo_curso_fk"].ToString(),
                Semestre_curso_fk = Convert.ToInt32(registro["semestre_curso_fk"]),
                Situacaopresenca = registro["situacaopresenca"].ToString(),
                Horario_aula = Convert.ToDateTime(registro["horario_aula"]),
            };

            return c;
        }
        protected override void SetTabela()
        {
            Tabela = "presenca";
        }
    }
}