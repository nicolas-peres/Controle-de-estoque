using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle_de_estoque.DAO;

namespace Controle_de_estoque
{
    public partial class FrmCadastrarProduto : Form
    {
        DataTable dados;
        ProdutosDao dao = new ProdutosDao();
        public FrmCadastrarProduto()
        {
            InitializeComponent();
            dados = new DataTable();
            foreach (var atributos in typeof(ProdutoEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dados = dao.ObterProdutos();

            dtGridProduto.DataSource = dados;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboNome_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void numQtd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProdutoEntidade p = new ProdutoEntidade();
            p.Id = numId.Value;
            p.Nome = comboNome.Text;
            p.Descricao = txtDescricao;
            p.Quantidade = numQtd.Value;
            p.Preco = txtPreco.Text;

            

            ProdutosDao dao = new ProdutosDao();
            dao.Inserir(p);

            dtGridProduto.DataSource = dao.ObterProdutos();

            LimparCampos();
        }
        private void LimparCampos()
        {
            txtPreco.Text = "";
            txtDescricao.Text = "";
            comboNome.Text = "";
            numQtd.Value = 0;
            numId.Value = 0;
        }

        private void FrmCadastrarProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
