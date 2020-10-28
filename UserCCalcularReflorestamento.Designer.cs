namespace SAReflorestamento
{
    partial class UserCCalcularReflorestamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCCalcularReflorestamento));
            this.dgvDesmatamento = new System.Windows.Forms.DataGridView();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.lblVolumeArvores = new System.Windows.Forms.Label();
            this.lblArvoresCortadas = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtArvoresCortadas = new System.Windows.Forms.TextBox();
            this.txtVolumeArvores = new System.Windows.Forms.TextBox();
            this.btnIndTotalPagar = new System.Windows.Forms.Button();
            this.btnIndReposicao = new System.Windows.Forms.Button();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.lblArvoresRepor = new System.Windows.Forms.Label();
            this.txtArvoresRepor = new System.Windows.Forms.TextBox();
            this.txtValorPagar = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesmatamento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDesmatamento
            // 
            this.dgvDesmatamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesmatamento.Location = new System.Drawing.Point(21, 26);
            this.dgvDesmatamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDesmatamento.Name = "dgvDesmatamento";
            this.dgvDesmatamento.RowTemplate.Height = 24;
            this.dgvDesmatamento.Size = new System.Drawing.Size(712, 119);
            this.dgvDesmatamento.TabIndex = 18;
            this.dgvDesmatamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDesmatamento_CellClick);
            // 
            // txtAno
            // 
            this.txtAno.Enabled = false;
            this.txtAno.Location = new System.Drawing.Point(224, 235);
            this.txtAno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(139, 22);
            this.txtAno.TabIndex = 17;
            this.txtAno.TextChanged += new System.EventHandler(this.txtAno_TextChanged);
            this.txtAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAno_KeyPress);
            // 
            // lblVolumeArvores
            // 
            this.lblVolumeArvores.AutoSize = true;
            this.lblVolumeArvores.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumeArvores.ForeColor = System.Drawing.Color.Black;
            this.lblVolumeArvores.Location = new System.Drawing.Point(69, 396);
            this.lblVolumeArvores.Name = "lblVolumeArvores";
            this.lblVolumeArvores.Size = new System.Drawing.Size(77, 23);
            this.lblVolumeArvores.TabIndex = 16;
            this.lblVolumeArvores.Text = "Volume³:";
            // 
            // lblArvoresCortadas
            // 
            this.lblArvoresCortadas.AutoSize = true;
            this.lblArvoresCortadas.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArvoresCortadas.ForeColor = System.Drawing.Color.Black;
            this.lblArvoresCortadas.Location = new System.Drawing.Point(39, 341);
            this.lblArvoresCortadas.Name = "lblArvoresCortadas";
            this.lblArvoresCortadas.Size = new System.Drawing.Size(150, 23);
            this.lblArvoresCortadas.TabIndex = 15;
            this.lblArvoresCortadas.Text = "Árvores cortadas :";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(71, 286);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(72, 23);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado: ";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.Black;
            this.lblData.Location = new System.Drawing.Point(80, 233);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(50, 23);
            this.lblData.TabIndex = 13;
            this.lblData.Text = "Ano: ";
            // 
            // txtArvoresCortadas
            // 
            this.txtArvoresCortadas.Enabled = false;
            this.txtArvoresCortadas.Location = new System.Drawing.Point(224, 345);
            this.txtArvoresCortadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArvoresCortadas.Name = "txtArvoresCortadas";
            this.txtArvoresCortadas.Size = new System.Drawing.Size(139, 22);
            this.txtArvoresCortadas.TabIndex = 12;
            this.txtArvoresCortadas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArvoresCortadas_KeyPress);
            // 
            // txtVolumeArvores
            // 
            this.txtVolumeArvores.Enabled = false;
            this.txtVolumeArvores.Location = new System.Drawing.Point(224, 399);
            this.txtVolumeArvores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVolumeArvores.Name = "txtVolumeArvores";
            this.txtVolumeArvores.Size = new System.Drawing.Size(139, 22);
            this.txtVolumeArvores.TabIndex = 11;
            this.txtVolumeArvores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVolumeArvores_KeyPress);
            // 
            // btnIndTotalPagar
            // 
            this.btnIndTotalPagar.BackColor = System.Drawing.Color.LightGray;
            this.btnIndTotalPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndTotalPagar.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndTotalPagar.ForeColor = System.Drawing.Color.Black;
            this.btnIndTotalPagar.Image = global::SAReflorestamento.Properties.Resources.money;
            this.btnIndTotalPagar.Location = new System.Drawing.Point(137, 537);
            this.btnIndTotalPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIndTotalPagar.Name = "btnIndTotalPagar";
            this.btnIndTotalPagar.Size = new System.Drawing.Size(209, 63);
            this.btnIndTotalPagar.TabIndex = 20;
            this.btnIndTotalPagar.Text = "Total a pagar";
            this.btnIndTotalPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnIndTotalPagar.UseVisualStyleBackColor = false;
            this.btnIndTotalPagar.Click += new System.EventHandler(this.btnIndTotalPagar_Click);
            // 
            // btnIndReposicao
            // 
            this.btnIndReposicao.BackColor = System.Drawing.Color.LightGray;
            this.btnIndReposicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndReposicao.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndReposicao.ForeColor = System.Drawing.Color.Black;
            this.btnIndReposicao.Image = ((System.Drawing.Image)(resources.GetObject("btnIndReposicao.Image")));
            this.btnIndReposicao.Location = new System.Drawing.Point(395, 537);
            this.btnIndReposicao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIndReposicao.Name = "btnIndReposicao";
            this.btnIndReposicao.Size = new System.Drawing.Size(209, 63);
            this.btnIndReposicao.TabIndex = 19;
            this.btnIndReposicao.Text = "Reposição de árvores";
            this.btnIndReposicao.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnIndReposicao.UseVisualStyleBackColor = false;
            this.btnIndReposicao.Click += new System.EventHandler(this.btnIndReposicao_Click);
            // 
            // cboEstado
            // 
            this.cboEstado.Enabled = false;
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
            this.cboEstado.Location = new System.Drawing.Point(224, 286);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(139, 26);
            this.cboEstado.TabIndex = 21;
            this.cboEstado.Leave += new System.EventHandler(this.cboEstado_Leave);
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPagar.ForeColor = System.Drawing.Color.Black;
            this.lblValorPagar.Location = new System.Drawing.Point(412, 341);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(115, 23);
            this.lblValorPagar.TabIndex = 25;
            this.lblValorPagar.Text = "Valor a pagar:";
            // 
            // lblArvoresRepor
            // 
            this.lblArvoresRepor.AutoSize = true;
            this.lblArvoresRepor.Font = new System.Drawing.Font("Arial Narrow", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArvoresRepor.ForeColor = System.Drawing.Color.Black;
            this.lblArvoresRepor.Location = new System.Drawing.Point(389, 286);
            this.lblArvoresRepor.Name = "lblArvoresRepor";
            this.lblArvoresRepor.Size = new System.Drawing.Size(137, 23);
            this.lblArvoresRepor.TabIndex = 24;
            this.lblArvoresRepor.Text = "Árvores a repor :";
            // 
            // txtArvoresRepor
            // 
            this.txtArvoresRepor.Enabled = false;
            this.txtArvoresRepor.Location = new System.Drawing.Point(575, 289);
            this.txtArvoresRepor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArvoresRepor.Name = "txtArvoresRepor";
            this.txtArvoresRepor.Size = new System.Drawing.Size(139, 22);
            this.txtArvoresRepor.TabIndex = 23;
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.Enabled = false;
            this.txtValorPagar.Location = new System.Drawing.Point(575, 343);
            this.txtValorPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.Size = new System.Drawing.Size(139, 22);
            this.txtValorPagar.TabIndex = 22;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAtualizar.Location = new System.Drawing.Point(633, 151);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(100, 28);
            this.btnAtualizar.TabIndex = 26;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // UserCCalcularReflorestamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lblValorPagar);
            this.Controls.Add(this.lblArvoresRepor);
            this.Controls.Add(this.txtArvoresRepor);
            this.Controls.Add(this.txtValorPagar);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.btnIndTotalPagar);
            this.Controls.Add(this.btnIndReposicao);
            this.Controls.Add(this.dgvDesmatamento);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblVolumeArvores);
            this.Controls.Add(this.lblArvoresCortadas);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtArvoresCortadas);
            this.Controls.Add(this.txtVolumeArvores);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserCCalcularReflorestamento";
            this.Size = new System.Drawing.Size(749, 613);
            this.Load += new System.EventHandler(this.UserCCalcularReflorestamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesmatamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDesmatamento;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label lblVolumeArvores;
        private System.Windows.Forms.Label lblArvoresCortadas;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtArvoresCortadas;
        private System.Windows.Forms.TextBox txtVolumeArvores;
        private System.Windows.Forms.Button btnIndReposicao;
        private System.Windows.Forms.Button btnIndTotalPagar;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblValorPagar;
        private System.Windows.Forms.Label lblArvoresRepor;
        private System.Windows.Forms.TextBox txtArvoresRepor;
        private System.Windows.Forms.TextBox txtValorPagar;
        private System.Windows.Forms.Button btnAtualizar;
    }
}
