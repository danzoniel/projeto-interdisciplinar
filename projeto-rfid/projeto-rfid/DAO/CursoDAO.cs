using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using projeto_rfid.Models;

namespace projeto_rfid.DAO
{
    public class CursoDAO : PadraoDAO<CursoViewModel>
    {
        protected override SqlParameter[] CriaParametros(CursoViewModel model)
        {
            SqlParameter[] parametros =
            {
                 new SqlParameter("id", model.Id),
                 new SqlParameter("nome_curso", model.Nome_curso),
                 new SqlParameter("periodo", model.Periodo)
            };

            return parametros;
        }
        protected override CursoViewModel MontaModel(DataRow registro)
        {
            CursoViewModel c = new CursoViewModel()
            {
                Id = Convert.ToInt32(registro["id"]),
                Nome_curso = registro["nome_curso"].ToString(),
                Periodo = registro["periodo"].ToString()
            };

            return c;
        }
        protected override void SetTabela()
        {
            Tabela = "curso";
        }
    }
}