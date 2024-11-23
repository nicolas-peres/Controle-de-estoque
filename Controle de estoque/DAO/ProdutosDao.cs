﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle_de_estoque.Classes;

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

        public void Inserir (Produto produto)
        {
            Conexao.Open();
            string query = "INSERT INTO Produtos (Nome, Descricao, Preco, Quantidade) VALUES (@nome, @descricao, @preco, @quantidade)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            comando.Parameters.Add(new SqlParameter("@nome", produto.Nome));
            comando.Parameters.Add(new SqlParameter("@descricao", produto.Descricao));
            comando.Parameters.Add(new SqlParameter("@preco", produto.Preco));
            comando.Parameters.Add(new SqlParameter("@estoque", produto.Quantidade));
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

            foreach (var atributos in typeof(Produto).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    Produto p = new Produto();
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

            foreach (var atributos in typeof(Produto).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    Produto p = new Produto();
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