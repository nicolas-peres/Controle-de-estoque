using Controle_de_estoque.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Entidades;
namespace MapaSala.Formularios
{
    public partial class frmCadastrarUsuario : Form
    {
        public frmCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void btncadastro_Click(object sender, EventArgs e)
        {
             u = new Usuarios();
            u.Login = txtUsuario.Text;
            u.Senha = txtSenha.Text;
            u.Ativo = chkAtivo.Checked;
            u.Inserir();

            MessageBox.Show("Sucesso, usuário cadastrado");
            Close();
        }

        private void txtLogin_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
