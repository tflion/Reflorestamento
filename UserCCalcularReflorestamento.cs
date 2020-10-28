using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAReflorestamento
{
    public partial class UserCCalcularReflorestamento : UserControl
    {
        ClassDesmatamento desmatamento = new ClassDesmatamento();

        int codDesmatamentoClicado = 0;

        public UserCCalcularReflorestamento()
        {
            InitializeComponent();
            dgvDesmatamento.DataSource = desmatamento.RetTodosDesmatamentos();
        }

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtArvoresCortadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtVolumeArvores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void cboEstado_Leave(object sender, EventArgs e)
        {
            
            //-- 1
            if(cboEstado.Text == "Acre")
            {
                cboEstado.Text = "AC";
            }
            //-- 2
            if (cboEstado.Text == "Alagoas")
            {
                cboEstado.Text = "AL";
            }
            //-- 3
            if (cboEstado.Text == "Amapá")
            {
                cboEstado.Text = "AP";
            }
            //-- 4
            if (cboEstado.Text == "Amazonas")
            {
                cboEstado.Text = "AM";
            }
            //-- 5
            if (cboEstado.Text == "Bahia")
            {
                cboEstado.Text = "BA";
            }
            //-- 6
            if (cboEstado.Text == "Ceará")
            {
                cboEstado.Text = "CE";
            }
            //-- 7
            if (cboEstado.Text == "Distrito Federal")
            {
                cboEstado.Text = "DF";
            }
            //-- 8
            if (cboEstado.Text == "Espírito Santo")
            {
                cboEstado.Text = "ES";
            }
            //-- 9
            if (cboEstado.Text == "Goiás")
            {
                cboEstado.Text = "GO";
            }
            //-- 10 
            if (cboEstado.Text == "Maranhão")
            {
                cboEstado.Text = "MA";
            }
            //-- 11
            if (cboEstado.Text == "Mato Grosso")
            {
                cboEstado.Text = "MT";
            }
            //-- 12
            if (cboEstado.Text == "Mato Gosso Do Sul")
            {
                cboEstado.Text = "MS";
            }
            //-- 13
            if (cboEstado.Text == "Minas Gerais")
            {
                cboEstado.Text = "MG";
            }
            //-- 14
            if (cboEstado.Text == "Pará")
            {
                cboEstado.Text = "PA";
            }
            //-- 15
            if (cboEstado.Text == "Paraíba")
            {
                cboEstado.Text = "PB";
            }
            //-- 16
            if (cboEstado.Text == "Paraná")
            {
                cboEstado.Text = "PR";
            }
            //-- 17
            if (cboEstado.Text == "Pernambuco")
            {
                cboEstado.Text = "PE";
            }
            //-- 18
            if (cboEstado.Text == "Piauí")
            {
                cboEstado.Text = "PI";
            }
            //-- 19
            if (cboEstado.Text == "Rio de Janeiro")
            {
                cboEstado.Text = "RJ";
            }
            //-- 20 
            if (cboEstado.Text == "Rio Grande do Norte")
            {
                cboEstado.Text = "RN";
            }
            if (cboEstado.Text == "Rio Grande do Sul")
            {
                cboEstado.Text = "RS";
            }
            //-- 21
            if (cboEstado.Text == "Rondônia")
            {
                cboEstado.Text = "RO";
            }
            //-- 22
            if (cboEstado.Text == "Roraima")
            {
                cboEstado.Text = "RR";
            }
            //-- 23
            if (cboEstado.Text == "Santa Catarina")
            {
                cboEstado.Text = "SC";
            }
            //-- 24
            if (cboEstado.Text == "São Paulo")
            {
                cboEstado.Text = "SP";
            }
            //-- 25
            if (cboEstado.Text == "Sergipe")
            {
                cboEstado.Text = "SE";
            }
            //-- 26
            if (cboEstado.Text == "Tocantins")
            {
                cboEstado.Text = "TO";
            }
        }

        private void dgvDesmatamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDesmatamento.Rows[e.RowIndex].Cells["codCalculo"].
                                Value.ToString() != "")
            {
                codDesmatamentoClicado = int.Parse(dgvDesmatamento.Rows
                    [e.RowIndex].Cells["codCalculo"].Value.ToString());
            }

            txtAno.Text = dgvDesmatamento.Rows[e.RowIndex].Cells["ano"].Value.ToString();
            cboEstado.Text = dgvDesmatamento.Rows[e.RowIndex].Cells["estado"].Value.ToString();
            txtArvoresCortadas.Text = dgvDesmatamento.Rows[e.RowIndex].Cells["numArvoresCortadas"].Value.ToString();
            txtVolumeArvores.Text = dgvDesmatamento.Rows[e.RowIndex].Cells["volumeM3"].Value.ToString();
            txtArvoresRepor.Text = dgvDesmatamento.Rows[e.RowIndex].Cells["arvoresARepor"].Value.ToString();
            txtValorPagar.Text = dgvDesmatamento.Rows[e.RowIndex].Cells["valorAPagar"].Value.ToString();

        }

        private void btnIndTotalPagar_Click(object sender, EventArgs e)
        {
            int valorPagar;

            valorPagar = int.Parse(txtArvoresCortadas.Text) * 6;

            desmatamento.ValorAPagar = valorPagar;

            desmatamento.InserirValor(codDesmatamentoClicado);

            dgvDesmatamento.DataSource = desmatamento.RetTodosDesmatamentos();

            txtValorPagar.Text = valorPagar.ToString();

        }

        private void btnIndReposicao_Click(object sender, EventArgs e)
        {
            double reposicao;

            reposicao = double.Parse(txtVolumeArvores.Text) * 0.75;

            desmatamento.QuantidadeRepor = reposicao;

            desmatamento.ReporArvores(codDesmatamentoClicado);

            dgvDesmatamento.DataSource = desmatamento.RetTodosDesmatamentos();

           txtArvoresRepor.Text = reposicao.ToString();

        }

        private void UserCCalcularReflorestamento_Load(object sender, EventArgs e)
        {
            dgvDesmatamento.ForeColor = Color.Black;
        }

        private void txtAno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dgvDesmatamento.DataSource = desmatamento.RetTodosDesmatamentos();
        }
    }
}
