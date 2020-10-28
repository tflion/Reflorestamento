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
    public partial class frmTelaDeAdm : Form
    {
        public frmTelaDeAdm()
        {
            InitializeComponent();
            userTelaInicial1.BringToFront();
            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            userCCadastro.BringToFront();
        }

        private void userCCadastro1_Load(object sender, EventArgs e)
        {

        }

        private void flpLogo_MouseClick(object sender, MouseEventArgs e)
        {
            userTelaInicial1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userCRegistrarReflorest1.BringToFront();
        }

        private void btnCalcularReflorestamento_Click(object sender, EventArgs e)
        {
            userCCalcularReflorestamento1.BringToFront();
        }

        private void userCCalcularReflorestamento1_Load(object sender, EventArgs e)
        {

        }
    }
}
