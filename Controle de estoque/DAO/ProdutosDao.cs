using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controle_de_estoque.DAO
{
    public class ProdutosDao
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public ProdutosDao()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }

        public void Inserir(ProdutoEntidade produto)
        {
            Conexao.Open();
            string query = "Insert into Produtos (Nome , Descricao, Quantidade,Preco) Values (@nome, @descricao, @quantidade,@preco) ";
            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlParameter parametro1 = new SqlParameter("@nome", produto.Nome);
            SqlParameter parametro2 = new SqlParameter("@descricao", produto.Descricao);
            SqlParameter parametro3 = new SqlParameter("@quantidade", produto.Quantidade);
            SqlParameter parametro4 = new SqlParameter("@preco", produto.Preco);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.Parameters.Add(parametro4);


            comando.ExecuteNonQuery();
            Conexao.Close();

        }
        public DataTable PreencherComboBox()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT Id, Nome FROM Produto";

            using (SqlConnection connection = new SqlConnection(LinhaConexao))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                try
                {
                    // Preenche o DataTable com os dados da consulta
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    // Lida com erros, se necessário
                    throw new Exception("Erro ao acessar os dados: " + ex.Message);
                }
            }

            return dataTable;
        }
        public DataTable ObterProdutos()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT Id, Nome, Descricao, Quantidade,Preco FROM Professores Order by Id desc";
            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlDataReader Leitura = comando.ExecuteReader();

            foreach (var atributos in typeof(ProdutoEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    ProdutoEntidade p = new ProdutoEntidade();
                    p.Id = Convert.ToInt32(Leitura[0]);
                    p.Nome = Leitura[1].ToString();
                    p.Descricao = Leitura[2].ToString();
                    p.Quantidade = Convert.ToInt32(Leitura[3]);
                    p.Preco = Convert.ToInt32(Leitura[4]);
                    dt.Rows.Add(p.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }
        public DataTable Pesquisar(string pesquisa)
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "";
            if (string.IsNullOrEmpty(pesquisa))
            {
                query = "SELECT Id, Nome, Descricao, Quantidade,Preco FROM Produtos Order by Id desc";
            }
            else
            {
                query = "SELECT Id, Nome, Descricao, Quantidade,Preco FROM Produtos Where Nome like '%" + pesquisa + "%' Order by Id desc";
            }
            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlDataReader Leitura = comando.ExecuteReader();

            foreach (var atributos in typeof(ProdutoEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    ProdutoEntidade p = new ProdutoEntidade();
                    p.Id = Convert.ToInt32(Leitura[0]);
                    p.Nome = Leitura[1].ToString();
                    p.Descricao = Leitura[2].ToString();
                    p.Quantidade = Convert.ToInt32(Leitura[3]);
                    p.Preco = Convert.ToInt32(Leitura[4]);
                    dt.Rows.Add(p.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }

    }
}
