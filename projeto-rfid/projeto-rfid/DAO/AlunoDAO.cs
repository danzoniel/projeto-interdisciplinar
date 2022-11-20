using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using projeto_rfid.Models;

namespace projeto_rfid.DAO
{
    public class AlunoDAO : PadraoDAO<AlunoViewModel>
    {
        protected override SqlParameter[] CriaParametros(AlunoViewModel model)
        {          
            SqlParameter[] parametros =
            {
                 new SqlParameter("id", model.Id),
                 new SqlParameter("nome_aluno", model.Nome_aluno),
                 new SqlParameter("nome_curso_fk", model.Nome_curso_fk),
                 new SqlParameter("periodo_curso_fk", model.Periodo_curso_fk),
                 new SqlParameter("semestre_curso_fk", model.Semestre_curso_fk),
                 new SqlParameter("senha", model.Senha)
            };

            return parametros;
        }
        protected override AlunoViewModel MontaModel(DataRow registro)
        {
            AlunoViewModel c = new AlunoViewModel()
            {
                Id = Convert.ToInt32(registro["id"]),
                Nome_aluno = registro["nome_aluno"].ToString(),
                Nome_curso_fk = registro["nome_curso_fk"].ToString(),
                Periodo_curso_fk = registro["Periodo_curso_fk"].ToString(),
                Semestre_curso_fk = Convert.ToInt32(registro["semestre_curso_fk"]),
                Senha = registro["senha"].ToString()
            };
            return c;
        }
        protected override void SetTabela()
        {
            Tabela = "aluno";
        }         
       
        public static bool ValidarLogin(int id, string senha)
        {
            var ret = false;

            using (var conexao = new SqlConnection())
            {
                conexao.ConnectionString = "Data Source=LOCALHOST;Initial Catalog=RFID;user id=sa; password=123456"; conexao.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;
                    comando.CommandText = string.Format(
                        "select count(*) from aluno where id ='{0}' and senha='{1}'", id, senha);
                    ret = ((int)comando.ExecuteScalar() > 0);
                }
            }

            return ret;
        }        
    }
}
