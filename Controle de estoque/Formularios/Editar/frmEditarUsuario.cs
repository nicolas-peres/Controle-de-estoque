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
    public partial class frmEditarUsuario : Form
    {
        public frmEditarUsuario(int Id)
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

        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Id = Convert.ToInt32(txtId.Text);
            usuarios.Login = txtLogin.Text;
            usuarios.Senha = txtSenha.Text;
            usuarios.Ativo = chkAtivo.Checked;
            usuarios.Editar();
            usuarios = null;
            this.Close();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Id = Convert.ToInt32(txtId.Text);
            usuarios.Excluir();
            this.Close();
        }
    }
}
