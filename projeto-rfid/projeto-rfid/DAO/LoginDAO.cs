using System;
using System.Data;
using System.Data.SqlClient;
using projeto_rfid.Models;

namespace projeto_rfid.DAO
{
    public class LoginDAO : PadraoDAO<LoginViewModel>
    {
        protected override SqlParameter[] CriaParametros(LoginViewModel model)
        {
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("id", model.Id);
            parametros[1] = new SqlParameter("senha", model.SenhaHash);
            return parametros;
        }

        protected override LoginViewModel MontaModel(DataRow registro)
        {
            LoginViewModel a = new LoginViewModel()
            {
                Id = Convert.ToInt32(registro["id"]),
                SenhaHash = registro["senha"].ToString()
            };
            return a;
        }

        protected override void SetTabela()
        {
            Tabela = "Login";
        }
    }
}
