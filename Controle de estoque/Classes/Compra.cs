using MapaSala.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_estoque.Classes
{
     public class Compra
    {
        private SqlConnection Conexao = new SqlConnection("Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;");
        public int Id { get; set; }
        public DateTime DataC { get; set; }
        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public float Total { get; set; }

        public Compra()
        {
            DataC = DateTime.Now; // Data atual como padrão
        }
        public void Inserir()
        {
            Conexao.Open();
            string query = "Insert into Usuarios (DataC , Produto, Quantidade, Total) " +
                "               Values (@dataC, @produto, @quantidade, @total) ";
            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlParameter parametro1 = new SqlParameter("@dataC", DataC);
            SqlParameter parametro2 = new SqlParameter("@produto", Produto);
            SqlParameter parametro3 = new SqlParameter("@quantidade", Quantidade);
            SqlParameter parametro4 = new SqlParameter("@total", Total);

            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.Parameters.Add(parametro4);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public DataTable PreencherGrid()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT Id, DataC , Produto, Quantidade, Total FROM Compra order by Id desc";
            Conexao.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, Conexao);
            try
            {
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar os dados para preencher grid: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexao.Close();
            return dataTable;
        }
    }
}
