using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace projeto_rfid.DAO
{
    public static class ConexaoDB
    {
        /// <summary>
        /// Método Estático que retorna um conexao aberta com o BD
        /// </summary>
        /// <returns>Conexão aberta</returns>
        public static SqlConnection GetConexao()
        {
            string strCon = @"Data Source = DAN\SQLEXPRESS; Database = AULADB; integrated security = true";
            SqlConnection conexao = new SqlConnection(strCon);
            conexao.Open();
            return conexao;
   
        }

    }
}
