namespace SAReflorestamento
{
    partial class frmTelaDeLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaDeLogin));
            this.pnlTelaLogin3 = new System.Windows.Forms.Panel();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.pnlTelaLogin = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.pnlTelaLogin2 = new System.Windows.Forms.Panel();
            this.btnEsqueceuSenha = new System.Windows.Forms.Button();
            this.pnlTelaLogin3.SuspendLayout();
            this.pnlTelaLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTelaLogin3
            // 
            this.pnlTelaLogin3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlTelaLogin3.Controls.Add(this.lblNomeEmpresa);
            this.pnlTelaLogin3.Location = new System.Drawing.Point(-1, 130);
            this.pnlTelaLogin3.Name = "pnlTelaLogin3";
            this.pnlTelaLogin3.Size = new System.Drawing.Size(301, 28);
            this.pnlTelaLogin3.TabIndex = 0;
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.Font = new System.Drawing.Font("Lucida Bright", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEmpresa.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNomeEmpresa.Location = new System.Drawing.Point(115, 5);
            this.lblNomeEmpresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(75, 18);
            this.lblNomeEmpresa.TabIndex = 7;
            this.lblNomeEmpresa.Text = "TPapper";
            // 
            // pnlTelaLogin
            // 
            this.pnlTelaLogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlTelaLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTelaLogin.Controls.Add(this.btnFechar);
            this.pnlTelaLogin.Controls.Add(this.btnMinimizar);
            this.pnlTelaLogin.Location = new System.Drawing.Point(-1, -1);
            this.pnlTelaLogin.Name = "pnlTelaLogin";
            this.pnlTelaLogin.Size = new System.Drawing.Size(301, 38);
            this.pnlTelaLogin.TabIndex = 12;
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = global::SAReflorestamento.Properties.Resources.close;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(266, 4);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(33, 24);
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
            this.btnMinimizar.Location = new System.Drawing.Point(228, 4);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(34, 25);
            this.btnMinimizar.TabIndex = 9;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(98, 299);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(174, 26);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(98, 245);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(174, 26);
            this.txtLogin.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUser.Location = new System.Drawing.Point(12, 245);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(74, 23);
            this.lblUser.TabIndex = 16;
            this.lblUser.Text = "Usuário:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSenha.Location = new System.Drawing.Point(12, 298);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(63, 23);
            this.lblSenha.TabIndex = 17;
            this.lblSenha.Text = "Senha:";
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnEntrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.Black;
            this.btnEntrar.Location = new System.Drawing.Point(105, 411);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(94, 41);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // pnlTelaLogin2
            // 
            this.pnlTelaLogin2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlTelaLogin2.BackgroundImage = global::SAReflorestamento.Properties.Resources.ecology51;
            this.pnlTelaLogin2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlTelaLogin2.Location = new System.Drawing.Point(-1, 32);
            this.pnlTelaLogin2.Name = "pnlTelaLogin2";
            this.pnlTelaLogin2.Size = new System.Drawing.Size(301, 100);
            this.pnlTelaLogin2.TabIndex = 11;
            // 
            // btnEsqueceuSenha
            // 
            this.btnEsqueceuSenha.FlatAppearance.BorderSize = 0;
            this.btnEsqueceuSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsqueceuSenha.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsqueceuSenha.ForeColor = System.Drawing.Color.Red;
            this.btnEsqueceuSenha.Location = new System.Drawing.Point(81, 471);
            this.btnEsqueceuSenha.Margin = new System.Windows.Forms.Padding(2);
            this.btnEsqueceuSenha.Name = "btnEsqueceuSenha";
            this.btnEsqueceuSenha.Size = new System.Drawing.Size(146, 28);
            this.btnEsqueceuSenha.TabIndex = 4;
            this.btnEsqueceuSenha.Text = "Esqueceu a senha?";
            this.btnEsqueceuSenha.UseVisualStyleBackColor = true;
            this.btnEsqueceuSenha.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTelaDeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(300, 510);
            this.Controls.Add(this.btnEsqueceuSenha);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.pnlTelaLogin);
            this.Controls.Add(this.pnlTelaLogin3);
            this.Controls.Add(this.pnlTelaLogin2);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelaDeLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.pnlTelaLogin3.ResumeLayout(false);
            this.pnlTelaLogin3.PerformLayout();
            this.pnlTelaLogin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel pnlTelaLogin2;
        private System.Windows.Forms.Panel pnlTelaLogin3;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.Panel pnlTelaLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnEsqueceuSenha;
    }
}