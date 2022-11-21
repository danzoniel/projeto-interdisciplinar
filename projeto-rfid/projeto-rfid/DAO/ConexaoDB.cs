using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace projeto_rfid.DAO
{
    public static class ConexaoDB
    {
        /// <summary>
        /// Método Estático que retorna um conexao aberta com o BD
        /// </summary>
        /// <returns>Conexão aberta</returns>
        public static  SqlConnection GetConexao()
        {
            string strCon = @"Data Source = DAN\SQLEXPRESS; Database = AlunoBancoDados; integrated security = true";
            //string strCon = "Data Source=LOCALHOST;Initial Catalog=RFID;user id=sa; password=123456"; //BD AQUILES
            SqlConnection conexao = new SqlConnection(strCon);
            conexao.Open();
            return conexao;
   
        }

    }
}
