using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_estoque.DAO
{
    
    public class CompradoDao
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;

        public CompradoDao()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
    }
}
