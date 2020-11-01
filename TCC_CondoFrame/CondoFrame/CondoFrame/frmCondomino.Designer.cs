namespace CondoFrame
{
    partial class frmCondomino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCondomino));
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNomeCond = new System.Windows.Forms.Label();
            this.lblNumApt = new System.Windows.Forms.Label();
            this.lblTelCond = new System.Windows.Forms.Label();
            this.lblEmailCond = new System.Windows.Forms.Label();
            this.lblDataEnt = new System.Windows.Forms.Label();
            this.lblDataSaida = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeCond = new System.Windows.Forms.TextBox();
            this.mskNumApt = new System.Windows.Forms.MaskedTextBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.mskEmailCond = new System.Windows.Forms.MaskedTextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.dgv_condomino = new System.Windows.Forms.DataGridView();
            this.dtpentrada = new System.Windows.Forms.DateTimePicker();
            this.dtpsaida = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProx = new System.Windows.Forms.Button();
            this.btnAnt = new System.Windows.Forms.Button();
            this.btnNovoRegistro = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAlt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_condomino)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(32, 33);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(129, 17);
            this.lblCPF.TabIndex = 0;
            this.lblCPF.Text = "CPF do Condômino";
            // 
            // lblNomeCond
            // 
            this.lblNomeCond.AutoSize = true;
            this.lblNomeCond.Location = new System.Drawing.Point(32, 86);
            this.lblNomeCond.Name = "lblNomeCond";
            this.lblNomeCond.Size = new System.Drawing.Size(45, 17);
            this.lblNomeCond.TabIndex = 1;
            this.lblNomeCond.Text = "Nome";
            // 
            // lblNumApt
            // 
            this.lblNumApt.AutoSize = true;
            this.lblNumApt.Location = new System.Drawing.Point(32, 140);
            this.lblNumApt.Name = "lblNumApt";
            this.lblNumApt.Size = new System.Drawing.Size(162, 17);
            this.lblNumApt.TabIndex = 2;
            this.lblNumApt.Text = "Número do apartamento";
            // 
            // lblTelCond
            // 
            this.lblTelCond.AutoSize = true;
            this.lblTelCond.Location = new System.Drawing.Point(32, 194);
            this.lblTelCond.Name = "lblTelCond";
            this.lblTelCond.Size = new System.Drawing.Size(64, 17);
            this.lblTelCond.TabIndex = 3;
            this.lblTelCond.Text = "Telefone";
            // 
            // lblEmailCond
            // 
            this.lblEmailCond.AutoSize = true;
            this.lblEmailCond.Location = new System.Drawing.Point(32, 247);
            this.lblEmailCond.Name = "lblEmailCond";
            this.lblEmailCond.Size = new System.Drawing.Size(47, 17);
            this.lblEmailCond.TabIndex = 4;
            this.lblEmailCond.Text = "E-mail";
            // 
            // lblDataEnt
            // 
            this.lblDataEnt.AutoSize = true;
            this.lblDataEnt.Location = new System.Drawing.Point(32, 302);
            this.lblDataEnt.Name = "lblDataEnt";
            this.lblDataEnt.Size = new System.Drawing.Size(112, 17);
            this.lblDataEnt.TabIndex = 5;
            this.lblDataEnt.Text = "Data de Entrada";
            // 
            // lblDataSaida
            // 
            this.lblDataSaida.AutoSize = true;
            this.lblDataSaida.Location = new System.Drawing.Point(32, 357);
            this.lblDataSaida.Name = "lblDataSaida";
            this.lblDataSaida.Size = new System.Drawing.Size(98, 17);
            this.lblDataSaida.TabIndex = 6;
            this.lblDataSaida.Text = "Data de Saída";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(32, 414);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(35, 53);
            this.mskCPF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskCPF.Mask = "000\\.000\\.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(127, 22);
            this.mskCPF.TabIndex = 8;
            // 
            // txtNomeCond
            // 
            this.txtNomeCond.Location = new System.Drawing.Point(35, 107);
            this.txtNomeCond.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeCond.Name = "txtNomeCond";
            this.txtNomeCond.Size = new System.Drawing.Size(283, 22);
            this.txtNomeCond.TabIndex = 9;
            // 
            // mskNumApt
            // 
            this.mskNumApt.Location = new System.Drawing.Point(35, 161);
            this.mskNumApt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskNumApt.Mask = "00";
            this.mskNumApt.Name = "mskNumApt";
            this.mskNumApt.Size = new System.Drawing.Size(45, 22);
            this.mskNumApt.TabIndex = 10;
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(35, 215);
            this.mskTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskTel.Mask = "(99) 9900-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(127, 22);
            this.mskTel.TabIndex = 11;
            // 
            // mskEmailCond
            // 
            this.mskEmailCond.Location = new System.Drawing.Point(36, 268);
            this.mskEmailCond.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskEmailCond.Name = "mskEmailCond";
            this.mskEmailCond.Size = new System.Drawing.Size(188, 22);
            this.mskEmailCond.TabIndex = 12;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(35, 434);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(188, 22);
            this.txtStatus.TabIndex = 15;
            // 
            // dgv_condomino
            // 
            this.dgv_condomino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_condomino.Location = new System.Drawing.Point(339, 33);
            this.dgv_condomino.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_condomino.Name = "dgv_condomino";
            this.dgv_condomino.RowHeadersWidth = 51;
            this.dgv_condomino.Size = new System.Drawing.Size(509, 426);
            this.dgv_condomino.TabIndex = 16;
            // 
            // dtpentrada
            // 
            this.dtpentrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpentrada.Location = new System.Drawing.Point(35, 321);
            this.dtpentrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpentrada.Name = "dtpentrada";
            this.dtpentrada.Size = new System.Drawing.Size(129, 22);
            this.dtpentrada.TabIndex = 21;
            // 
            // dtpsaida
            // 
            this.dtpsaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpsaida.Location = new System.Drawing.Point(36, 376);
            this.dtpsaida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpsaida.Name = "dtpsaida";
            this.dtpsaida.Size = new System.Drawing.Size(129, 22);
            this.dtpsaida.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProx);
            this.groupBox2.Controls.Add(this.btnAnt);
            this.groupBox2.Location = new System.Drawing.Point(564, 530);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(284, 66);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Navegação";
            // 
            // btnProx
            // 
            this.btnProx.Location = new System.Drawing.Point(5, 22);
            this.btnProx.Margin = new System.Windows.Forms.Padding(4);
            this.btnProx.Name = "btnProx";
            this.btnProx.Size = new System.Drawing.Size(125, 38);
            this.btnProx.TabIndex = 15;
            this.btnProx.Text = "Próximo";
            this.btnProx.UseVisualStyleBackColor = true;
            this.btnProx.Click += new System.EventHandler(this.btnProx_Click);
            // 
            // btnAnt
            // 
            this.btnAnt.Location = new System.Drawing.Point(139, 22);
            this.btnAnt.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(125, 38);
            this.btnAnt.TabIndex = 17;
            this.btnAnt.Text = "Anterior";
            this.btnAnt.UseVisualStyleBackColor = true;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // btnNovoRegistro
            // 
            this.btnNovoRegistro.Location = new System.Drawing.Point(7, 22);
            this.btnNovoRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovoRegistro.Name = "btnNovoRegistro";
            this.btnNovoRegistro.Size = new System.Drawing.Size(124, 38);
            this.btnNovoRegistro.TabIndex = 14;
            this.btnNovoRegistro.Text = "Novo Registro";
            this.btnNovoRegistro.UseVisualStyleBackColor = true;
            this.btnNovoRegistro.Click += new System.EventHandler(this.btnNovoRegistro_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(139, 22);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(121, 38);
            this.btnIncluir.TabIndex = 16;
            this.btnIncluir.Text = "Incluir Registros";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(403, 22);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(125, 38);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir Registro";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAlt);
            this.groupBox1.Controls.Add(this.btnNovoRegistro);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnIncluir);
            this.groupBox1.Location = new System.Drawing.Point(22, 530);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(536, 66);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ações";
            // 
            // btnAlt
            // 
            this.btnAlt.Location = new System.Drawing.Point(266, 22);
            this.btnAlt.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(129, 38);
            this.btnAlt.TabIndex = 17;
            this.btnAlt.Text = "Alterar Registro";
            this.btnAlt.UseVisualStyleBackColor = true;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Pesquisar por CPF:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(475, 477);
            this.txtPesquisa.Mask = "000\\.000\\.000-00";
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(138, 22);
            this.txtPesquisa.TabIndex = 27;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // frmCondomino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 622);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtpsaida);
            this.Controls.Add(this.dtpentrada);
            this.Controls.Add(this.dgv_condomino);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.mskEmailCond);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.mskNumApt);
            this.Controls.Add(this.txtNomeCond);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDataSaida);
            this.Controls.Add(this.lblDataEnt);
            this.Controls.Add(this.lblEmailCond);
            this.Controls.Add(this.lblTelCond);
            this.Controls.Add(this.lblNumApt);
            this.Controls.Add(this.lblNomeCond);
            this.Controls.Add(this.lblCPF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCondomino";
            this.Text = "Cadastro de Condômino";
            this.Load += new System.EventHandler(this.frmCondomino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_condomino)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNomeCond;
        private System.Windows.Forms.Label lblNumApt;
        private System.Windows.Forms.Label lblTelCond;
        private System.Windows.Forms.Label lblEmailCond;
        private System.Windows.Forms.Label lblDataEnt;
        private System.Windows.Forms.Label lblDataSaida;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.TextBox txtNomeCond;
        private System.Windows.Forms.MaskedTextBox mskNumApt;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.MaskedTextBox mskEmailCond;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.DataGridView dgv_condomino;
        private System.Windows.Forms.DateTimePicker dtpentrada;
        private System.Windows.Forms.DateTimePicker dtpsaida;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProx;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.Button btnNovoRegistro;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtPesquisa;
    }
}