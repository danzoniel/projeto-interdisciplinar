using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using projeto_rfid.Models;

namespace projeto_rfid.DAO
{
    public class MateriaDAO : PadraoDAO<MateriaViewModel>
    {
        protected override SqlParameter[] CriaParametros(MateriaViewModel model)
        {
            SqlParameter[] parametros =
            {
                 new SqlParameter("id", model.Id),
                 new SqlParameter("nome", model.Nome),
                 new SqlParameter("nome_professor", model.Nome_professor)
            };

            return parametros;
        }
        protected override MateriaViewModel MontaModel(DataRow registro)
        {
            MateriaViewModel c = new MateriaViewModel()
            {
                Id = Convert.ToInt32(registro["id"]),
                Nome = registro["nome"].ToString(),
                Nome_professor = registro["nome_professor"].ToString(),

            };

            return c;
        }
        protected override void SetTabela()
        {
            Tabela = "materia";
        }
    }
}