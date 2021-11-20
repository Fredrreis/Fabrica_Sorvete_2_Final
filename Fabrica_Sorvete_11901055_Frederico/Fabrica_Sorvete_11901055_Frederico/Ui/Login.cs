using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Fabrica_Sorvete_11901055_Frederico.Code.DTO;
using Fabrica_Sorvete_11901055_Frederico.Code.BLL;

namespace Fabrica_Sorvete_11901055_Frederico.Ui
{
    public partial class Login : Form
    {
        UsuarioBLL usuariobll = new UsuarioBLL();
        UsuarioDTO usuariodto = new UsuarioDTO();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            usuariodto.Idusuario = int.Parse(txtIdUsuario.Text);
            usuariodto.Emailusuario = txtEmail.Text;
            usuariodto.Senhausuario = txtSenha.Text;

            if(usuariobll.RealizarLogin(usuariodto) == true)
            {
                FormHome formHome = new FormHome();
                formHome.ShowDialog();

            }
            else
            {
                MessageBox.Show("Verfique email e senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }
    }
}
