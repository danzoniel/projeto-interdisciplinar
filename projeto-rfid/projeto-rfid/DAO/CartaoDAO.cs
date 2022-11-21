using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using projeto_rfid.Models;


namespace projeto_rfid.DAO
{
    public class CartaoDAO : PadraoDAO<CartaoViewModel>
    {
        protected override SqlParameter[] CriaParametros(CartaoViewModel model)
        {
            SqlParameter[] parametros =
            {
                 new SqlParameter("id", model.Id),
                 new SqlParameter("codigo_cartao", model.Codigo_Cartao),
                 new SqlParameter("id_aluno_fk", model.Id_aluno_fk)
            };

            return parametros;
        }
        protected override CartaoViewModel MontaModel(DataRow registro)
        {
            CartaoViewModel c = new CartaoViewModel()
            {
                Id = Convert.ToInt32(registro["id"]),
                Codigo_Cartao = registro["codigo_cartao"].ToString(),
                Id_aluno_fk = registro["id_aluno_fk"].ToString(),

            };

            return c;
        }
        protected override void SetTabela()
        {
            Tabela = "RegistroCartao";
        }
    }
}
