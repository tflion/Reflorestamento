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
    public partial class UserCCadastro : UserControl
    {
        ClassUsuario Usuario = new ClassUsuario();
        bool validar;

        int codUsuarioClicado = 0;

        public UserCCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            if (Usuario.VerificarEmail(txtEmail.Text) == 0)
            {
                if (Usuario.VerificarCpf(mskCpf.Text) == 0)
                {


                    if ((txtLoginUser.Text != "") && (txtSenhaUser.Text != "" && txtEmail.Text != "" && txtNomeUser.Text != "" && cboTipoUser.Text != ""
                        && mskCpf.Text != "" && mskTelefone.Text != ""))
                    {
                        Usuario.Nome = txtNomeUser.Text;
                        Usuario.Cpf = mskCpf.Text;
                        Usuario.LoginUs = txtLoginUser.Text;
                        Usuario.SenhaUs = txtSenhaUser.Text;
                        Usuario.Telefone = mskTelefone.Text;
                        Usuario.Email = txtEmail.Text;
                        Usuario.TipoUsuario = cboTipoUser.Text;

                        if (validar == true)
                        {
                            if (Usuario.Inserir() == true)
                            {
                                MessageBox.Show("Usuário cadastrado com êxito!");
                                dgvUsuario.DataSource = Usuario.RetTodosClientes();
                                validar = false;

                                dgvUsuario.DefaultCellStyle.SelectionForeColor = Color.Black;
                            }

                            else
                            {
                                MessageBox.Show("       Favor preencher todos os dados!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("    Valide o cadastro primeiro!");
                        }
                    }                   
                }
                else
                {
                    MessageBox.Show("   CPF já cadastrado!");
                    mskCpf.Text = "";
                }
            }
            else
            {
                MessageBox.Show("   Email já cadastrado!");
                txtEmail.Text = "";
            }
        }
        private void dgvSQL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {

            Usuario.Nome = txtNomeUser.Text;
            Usuario.Cpf = mskCpf.Text;
            Usuario.LoginUs = txtLoginUser.Text;
            Usuario.SenhaUs = txtSenhaUser.Text;
            Usuario.Telefone = mskTelefone.Text;
            Usuario.Email = txtEmail.Text;
            Usuario.TipoUsuario = cboTipoUser.Text;

            if (Usuario.Editar(codUsuarioClicado) == true)
            {
                MessageBox.Show("   Usuário editado com êxito!");
                dgvUsuario.DataSource = Usuario.RetTodosClientes();
            }
            else
            {
                MessageBox.Show("   Erro ao editar o usuário!");

            }

        }

        private void UserCCadastro_Load(object sender, EventArgs e)
        {
            dgvUsuario.DataSource = Usuario.RetTodosClientes();
            dgvUsuario.ForeColor = Color.Black;
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuario.Rows[e.RowIndex].Cells["codUsuario"].
                    Value.ToString() != "")
            {
                codUsuarioClicado = int.Parse(dgvUsuario.Rows
                    [e.RowIndex].Cells["codUsuario"].Value.ToString());
            }

            txtNomeUser.Text = dgvUsuario.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            mskTelefone.Text = dgvUsuario.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
            txtEmail.Text = dgvUsuario.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtSenhaUser.Text = dgvUsuario.Rows[e.RowIndex].Cells["senhaUs"].Value.ToString();
            cboTipoUser.Text = dgvUsuario.Rows[e.RowIndex].Cells["tipoUsuario"].Value.ToString();
            mskTelefone.Text = dgvUsuario.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
            mskCpf.Text = dgvUsuario.Rows[e.RowIndex].Cells["cpf"].Value.ToString();

            dgvUsuario.DataSource = Usuario.RetTodosClientes();
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {

            Usuario.Nome = txtNomeUser.Text;
            Usuario.Cpf = mskCpf.Text;
            Usuario.LoginUs = txtLoginUser.Text;
            Usuario.SenhaUs = txtSenhaUser.Text;
            Usuario.Telefone = mskTelefone.Text;
            Usuario.Email = txtEmail.Text;
            Usuario.TipoUsuario = cboTipoUser.Text;

            if (Usuario.Excluir(codUsuarioClicado) == true)
            {
                MessageBox.Show("   Usuário excluído com êxito!");
            }

            dgvUsuario.DataSource = Usuario.RetTodosClientes();



        }

        private void txtSenhaUser_TextChanged(object sender, EventArgs e)
        {
            txtSenhaUser.PasswordChar = '☻';

            txtSenhaUser.MaxLength = 6;
        }

        private void txtNomeUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Text box aceitar apenas letras
            if (!(char.IsLetter(e.KeyChar)) // Apenas letras
                && !(e.KeyChar == (char)Keys.Enter) // E enter
                && !(e.KeyChar == (char)Keys.Back)) // E basckspace
            {
                e.Handled = true;
            }


        }

        private void dgvUsuario_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuario.Rows[e.RowIndex].Cells["codUsuario"].
                                Value.ToString() != "")
            {
                codUsuarioClicado = int.Parse(dgvUsuario.Rows
                    [e.RowIndex].Cells["codUsuario"].Value.ToString());
            }

            txtLoginUser.Text = dgvUsuario.Rows[e.RowIndex].Cells["loginUs"].Value.ToString();
            txtSenhaUser.Text = dgvUsuario.Rows[e.RowIndex].Cells["senhaUs"].Value.ToString();
            txtEmail.Text = dgvUsuario.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtNomeUser.Text = dgvUsuario.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            mskCpf.Text = dgvUsuario.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
            mskTelefone.Text = dgvUsuario.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
            cboTipoUser.Text = dgvUsuario.Rows[e.RowIndex].Cells["tipoUsuario"].Value.ToString();
        }

        private void cboTipoUser_Leave(object sender, EventArgs e)
        {
            if (cboTipoUser.Text == "Admnistrador")
            {
                cboTipoUser.Text = "1";
            }
            else
            {
                cboTipoUser.Text = "2";
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if ((txtNomeUser.Text.Length < 3 || txtEmail.Text.Length < 3 || txtLoginUser.Text.Length < 3 || txtSenhaUser.Text.Length < 3
                || mskCpf.Text.Length < 3 || mskTelefone.Text.Length < 3))
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

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dgvUsuario.DataSource = Usuario.RetUsuariosNome(txtBusca.Text);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            txtLoginUser.Text = txtEmail.Text.Substring(0, txtEmail.Text.IndexOf('@'));
        }
    }
}



