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
    public partial class UserCRegistrarDesmatamento : UserControl
    {
        bool validar;
        ClassDesmatamento desmatamento = new ClassDesmatamento();

        int codDesmatamentoClicado = 0;

        public UserCRegistrarDesmatamento()
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            desmatamento.Ano = int.Parse(txtAno.Text);
            desmatamento.Estado = cboEstado.Text;
            desmatamento.NumArv = int.Parse(txtArvoresCortadas.Text);
            desmatamento.VolumeArv = int.Parse(txtVolumeArvores.Text);


            if (validar == true)
            {
                if (int.Parse(txtAno.Text) < 1999 || int.Parse(txtAno.Text) > 2018)
                {
                    MessageBox.Show("    São válidos anos de 1999 a 2018");
                    txtAno.Text = "";
                }
                else if (int.Parse(txtVolumeArvores.Text) < 100 || int.Parse(txtArvoresCortadas.Text) < 100)
                {
                    MessageBox.Show("    Volume e número de árvores cortadas devem ser maior que 100");
                }
                else if (desmatamento.Inserir() == true)
                {
                    MessageBox.Show("   Desmatamento cadastrado com êxito!");
                    dgvDesmatamento.DataSource = desmatamento.RetTodosDesmatamentos();
                    validar = false;
                }
                else
                {
                    MessageBox.Show("      Erro ao tentar cadastrar!");
                }
            }
            else
            {
                MessageBox.Show("    Valide o cadastro primeiro!");
            }

        }

        private void UserCRegistrarReflorest_Load(object sender, EventArgs e)
        {
            dgvDesmatamento.ForeColor = Color.Black;
        }

        private void btnEditarDesmatamento_Click(object sender, EventArgs e)
        {
            desmatamento.Ano = int.Parse(txtAno.Text);
            desmatamento.Estado = cboEstado.Text;
            desmatamento.NumArv = int.Parse(txtArvoresCortadas.Text);
            desmatamento.VolumeArv = int.Parse(txtVolumeArvores.Text);

            if (desmatamento.Editar(codDesmatamentoClicado) == true)
            {
                MessageBox.Show("    Desmatamento editado com êxito!");
                dgvDesmatamento.DataSource = desmatamento.RetTodosDesmatamentos();
            }
            else
            {
                MessageBox.Show("      Erro ao tentar editar!");
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




        }

        private void btnExcluirDesmatamento_Click(object sender, EventArgs e)
        {
            desmatamento.Ano = int.Parse(txtAno.Text);
            desmatamento.Estado = cboEstado.Text;
            desmatamento.NumArv = int.Parse(txtArvoresCortadas.Text);
            desmatamento.VolumeArv = int.Parse(txtVolumeArvores.Text);

            if (desmatamento.Excluir(codDesmatamentoClicado) == true)
            {
                MessageBox.Show("    Desmatamento excluído com êxito!");

                dgvDesmatamento.DataSource = desmatamento.RetTodosDesmatamentos();
            }
            else
            {
                MessageBox.Show("      Erro ao tentar excluir!");
            }
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboEstado_Leave(object sender, EventArgs e)
        {
            //-- 1
            if (cboEstado.Text == "Acre")
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dgvDesmatamento.DataSource = desmatamento.RetTodosDesmatamentos();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtAno.Text) < 3 || txtArvoresCortadas.Text.Length < 3 || txtVolumeArvores.Text.Length < 3 || cboEstado.Text.Length < 2)
            {
                MessageBox.Show("Todos os campos devem conter ao menos 3 caracteres!");
                validar = false;
            }
            else
            {
                MessageBox.Show("Validação realizada com Sucesso, pressione salvar para concluir!");
                validar = true;
            }
        }
    }
}





