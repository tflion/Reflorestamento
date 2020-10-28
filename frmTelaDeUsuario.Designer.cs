namespace SAReflorestamento
{
    partial class frmTelaDeUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaDeUsuario));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.pnlTelaAdm = new System.Windows.Forms.Panel();
            this.btnRegistrarReflorestamento = new System.Windows.Forms.Button();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.userCRegistrarReflorest1 = new SAReflorestamento.UserCRegistrarDesmatamento();
            this.flpLogo = new System.Windows.Forms.FlowLayoutPanel();
            this.userCTelaDeAssist1 = new SAReflorestamento.UserCTelaDeAssist();
            this.panel3.SuspendLayout();
            this.pnlTelaAdm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnFechar);
            this.panel3.Controls.Add(this.btnMinimizar);
            this.panel3.Location = new System.Drawing.Point(0, -1);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1002, 43);
            this.panel3.TabIndex = 14;
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
            // pnlTelaAdm
            // 
            this.pnlTelaAdm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlTelaAdm.Controls.Add(this.btnRegistrarReflorestamento);
            this.pnlTelaAdm.Controls.Add(this.lblNomeEmpresa);
            this.pnlTelaAdm.Location = new System.Drawing.Point(0, 144);
            this.pnlTelaAdm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTelaAdm.Name = "pnlTelaAdm";
            this.pnlTelaAdm.Size = new System.Drawing.Size(263, 519);
            this.pnlTelaAdm.TabIndex = 16;
            // 
            // btnRegistrarReflorestamento
            // 
            this.btnRegistrarReflorestamento.BackColor = System.Drawing.Color.Black;
            this.btnRegistrarReflorestamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegistrarReflorestamento.FlatAppearance.BorderSize = 0;
            this.btnRegistrarReflorestamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarReflorestamento.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarReflorestamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrarReflorestamento.Image = global::SAReflorestamento.Properties.Resources.notes;
            this.btnRegistrarReflorestamento.Location = new System.Drawing.Point(28, 206);
            this.btnRegistrarReflorestamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrarReflorestamento.Name = "btnRegistrarReflorestamento";
            this.btnRegistrarReflorestamento.Size = new System.Drawing.Size(207, 63);
            this.btnRegistrarReflorestamento.TabIndex = 8;
            this.btnRegistrarReflorestamento.Text = "Registrar Desmatamento";
            this.btnRegistrarReflorestamento.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRegistrarReflorestamento.UseVisualStyleBackColor = false;
            this.btnRegistrarReflorestamento.Click += new System.EventHandler(this.btnRegistrarReflorestamento_Click);
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
            // userCRegistrarReflorest1
            // 
            this.userCRegistrarReflorest1.Location = new System.Drawing.Point(261, 38);
            this.userCRegistrarReflorest1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userCRegistrarReflorest1.Name = "userCRegistrarReflorest1";
            this.userCRegistrarReflorest1.Size = new System.Drawing.Size(741, 613);
            this.userCRegistrarReflorest1.TabIndex = 21;
            // 
            // flpLogo
            // 
            this.flpLogo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flpLogo.BackgroundImage = global::SAReflorestamento.Properties.Resources.ecology5;
            this.flpLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flpLogo.Location = new System.Drawing.Point(0, 38);
            this.flpLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpLogo.Name = "flpLogo";
            this.flpLogo.Size = new System.Drawing.Size(263, 110);
            this.flpLogo.TabIndex = 15;
            this.flpLogo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.flpLogo_MouseClick);
            // 
            // userCTelaDeAssist1
            // 
            this.userCTelaDeAssist1.Location = new System.Drawing.Point(261, 38);
            this.userCTelaDeAssist1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userCTelaDeAssist1.Name = "userCTelaDeAssist1";
            this.userCTelaDeAssist1.Size = new System.Drawing.Size(740, 613);
            this.userCTelaDeAssist1.TabIndex = 22;
            this.userCTelaDeAssist1.Load += new System.EventHandler(this.userCTelaDeAssist1_Load);
            // 
            // frmTelaDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1000, 652);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.userCTelaDeAssist1);
            this.Controls.Add(this.userCRegistrarReflorest1);
            this.Controls.Add(this.pnlTelaAdm);
            this.Controls.Add(this.flpLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTelaDeUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTelaDeUsuario";
            this.Load += new System.EventHandler(this.frmTelaDeUsuario_Load);
            this.panel3.ResumeLayout(false);
            this.pnlTelaAdm.ResumeLayout(false);
            this.pnlTelaAdm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Panel pnlTelaAdm;
        private System.Windows.Forms.Button btnRegistrarReflorestamento;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.FlowLayoutPanel flpLogo;
        private UserCRegistrarDesmatamento userCRegistrarReflorest1;
        private UserCTelaDeAssist userCTelaDeAssist1;
    }
}