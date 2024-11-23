using Controle_de_estoque.Classes;
using MapaSala.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_estoque.Formularios.Editar
{
    public partial class frmEditarProduto : Form
    {
        public frmEditarProduto(int Id)
        {
            InitializeComponent();
            Usuarios usuarios = new Usuarios();
            usuarios.PesquisarPorId(Id);
            txtId.Text = usuarios.Id.ToString();
            txtLogin.Text = usuarios.Login;
            txtSenha.Text = usuarios.Senha;
            chkAtivo.Checked = usuarios.Ativo;
            usuarios = null;
        }

        private void frmEditarProduto_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Id = Convert.ToInt32(txtId.Text);
            produto.Nome = comboNome.Text;
            produto.Descricao = txtDescricao.Text;
            produto.Quantidade = Convert.ToInt32(numQtd.Value);
            produto.Preco = txtpreco.Text;
            produto.Editar();
            produto = null;
            this.Close();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Id = Convert.ToInt32(txtId.Text);
            produto.Excluir();
            this.Close();
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
