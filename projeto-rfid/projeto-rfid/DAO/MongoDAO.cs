using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_rfid.Models;
using System.Data.SqlClient;

namespace projeto_rfid.DAO
{
    public class MongoDAO
    {

        private SqlParameter[] CriaParametrosAbertura(MongoViewModel mongo)
        {
            var p = new SqlParameter[2];
            p[0] = new SqlParameter("id_aluno_fk", mongo.attrValue);
            p[1] = new SqlParameter("situacaopresenca", "1");

            return p;
        }

        public void Inserir(MongoViewModel mongo)
        {
            string sql =
                "insert into presenca " +
                "         (id_aluno_fk, situacaopresenca)" +
                    "values (@id_aluno_fk, @situacaopresenca)";

            HelperDAO.ExecutaSQL(sql, CriaParametrosAbertura(mongo));
        }

        
    }
}
