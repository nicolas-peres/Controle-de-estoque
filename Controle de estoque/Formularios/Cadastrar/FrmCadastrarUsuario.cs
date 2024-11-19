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
            Usuarios u = new Usuarios();
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
    }
}
