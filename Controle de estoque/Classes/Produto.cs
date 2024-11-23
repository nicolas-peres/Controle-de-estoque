using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_estoque.Classes
{
    class Produto
    {
        private SqlConnection Conexao = new SqlConnection("Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;");
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }

        public object[] Linha()
        {
            return new object[] { Id, Nome, Descricao, Preco, Quantidade };
        }
        public void Excluir()
        {
            string query = "Delete from Usuarios WHERE  Id = @id";
            Conexao.Open();
            SqlCommand comando = new SqlCommand(query, Conexao);
            comando.Parameters.Add(new SqlParameter("@id", Id));
            int resposta = comando.ExecuteNonQuery();
            if (resposta == 1)
            {
                MessageBox.Show("Usuário Excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
