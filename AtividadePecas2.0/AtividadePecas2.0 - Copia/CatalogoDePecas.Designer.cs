namespace AtividadePecas2._0
{
    partial class CP
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbCarro = new System.Windows.Forms.GroupBox();
            this.btnAdicionarC = new System.Windows.Forms.Button();
            this.ndAno = new System.Windows.Forms.NumericUpDown();
            this.txtNomeC = new System.Windows.Forms.TextBox();
            this.txtMarcaC = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.gbPecas = new System.Windows.Forms.GroupBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAdicionarP = new System.Windows.Forms.Button();
            this.ndValor = new System.Windows.Forms.NumericUpDown();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.cbCarro = new System.Windows.Forms.ComboBox();
            this.txtNomeP = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtMarcaP = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblNomeP = new System.Windows.Forms.Label();
            this.lblCarroP = new System.Windows.Forms.Label();
            this.lblMarcaP = new System.Windows.Forms.Label();
            this.lvPecas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblPecas = new System.Windows.Forms.Label();
            this.gbCarro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndAno)).BeginInit();
            this.gbPecas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndValor)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCarro
            // 
            this.gbCarro.BackColor = System.Drawing.SystemColors.Control;
            this.gbCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbCarro.Controls.Add(this.btnAdicionarC);
            this.gbCarro.Controls.Add(this.ndAno);
            this.gbCarro.Controls.Add(this.txtNomeC);
            this.gbCarro.Controls.Add(this.txtMarcaC);
            this.gbCarro.Controls.Add(this.lblAno);
            this.gbCarro.Controls.Add(this.lblNome);
            this.gbCarro.Controls.Add(this.lblMarca);
            this.gbCarro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gbCarro.Location = new System.Drawing.Point(12, 21);
            this.gbCarro.Name = "gbCarro";
            this.gbCarro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbCarro.Size = new System.Drawing.Size(292, 115);
            this.gbCarro.TabIndex = 0;
            this.gbCarro.TabStop = false;
            this.gbCarro.Text = "Cadastro de Carro";
            // 
            // btnAdicionarC
            // 
            this.btnAdicionarC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarC.Location = new System.Drawing.Point(210, 34);
            this.btnAdicionarC.Name = "btnAdicionarC";
            this.btnAdicionarC.Size = new System.Drawing.Size(75, 44);
            this.btnAdicionarC.TabIndex = 6;
            this.btnAdicionarC.Text = "Adicionar";
            this.btnAdicionarC.UseVisualStyleBackColor = true;
            this.btnAdicionarC.Click += new System.EventHandler(this.btnAdicionarC_Click);
            // 
            // ndAno
            // 
            this.ndAno.Location = new System.Drawing.Point(48, 85);
            this.ndAno.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.ndAno.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.ndAno.Name = "ndAno";
            this.ndAno.Size = new System.Drawing.Size(70, 20);
            this.ndAno.TabIndex = 5;
            this.ndAno.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // txtNomeC
            // 
            this.txtNomeC.Location = new System.Drawing.Point(48, 58);
            this.txtNomeC.Name = "txtNomeC";
            this.txtNomeC.Size = new System.Drawing.Size(156, 20);
            this.txtNomeC.TabIndex = 4;
            // 
            // txtMarcaC
            // 
            this.txtMarcaC.Location = new System.Drawing.Point(48, 31);
            this.txtMarcaC.Name = "txtMarcaC";
            this.txtMarcaC.Size = new System.Drawing.Size(156, 20);
            this.txtMarcaC.TabIndex = 3;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(6, 87);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(29, 13);
            this.lblAno.TabIndex = 2;
            this.lblAno.Text = "Ano:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 61);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(6, 34);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca:";
            // 
            // gbPecas
            // 
            this.gbPecas.Controls.Add(this.btnDeletar);
            this.gbPecas.Controls.Add(this.btnAdicionarP);
            this.gbPecas.Controls.Add(this.ndValor);
            this.gbPecas.Controls.Add(this.txtModelo);
            this.gbPecas.Controls.Add(this.cbCarro);
            this.gbPecas.Controls.Add(this.txtNomeP);
            this.gbPecas.Controls.Add(this.lblModelo);
            this.gbPecas.Controls.Add(this.txtMarcaP);
            this.gbPecas.Controls.Add(this.lblValor);
            this.gbPecas.Controls.Add(this.lblNomeP);
            this.gbPecas.Controls.Add(this.lblCarroP);
            this.gbPecas.Controls.Add(this.lblMarcaP);
            this.gbPecas.Location = new System.Drawing.Point(369, 21);
            this.gbPecas.Name = "gbPecas";
            this.gbPecas.Size = new System.Drawing.Size(306, 172);
            this.gbPecas.TabIndex = 1;
            this.gbPecas.TabStop = false;
            this.gbPecas.Text = "Cadastro de Peças";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.Location = new System.Drawing.Point(225, 91);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 41);
            this.btnDeletar.TabIndex = 11;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAdicionarP
            // 
            this.btnAdicionarP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarP.Location = new System.Drawing.Point(225, 34);
            this.btnAdicionarP.Name = "btnAdicionarP";
            this.btnAdicionarP.Size = new System.Drawing.Size(75, 47);
            this.btnAdicionarP.TabIndex = 7;
            this.btnAdicionarP.Text = "Adicionar";
            this.btnAdicionarP.UseVisualStyleBackColor = true;
            this.btnAdicionarP.Click += new System.EventHandler(this.btnAdicionarP_Click);
            // 
            // ndValor
            // 
            this.ndValor.DecimalPlaces = 2;
            this.ndValor.Location = new System.Drawing.Point(57, 143);
            this.ndValor.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.ndValor.Name = "ndValor";
            this.ndValor.Size = new System.Drawing.Size(156, 20);
            this.ndValor.TabIndex = 6;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(57, 112);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(156, 20);
            this.txtModelo.TabIndex = 8;
            // 
            // cbCarro
            // 
            this.cbCarro.FormattingEnabled = true;
            this.cbCarro.Location = new System.Drawing.Point(57, 31);
            this.cbCarro.Name = "cbCarro";
            this.cbCarro.Size = new System.Drawing.Size(156, 21);
            this.cbCarro.TabIndex = 10;
            this.cbCarro.SelectedIndexChanged += new System.EventHandler(this.cbCarro_SelectedIndexChanged);
            // 
            // txtNomeP
            // 
            this.txtNomeP.Location = new System.Drawing.Point(57, 84);
            this.txtNomeP.Name = "txtNomeP";
            this.txtNomeP.Size = new System.Drawing.Size(156, 20);
            this.txtNomeP.TabIndex = 7;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(6, 115);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 9;
            this.lblModelo.Text = "Modelo:";
            // 
            // txtMarcaP
            // 
            this.txtMarcaP.Location = new System.Drawing.Point(57, 58);
            this.txtMarcaP.Name = "txtMarcaP";
            this.txtMarcaP.Size = new System.Drawing.Size(156, 20);
            this.txtMarcaP.TabIndex = 6;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(6, 145);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 7;
            this.lblValor.Text = "Valor";
            // 
            // lblNomeP
            // 
            this.lblNomeP.AutoSize = true;
            this.lblNomeP.Location = new System.Drawing.Point(6, 87);
            this.lblNomeP.Name = "lblNomeP";
            this.lblNomeP.Size = new System.Drawing.Size(38, 13);
            this.lblNomeP.TabIndex = 8;
            this.lblNomeP.Text = "Nome:";
            // 
            // lblCarroP
            // 
            this.lblCarroP.AutoSize = true;
            this.lblCarroP.Location = new System.Drawing.Point(6, 34);
            this.lblCarroP.Name = "lblCarroP";
            this.lblCarroP.Size = new System.Drawing.Size(35, 13);
            this.lblCarroP.TabIndex = 6;
            this.lblCarroP.Text = "Carro:";
            // 
            // lblMarcaP
            // 
            this.lblMarcaP.AutoSize = true;
            this.lblMarcaP.Location = new System.Drawing.Point(6, 61);
            this.lblMarcaP.Name = "lblMarcaP";
            this.lblMarcaP.Size = new System.Drawing.Size(40, 13);
            this.lblMarcaP.TabIndex = 7;
            this.lblMarcaP.Text = "Marca:";
            // 
            // lvPecas
            // 
            this.lvPecas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvPecas.GridLines = true;
            this.lvPecas.HideSelection = false;
            this.lvPecas.Location = new System.Drawing.Point(69, 225);
            this.lvPecas.Name = "lvPecas";
            this.lvPecas.Size = new System.Drawing.Size(525, 213);
            this.lvPecas.TabIndex = 0;
            this.lvPecas.UseCompatibleStateImageBehavior = false;
            this.lvPecas.View = System.Windows.Forms.View.Details;
            this.lvPecas.SelectedIndexChanged += new System.EventHandler(this.lvPecas_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Marca";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Modelo";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Valor";
            this.columnHeader4.Width = 130;
            // 
            // lblPecas
            // 
            this.lblPecas.AutoSize = true;
            this.lblPecas.Location = new System.Drawing.Point(66, 209);
            this.lblPecas.Name = "lblPecas";
            this.lblPecas.Size = new System.Drawing.Size(40, 13);
            this.lblPecas.TabIndex = 7;
            this.lblPecas.Text = "Peças:";
            // 
            // CP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.lblPecas);
            this.Controls.Add(this.lvPecas);
            this.Controls.Add(this.gbPecas);
            this.Controls.Add(this.gbCarro);
            this.Name = "CP";
            this.Text = "Catálogo de Peças";
            this.gbCarro.ResumeLayout(false);
            this.gbCarro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndAno)).EndInit();
            this.gbPecas.ResumeLayout(false);
            this.gbPecas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCarro;
        private System.Windows.Forms.NumericUpDown ndAno;
        private System.Windows.Forms.TextBox txtNomeC;
        private System.Windows.Forms.TextBox txtMarcaC;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.GroupBox gbPecas;
        private System.Windows.Forms.NumericUpDown ndValor;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.ComboBox cbCarro;
        private System.Windows.Forms.TextBox txtNomeP;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtMarcaP;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblNomeP;
        private System.Windows.Forms.Label lblCarroP;
        private System.Windows.Forms.Label lblMarcaP;
        private System.Windows.Forms.ListView lvPecas;
        private System.Windows.Forms.Button btnAdicionarC;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAdicionarP;
        private System.Windows.Forms.Label lblPecas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

