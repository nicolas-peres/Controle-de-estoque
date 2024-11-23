using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle_de_estoque.Classes;

namespace Controle_de_estoque.Formularios
{
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }
        private Dictionary<string, decimal> produtos = new Dictionary<string, decimal>
{
    { "Produto A", 10.50m },
    { "Produto B", 20.00m },
    { "Produto C", 15.75m }
};

        
        private decimal ObterPrecoProduto(string nomeProduto)
        {
            if (produtos.ContainsKey(nomeProduto))
            {
                return produtos[nomeProduto];
            }
            else
            {
                throw new Exception("Produto não encontrado.");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (var produto in produtos)
            {
                comboBoxProdutos.Items.Add(produto.Key);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            
            string produtoSelecionado = comboBoxProdutos.SelectedItem.ToString();
            decimal preco = ObterPrecoProduto(produtoSelecionado); 
            int quantidade = int.Parse(NumQtd.Text);
            decimal subtotal = preco * quantidade;

            dgvProdutos.Rows.Add(produtoSelecionado, preco, quantidade, subtotal);


            AtualizarTotal();
        }
        private void AtualizarTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvProdutos.Rows)
            {
                total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
            }
            lblTotal.Text = $"Total: {total:C}";
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                dgvProdutos.Rows.RemoveAt(dgvProdutos.SelectedRows[0].Index);
                AtualizarTotal();
            }
        }

        private void btnFInalizar_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgvProdutos.Rows)
            {
                string produto = row.Cells["Produto"].Value.ToString();
                int quantidade = int.Parse(row.Cells["Quantidade"].Value.ToString());
                decimal subtotal = decimal.Parse(row.Cells["Subtotal"].Value.ToString());


                SalvarCompra(produto, quantidade, subtotal);
            }

            MessageBox.Show("Compra finalizada com sucesso!");
            dgvProdutos.Rows.Clear();
            AtualizarTotal();
        }


        private void SalvarCompra(string produto, int quantidade, decimal subtotal)
        {

            string connectionString = "sua_string_de_conexao";


            string query = "INSERT INTO Compras (Produto, Quantidade, Subtotal) VALUES (@Produto, @Quantidade, @Subtotal)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Produto", produto);
                    command.Parameters.AddWithValue("@Quantidade", quantidade);
                    command.Parameters.AddWithValue("@Subtotal", subtotal);


                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
