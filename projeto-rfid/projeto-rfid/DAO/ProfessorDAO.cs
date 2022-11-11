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
            string sql =
            "insert into professor (IdProfessor, nomeProfessor)" +
            "values ( @IdProfessor, @nomeProfessor)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(professor));
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
            List<ProfessorViewModel> lista = new List<ProfessorViewModel>();
            string sql = "select * from Professor order by nomeProfessor";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaProfessor(registro));
            return lista;
        }
    }
}
