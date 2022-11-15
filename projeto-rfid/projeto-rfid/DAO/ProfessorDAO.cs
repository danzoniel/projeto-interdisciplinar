using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using projeto_rfid.Models;

namespace projeto_rfid.DAO
{
    public class ProfessorDAO
    {
        public void Inserir(ProfessorViewModel professor)
        {
            /*string sql =
            "insert into professor (IdProfessor, nomeProfessor)" +
            "values ( @IdProfessor, @nomeProfessor)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(professor));*/
            HelperDAO.ExecutaProc("spIncluiProfessor", CriaParametros(professor));
        }

        private SqlParameter[] CriaParametros(ProfessorViewModel professor)
        {
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("IdProfessor", professor.IdProfessor);
            parametros[1] = new SqlParameter("nomeProfessor", professor.nomeProfessor);
            return parametros;
        }


        private ProfessorViewModel MontaProfessor(DataRow registro)
        {
            ProfessorViewModel a = new ProfessorViewModel();
            a.IdProfessor = Convert.ToInt32(registro["IdProfessor"]);
            a.nomeProfessor = registro["nomeProfessor"].ToString();
            return a;
        }

        public List<ProfessorViewModel> Listagem()
        {
            /*List<ProfessorViewModel> lista = new List<ProfessorViewModel>();
            string sql = "select * from Professor order by nomeProfessor";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaProfessor(registro));
            return lista;*/

            List<ProfessorViewModel> lista = new List<ProfessorViewModel>();

            DataTable tabela = HelperDAO.ExecutaProcSelect("spListagemProfessor", null);
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaProfessor(registro));
            return lista;
        }

        public void Alterar(ProfessorViewModel professor)
        {
            /*string sql =
            "update Professor set nomeProfessor = @nomeProfessor where IdProfessor = @IdProfessor";
            HelperDAO.ExecutaSQL(sql, CriaParametros(professor));*/

            HelperDAO.ExecutaProc("spAlteraProfessor", CriaParametros(professor));

        }

        public ProfessorViewModel Consulta(int id)
        {
            /*string sql = "select * from Professor where IdProfessor = " + id;
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaProfessor(tabela.Rows[0]);*/

            var p = new SqlParameter[]
            {
                new SqlParameter("id", id)
            };
            DataTable tabela = HelperDAO.ExecutaProcSelect("spConsultaProfessor", p);
            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaProfessor(tabela.Rows[0]);

        }

        public void Excluir(int id)
        {

            /*string sql = "delete professor where IdProfessor =" + id;
            HelperDAO.ExecutaSQL(sql, null);*/

            var p = new SqlParameter[]
            {
                new SqlParameter("IdProfessor", id)
            };


            HelperDAO.ExecutaProc("spExcluiProfessor", p);
        }

        public int ProximoId()
        {
            /*string sql = "select isnull(max(id) +1, 1) as 'MAIOR' from professor";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            return Convert.ToInt32(tabela.Rows[0]["MAIOR"]);*/

            var p = new SqlParameter[]
            {
                 new SqlParameter("tabela", "professor")
            };
            DataTable tabela = HelperDAO.ExecutaProcSelect("spProximoId", p);
            return Convert.ToInt32(tabela.Rows[0]["MAIOR"]);
        }
    }
}
