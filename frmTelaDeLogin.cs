using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAReflorestamento
{
    public partial class frmTelaDeLogin : Form
    {
        ClassUsuario Usuario = new ClassUsuario();

        public frmTelaDeLogin()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario.LoginUs = txtLogin.Text;
            Usuario.SenhaUs = txtSenha.Text;

            //Preenche a tabela com todos os dados vindos do select de 
            //realizar login
            DataTable dt = Usuario.RealizarLogin();


            //Como saber se foram retornados registros do select
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("     Usuário não existe!");
               
            }
            else
            {
                // Usar os dados desta tabela
                string nome = dt.Rows[0]["nome"].ToString();
                string codUser = dt.Rows[0]["codUsuario"].ToString();
                string tipoUsuario = dt.Rows[0]["tipoUsuario"].ToString();

                txtLogin.Text = "";
                txtSenha.Text = "";

                frmTelaDeAdm telaDeAdm = new frmTelaDeAdm();
                frmTelaDeUsuario telaDeUsuario = new frmTelaDeUsuario();

                if (tipoUsuario == "1")
                {
                    telaDeAdm.Show();
                }
                else if (tipoUsuario == "2")
                {
                    telaDeUsuario.Show();
                }
              
            }
        }

   

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '☻';

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRecuperarSenha recuperarSenha = new frmRecuperarSenha();

            recuperarSenha.Show();
        }
    }
}

