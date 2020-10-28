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
    public partial class frmTelaDeUsuario : Form
    {
        public frmTelaDeUsuario()
        {
            InitializeComponent();
        }

        private void userCTelaDeAssist1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarReflorestamento_Click(object sender, EventArgs e)
        {
            userCRegistrarReflorest1.BringToFront();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void flpLogo_MouseClick(object sender, MouseEventArgs e)
        {
            userCTelaDeAssist1.BringToFront();
        }

        private void frmTelaDeUsuario_Load(object sender, EventArgs e)
        {
            
        }
    }
}
