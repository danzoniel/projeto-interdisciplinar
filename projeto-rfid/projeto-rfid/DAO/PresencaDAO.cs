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
                 new SqlParameter("nome_professor", model.Nome_professor),
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
                Nome_professor = registro["nome_professor"].ToString(),
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
        public List<PresencaViewModel> ConsultaAvancadaPresenca(string nome_curso_fk, int semestre_curso_fk, DateTime dataInicial, DateTime dataFinal)
        {
            SqlParameter[] p = {
                new SqlParameter("nome_curso_fk", nome_curso_fk),
                new SqlParameter("semestre_curso_fk", semestre_curso_fk),
                new SqlParameter("dataInicial", dataInicial),
                new SqlParameter("dataFinal", dataFinal)
            };

            var tabela = HelperDAO.ExecutaProcSelect("spConsultaAvancadaPresenca", p);
            var lista = new List<PresencaViewModel>();
            foreach (DataRow dr in tabela.Rows)
                lista.Add(MontaModel(dr));

            return lista;
        }
    }
}