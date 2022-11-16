using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using projeto_rfid.Models;

namespace projeto_rfid.DAO
{
    public class AlunoDAO
    {
        public void Inserir(AlunoViewModel aluno)
        {
            string sql =
            "insert into alunos(id, Nome, mensalidade, cidadeid, dataNascimento)" +
            "values ( @id, @Nome, @mensalidade, @cidadeid, @dataNascimento)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(aluno));
        }
        public void Alterar(AlunoViewModel aluno)
        {
            string sql =
            "update alunos set Nome = @Nome, " +
            "mensalidade = @mensalidade, " +
            "cidadeid = @cidadeid," +
            "dataNascimento = @dataNascimento where id = @id";
            HelperDAO.ExecutaSQL(sql, CriaParametros(aluno));
        }
        private SqlParameter[] CriaParametros(AlunoViewModel aluno)
        {
            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = new SqlParameter("id", aluno.id);
            parametros[1] = new SqlParameter("Nome", aluno.Nome);
            parametros[2] = new SqlParameter("mensalidade", aluno.Mensalidade);
            parametros[3] = new SqlParameter("cidadeid", aluno.Cidadeid);
            parametros[4] = new SqlParameter("dataNascimento", aluno.DataNascimento);
            return parametros;
        }
        public void Excluir(int id)
        {
            string sql = "delete alunos where id =" + id;
            HelperDAO.ExecutaSQL(sql, null);
        }

        private AlunoViewModel MontaAluno(DataRow registro)
        {
            AlunoViewModel a = new AlunoViewModel();
            a.id = Convert.ToInt32(registro["id"]);
            a.Nome = registro["Nome"].ToString();
            a.Cidadeid = Convert.ToInt32(registro["cidadeid"]);
            a.DataNascimento = Convert.ToDateTime(registro["dataNascimento"]);
            a.Mensalidade = Convert.ToDouble(registro["mensalidade"]);
            return a;
        }

        public AlunoViewModel Consulta(int id)
        {
            string sql = "select * from alunos where id = " + id;
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaAluno(tabela.Rows[0]);
        }
        public List<AlunoViewModel> Listagem()
        {
            List<AlunoViewModel> lista = new List<AlunoViewModel>();
            string sql = "select * from alunos order by Nome";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaAluno(registro));
            return lista;
        }

    }
}
