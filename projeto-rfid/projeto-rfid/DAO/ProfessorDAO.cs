using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using projeto_rfid.Models;

namespace projeto_rfid.DAO
{
    public class ProfessorDAO : PadraoDAO<ProfessorViewModel>
    {

        protected override SqlParameter[] CriaParametros(ProfessorViewModel model)
        {
            object imgByte = model.ImagemEmByte;
            if (imgByte == null)
                imgByte = DBNull.Value;

            SqlParameter[] parametros = 
            {
                 new SqlParameter("id", model.id),
                 new SqlParameter("nome", model.Nome),
                 new SqlParameter("imagem", imgByte)
            };
           
            return parametros;
        }


        protected override ProfessorViewModel MontaModel(DataRow registro)
        {
            ProfessorViewModel c = new ProfessorViewModel()
            {
                id = Convert.ToInt32(registro["id"]),
                Nome = registro["nome"].ToString()
            };

            if (registro["imagem"] != DBNull.Value)
                c.ImagemEmByte = registro["imagem"] as byte[];

            return c;
        }

        protected override void SetTabela()
        {
            Tabela = "professor";
        }
    }
}
