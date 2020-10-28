namespace SAReflorestamento
{
    partial class frmCadastrarUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarUsuario));
            this.pnlTelaCadUser = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTipoUser = new System.Windows.Forms.TextBox();
            this.txtNomeUser = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLoginUser = new System.Windows.Forms.TextBox();
            this.txtSenhaUser = new System.Windows.Forms.TextBox();
            this.flpLogo = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlNomeCadastro = new System.Windows.Forms.Panel();
            this.lblNomeCadastro = new System.Windows.Forms.Label();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnExcluirUsuario = new System.Windows.Forms.Button();
            this.dgvSQL = new System.Windows.Forms.DataGridView();
            this.pnlTelaCadUser.SuspendLayout();
            this.pnlNomeCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQL)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTelaCadUser
            // 
            this.pnlTelaCadUser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTelaCadUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTelaCadUser.Controls.Add(this.btnFechar);
            this.pnlTelaCadUser.Controls.Add(this.btnMinimizar);
            this.pnlTelaCadUser.Location = new System.Drawing.Point(0, -2);
            this.pnlTelaCadUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTelaCadUser.Name = "pnlTelaCadUser";
            this.pnlTelaCadUser.Size = new System.Drawing.Size(1002, 48);
            this.pnlTelaCadUser.TabIndex = 15;
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = global::SAReflorestamento.Properties.Resources.close;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(953, 7);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(44, 30);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = global::SAReflorestamento.Properties.Resources.minimize__1_;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(905, 7);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(45, 31);
            this.btnMinimizar.TabIndex = 9;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(91, 219);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(114, 24);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Tipo Usuário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 336);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 278);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 391);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "CPF: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 447);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(600, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Login:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(596, 279);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Senha:";
            // 
            // txtTipoUser
            // 
            this.txtTipoUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoUser.Location = new System.Drawing.Point(239, 217);
            this.txtTipoUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTipoUser.Name = "txtTipoUser";
            this.txtTipoUser.Size = new System.Drawing.Size(196, 30);
            this.txtTipoUser.TabIndex = 23;
            // 
            // txtNomeUser
            // 
            this.txtNomeUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUser.Location = new System.Drawing.Point(239, 276);
            this.txtNomeUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeUser.Name = "txtNomeUser";
            this.txtNomeUser.Size = new System.Drawing.Size(196, 30);
            this.txtNomeUser.TabIndex = 24;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(239, 334);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(196, 30);
            this.txtTelefone.TabIndex = 25;
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(239, 389);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(196, 30);
            this.txtCpf.TabIndex = 26;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(239, 444);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(196, 30);
            this.txtEmail.TabIndex = 27;
            // 
            // txtLoginUser
            // 
            this.txtLoginUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUser.Location = new System.Drawing.Point(692, 219);
            this.txtLoginUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoginUser.Name = "txtLoginUser";
            this.txtLoginUser.Size = new System.Drawing.Size(196, 30);
            this.txtLoginUser.TabIndex = 28;
            // 
            // txtSenhaUser
            // 
            this.txtSenhaUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaUser.Location = new System.Drawing.Point(692, 277);
            this.txtSenhaUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSenhaUser.Name = "txtSenhaUser";
            this.txtSenhaUser.Size = new System.Drawing.Size(196, 30);
            this.txtSenhaUser.TabIndex = 29;
            // 
            // flpLogo
            // 
            this.flpLogo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flpLogo.BackgroundImage = global::SAReflorestamento.Properties.Resources.ecology5;
            this.flpLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flpLogo.Location = new System.Drawing.Point(0, 43);
            this.flpLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpLogo.Name = "flpLogo";
            this.flpLogo.Size = new System.Drawing.Size(1003, 92);
            this.flpLogo.TabIndex = 30;
            // 
            // pnlNomeCadastro
            // 
            this.pnlNomeCadastro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlNomeCadastro.Controls.Add(this.lblNomeCadastro);
            this.pnlNomeCadastro.Location = new System.Drawing.Point(0, 135);
            this.pnlNomeCadastro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlNomeCadastro.Name = "pnlNomeCadastro";
            this.pnlNomeCadastro.Size = new System.Drawing.Size(1003, 44);
            this.pnlNomeCadastro.TabIndex = 31;
            // 
            // lblNomeCadastro
            // 
            this.lblNomeCadastro.AutoSize = true;
            this.lblNomeCadastro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCadastro.ForeColor = System.Drawing.Color.Green;
            this.lblNomeCadastro.Location = new System.Drawing.Point(416, 4);
            this.lblNomeCadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeCadastro.Name = "lblNomeCadastro";
            this.lblNomeCadastro.Size = new System.Drawing.Size(169, 24);
            this.lblNomeCadastro.TabIndex = 0;
            this.lblNomeCadastro.Text = "Cadastro de Usuário";
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.BackColor = System.Drawing.Color.LightGray;
            this.btnCadastrarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarUsuario.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarUsuario.Image")));
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(16, 561);
            this.btnCadastrarUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(152, 63);
            this.btnCadastrarUsuario.TabIndex = 32;
            this.btnCadastrarUsuario.Text = "Cadastrar Usuário";
            this.btnCadastrarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCadastrarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.BackColor = System.Drawing.Color.LightGray;
            this.btnEditarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarUsuario.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarUsuario.Image")));
            this.btnEditarUsuario.Location = new System.Drawing.Point(188, 561);
            this.btnEditarUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(152, 63);
            this.btnEditarUsuario.TabIndex = 33;
            this.btnEditarUsuario.Text = "Editar Usuário";
            this.btnEditarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnExcluirUsuario
            // 
            this.btnExcluirUsuario.BackColor = System.Drawing.Color.LightGray;
            this.btnExcluirUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluirUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirUsuario.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluirUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirUsuario.Image")));
            this.btnExcluirUsuario.Location = new System.Drawing.Point(365, 561);
            this.btnExcluirUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluirUsuario.Name = "btnExcluirUsuario";
            this.btnExcluirUsuario.Size = new System.Drawing.Size(152, 63);
            this.btnExcluirUsuario.TabIndex = 34;
            this.btnExcluirUsuario.Text = "Excluir Usuário";
            this.btnExcluirUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExcluirUsuario.UseVisualStyleBackColor = false;
            // 
            // dgvSQL
            // 
            this.dgvSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSQL.Location = new System.Drawing.Point(564, 379);
            this.dgvSQL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSQL.Name = "dgvSQL";
            this.dgvSQL.Size = new System.Drawing.Size(407, 245);
            this.dgvSQL.TabIndex = 35;
            // 
            // frmCadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1000, 652);
            this.Controls.Add(this.dgvSQL);
            this.Controls.Add(this.btnExcluirUsuario);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.btnCadastrarUsuario);
            this.Controls.Add(this.pnlNomeCadastro);
            this.Controls.Add(this.flpLogo);
            this.Controls.Add(this.txtSenhaUser);
            this.Controls.Add(this.txtLoginUser);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNomeUser);
            this.Controls.Add(this.txtTipoUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pnlTelaCadUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCadastrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastrarUsuario";
            this.pnlTelaCadUser.ResumeLayout(false);
            this.pnlNomeCadastro.ResumeLayout(false);
            this.pnlNomeCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTelaCadUser;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTipoUser;
        private System.Windows.Forms.TextBox txtNomeUser;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLoginUser;
        private System.Windows.Forms.TextBox txtSenhaUser;
        private System.Windows.Forms.FlowLayoutPanel flpLogo;
        private System.Windows.Forms.Panel pnlNomeCadastro;
        private System.Windows.Forms.Label lblNomeCadastro;
        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnExcluirUsuario;
        private System.Windows.Forms.DataGridView dgvSQL;
    }
}