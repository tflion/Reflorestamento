namespace SAReflorestamento
{
    partial class frmTelaDeAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaDeAdm));
            this.pnlTelaAdm = new System.Windows.Forms.Panel();
            this.btnRegistrarDesmatamento = new System.Windows.Forms.Button();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.btnCalcularReflorestamento = new System.Windows.Forms.Button();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flpLogo = new System.Windows.Forms.FlowLayoutPanel();
            this.userCCalcularReflorestamento1 = new SAReflorestamento.UserCCalcularReflorestamento();
            this.userCRegistrarReflorest1 = new SAReflorestamento.UserCRegistrarDesmatamento();
            this.userTelaInicial1 = new SAReflorestamento.UserTelaInicial();
            this.userCCadastro = new SAReflorestamento.UserCCadastro();
            this.pnlTelaAdm.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTelaAdm
            // 
            this.pnlTelaAdm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlTelaAdm.Controls.Add(this.btnRegistrarDesmatamento);
            this.pnlTelaAdm.Controls.Add(this.btnCadastrarUsuario);
            this.pnlTelaAdm.Controls.Add(this.btnCalcularReflorestamento);
            this.pnlTelaAdm.Controls.Add(this.lblNomeEmpresa);
            this.pnlTelaAdm.Location = new System.Drawing.Point(0, 133);
            this.pnlTelaAdm.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTelaAdm.Name = "pnlTelaAdm";
            this.pnlTelaAdm.Size = new System.Drawing.Size(263, 519);
            this.pnlTelaAdm.TabIndex = 5;
            // 
            // btnRegistrarDesmatamento
            // 
            this.btnRegistrarDesmatamento.BackColor = System.Drawing.Color.Black;
            this.btnRegistrarDesmatamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegistrarDesmatamento.FlatAppearance.BorderSize = 0;
            this.btnRegistrarDesmatamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarDesmatamento.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarDesmatamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrarDesmatamento.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarDesmatamento.Image")));
            this.btnRegistrarDesmatamento.Location = new System.Drawing.Point(29, 210);
            this.btnRegistrarDesmatamento.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarDesmatamento.Name = "btnRegistrarDesmatamento";
            this.btnRegistrarDesmatamento.Size = new System.Drawing.Size(204, 63);
            this.btnRegistrarDesmatamento.TabIndex = 2;
            this.btnRegistrarDesmatamento.Text = "Registrar Desmatamento";
            this.btnRegistrarDesmatamento.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRegistrarDesmatamento.UseVisualStyleBackColor = false;
            this.btnRegistrarDesmatamento.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.BackColor = System.Drawing.Color.Black;
            this.btnCadastrarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastrarUsuario.FlatAppearance.BorderSize = 0;
            this.btnCadastrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarUsuario.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarUsuario.Image")));
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(61, 140);
            this.btnCadastrarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(141, 63);
            this.btnCadastrarUsuario.TabIndex = 1;
            this.btnCadastrarUsuario.Text = "Cadastrar Usuário";
            this.btnCadastrarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCadastrarUsuario.UseVisualStyleBackColor = false;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // btnCalcularReflorestamento
            // 
            this.btnCalcularReflorestamento.BackColor = System.Drawing.Color.Black;
            this.btnCalcularReflorestamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCalcularReflorestamento.FlatAppearance.BorderSize = 0;
            this.btnCalcularReflorestamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularReflorestamento.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularReflorestamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcularReflorestamento.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcularReflorestamento.Image")));
            this.btnCalcularReflorestamento.Location = new System.Drawing.Point(27, 282);
            this.btnCalcularReflorestamento.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcularReflorestamento.Name = "btnCalcularReflorestamento";
            this.btnCalcularReflorestamento.Size = new System.Drawing.Size(212, 63);
            this.btnCalcularReflorestamento.TabIndex = 3;
            this.btnCalcularReflorestamento.Text = "  Calcular   Reflorestamento";
            this.btnCalcularReflorestamento.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCalcularReflorestamento.UseVisualStyleBackColor = false;
            this.btnCalcularReflorestamento.Click += new System.EventHandler(this.btnCalcularReflorestamento_Click);
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.Font = new System.Drawing.Font("Lucida Bright", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEmpresa.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNomeEmpresa.Location = new System.Drawing.Point(83, 7);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(90, 22);
            this.lblNomeEmpresa.TabIndex = 6;
            this.lblNomeEmpresa.Text = "TPapper";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnFechar);
            this.panel3.Controls.Add(this.btnMinimizar);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1001, 39);
            this.panel3.TabIndex = 13;
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = global::SAReflorestamento.Properties.Resources.close;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(956, 2);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(44, 30);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = global::SAReflorestamento.Properties.Resources.minimize__1_;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(905, 1);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(45, 31);
            this.btnMinimizar.TabIndex = 9;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBemVindo.Location = new System.Drawing.Point(516, 175);
            this.lblBemVindo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(249, 24);
            this.lblBemVindo.TabIndex = 14;
            this.lblBemVindo.Text = "Bem vindo admnistrador!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(597, 340);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Escolha uma opção ao lado :)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SAReflorestamento.Properties.Resources.left_arrow;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(427, 316);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 62);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // flpLogo
            // 
            this.flpLogo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flpLogo.BackgroundImage = global::SAReflorestamento.Properties.Resources.ecology5;
            this.flpLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flpLogo.Location = new System.Drawing.Point(0, 36);
            this.flpLogo.Margin = new System.Windows.Forms.Padding(4);
            this.flpLogo.Name = "flpLogo";
            this.flpLogo.Size = new System.Drawing.Size(263, 101);
            this.flpLogo.TabIndex = 4;
            this.flpLogo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.flpLogo_MouseClick);
            // 
            // userCCalcularReflorestamento1
            // 
            this.userCCalcularReflorestamento1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.userCCalcularReflorestamento1.Location = new System.Drawing.Point(252, 36);
            this.userCCalcularReflorestamento1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userCCalcularReflorestamento1.Name = "userCCalcularReflorestamento1";
            this.userCCalcularReflorestamento1.Size = new System.Drawing.Size(749, 615);
            this.userCCalcularReflorestamento1.TabIndex = 21;
            this.userCCalcularReflorestamento1.Load += new System.EventHandler(this.userCCalcularReflorestamento1_Load);
            // 
            // userCRegistrarReflorest1
            // 
            this.userCRegistrarReflorest1.Location = new System.Drawing.Point(251, 36);
            this.userCRegistrarReflorest1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userCRegistrarReflorest1.Name = "userCRegistrarReflorest1";
            this.userCRegistrarReflorest1.Size = new System.Drawing.Size(749, 613);
            this.userCRegistrarReflorest1.TabIndex = 20;
            // 
            // userTelaInicial1
            // 
            this.userTelaInicial1.Location = new System.Drawing.Point(251, 36);
            this.userTelaInicial1.Margin = new System.Windows.Forms.Padding(5);
            this.userTelaInicial1.Name = "userTelaInicial1";
            this.userTelaInicial1.Size = new System.Drawing.Size(749, 613);
            this.userTelaInicial1.TabIndex = 19;
            // 
            // userCCadastro
            // 
            this.userCCadastro.Location = new System.Drawing.Point(251, 39);
            this.userCCadastro.Margin = new System.Windows.Forms.Padding(5);
            this.userCCadastro.Name = "userCCadastro";
            this.userCCadastro.Size = new System.Drawing.Size(753, 613);
            this.userCCadastro.TabIndex = 18;
            // 
            // frmTelaDeAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1000, 652);
            this.Controls.Add(this.userCCalcularReflorestamento1);
            this.Controls.Add(this.userCRegistrarReflorest1);
            this.Controls.Add(this.userTelaInicial1);
            this.Controls.Add(this.userCCadastro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlTelaAdm);
            this.Controls.Add(this.flpLogo);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTelaDeAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlTelaAdm.ResumeLayout(false);
            this.pnlTelaAdm.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpLogo;
        private System.Windows.Forms.Panel pnlTelaAdm;
        private System.Windows.Forms.Button btnCalcularReflorestamento;
        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.Button btnRegistrarDesmatamento;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserTelaInicial userTelaInicial1;
        private UserCCadastro userCCadastro;
        private UserCRegistrarDesmatamento userCRegistrarReflorest1;
        private UserCCalcularReflorestamento userCCalcularReflorestamento1;
    }
}

