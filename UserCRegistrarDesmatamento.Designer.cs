namespace SAReflorestamento
{
    partial class UserCRegistrarDesmatamento
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCRegistrarDesmatamento));
            this.txtVolumeArvores = new System.Windows.Forms.TextBox();
            this.txtArvoresCortadas = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblVolumeArvores = new System.Windows.Forms.Label();
            this.lblArvoresCortadas = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.dgvDesmatamento = new System.Windows.Forms.DataGridView();
            this.btnExcluirDesmatamento = new System.Windows.Forms.Button();
            this.btnEditarDesmatamento = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesmatamento)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVolumeArvores
            // 
            this.txtVolumeArvores.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolumeArvores.Location = new System.Drawing.Point(294, 192);
            this.txtVolumeArvores.Margin = new System.Windows.Forms.Padding(2);
            this.txtVolumeArvores.Name = "txtVolumeArvores";
            this.txtVolumeArvores.Size = new System.Drawing.Size(105, 23);
            this.txtVolumeArvores.TabIndex = 4;
            this.txtVolumeArvores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVolumeArvores_KeyPress);
            // 
            // txtArvoresCortadas
            // 
            this.txtArvoresCortadas.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArvoresCortadas.Location = new System.Drawing.Point(294, 147);
            this.txtArvoresCortadas.Margin = new System.Windows.Forms.Padding(2);
            this.txtArvoresCortadas.Name = "txtArvoresCortadas";
            this.txtArvoresCortadas.Size = new System.Drawing.Size(105, 23);
            this.txtArvoresCortadas.TabIndex = 3;
            this.txtArvoresCortadas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArvoresCortadas_KeyPress);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.Black;
            this.lblData.Location = new System.Drawing.Point(187, 56);
            this.lblData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(42, 20);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Ano: ";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(179, 100);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado: ";
            // 
            // lblVolumeArvores
            // 
            this.lblVolumeArvores.AutoSize = true;
            this.lblVolumeArvores.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumeArvores.ForeColor = System.Drawing.Color.Black;
            this.lblVolumeArvores.Location = new System.Drawing.Point(177, 190);
            this.lblVolumeArvores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVolumeArvores.Name = "lblVolumeArvores";
            this.lblVolumeArvores.Size = new System.Drawing.Size(65, 20);
            this.lblVolumeArvores.TabIndex = 7;
            this.lblVolumeArvores.Text = "Volume³:";
            // 
            // lblArvoresCortadas
            // 
            this.lblArvoresCortadas.AutoSize = true;
            this.lblArvoresCortadas.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArvoresCortadas.ForeColor = System.Drawing.Color.Black;
            this.lblArvoresCortadas.Location = new System.Drawing.Point(155, 145);
            this.lblArvoresCortadas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArvoresCortadas.Name = "lblArvoresCortadas";
            this.lblArvoresCortadas.Size = new System.Drawing.Size(122, 20);
            this.lblArvoresCortadas.TabIndex = 6;
            this.lblArvoresCortadas.Text = "Árvores cortadas :";
            // 
            // txtAno
            // 
            this.txtAno.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.Location = new System.Drawing.Point(294, 59);
            this.txtAno.Margin = new System.Windows.Forms.Padding(2);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(105, 23);
            this.txtAno.TabIndex = 1;
            this.txtAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAno_KeyPress);
            // 
            // dgvDesmatamento
            // 
            this.dgvDesmatamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesmatamento.Location = new System.Drawing.Point(54, 262);
            this.dgvDesmatamento.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDesmatamento.Name = "dgvDesmatamento";
            this.dgvDesmatamento.RowTemplate.Height = 24;
            this.dgvDesmatamento.Size = new System.Drawing.Size(458, 100);
            this.dgvDesmatamento.TabIndex = 5;
            this.dgvDesmatamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDesmatamento_CellClick);
            // 
            // btnExcluirDesmatamento
            // 
            this.btnExcluirDesmatamento.BackColor = System.Drawing.Color.LightGray;
            this.btnExcluirDesmatamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluirDesmatamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirDesmatamento.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirDesmatamento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluirDesmatamento.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirDesmatamento.Image")));
            this.btnExcluirDesmatamento.Location = new System.Drawing.Point(294, 417);
            this.btnExcluirDesmatamento.Name = "btnExcluirDesmatamento";
            this.btnExcluirDesmatamento.Size = new System.Drawing.Size(136, 51);
            this.btnExcluirDesmatamento.TabIndex = 8;
            this.btnExcluirDesmatamento.Text = "Excluir Desmatamento";
            this.btnExcluirDesmatamento.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExcluirDesmatamento.UseVisualStyleBackColor = false;
            this.btnExcluirDesmatamento.Click += new System.EventHandler(this.btnExcluirDesmatamento_Click);
            // 
            // btnEditarDesmatamento
            // 
            this.btnEditarDesmatamento.BackColor = System.Drawing.Color.LightGray;
            this.btnEditarDesmatamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditarDesmatamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarDesmatamento.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDesmatamento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditarDesmatamento.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarDesmatamento.Image")));
            this.btnEditarDesmatamento.Location = new System.Drawing.Point(147, 417);
            this.btnEditarDesmatamento.Name = "btnEditarDesmatamento";
            this.btnEditarDesmatamento.Size = new System.Drawing.Size(141, 51);
            this.btnEditarDesmatamento.TabIndex = 7;
            this.btnEditarDesmatamento.Text = "Editar Desmatamento";
            this.btnEditarDesmatamento.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditarDesmatamento.UseVisualStyleBackColor = false;
            this.btnEditarDesmatamento.Click += new System.EventHandler(this.btnEditarDesmatamento_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LightGray;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(15, 417);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(126, 51);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cboEstado
            // 
            this.cboEstado.Font = new System.Drawing.Font("Arial", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Gosso Do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cboEstado.Location = new System.Drawing.Point(294, 103);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(105, 24);
            this.cboEstado.TabIndex = 2;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            this.cboEstado.Leave += new System.EventHandler(this.cboEstado_Leave);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAtualizar.Location = new System.Drawing.Point(437, 367);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 27;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.LightGray;
            this.btnValidar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnValidar.Image = ((System.Drawing.Image)(resources.GetObject("btnValidar.Image")));
            this.btnValidar.Location = new System.Drawing.Point(436, 417);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(114, 51);
            this.btnValidar.TabIndex = 44;
            this.btnValidar.Text = "Validar";
            this.btnValidar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // UserCRegistrarDesmatamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluirDesmatamento);
            this.Controls.Add(this.btnEditarDesmatamento);
            this.Controls.Add(this.dgvDesmatamento);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblVolumeArvores);
            this.Controls.Add(this.lblArvoresCortadas);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtArvoresCortadas);
            this.Controls.Add(this.txtVolumeArvores);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserCRegistrarDesmatamento";
            this.Size = new System.Drawing.Size(562, 498);
            this.Load += new System.EventHandler(this.UserCRegistrarReflorest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesmatamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtVolumeArvores;
        private System.Windows.Forms.TextBox txtArvoresCortadas;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblVolumeArvores;
        private System.Windows.Forms.Label lblArvoresCortadas;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.DataGridView dgvDesmatamento;
        private System.Windows.Forms.Button btnExcluirDesmatamento;
        private System.Windows.Forms.Button btnEditarDesmatamento;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnValidar;
    }
}
