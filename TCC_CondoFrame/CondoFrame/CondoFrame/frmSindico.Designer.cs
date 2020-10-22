namespace CondoFrame
{
    partial class frmSindico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSindico));
            this.lblCodSind = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblInicioMand = new System.Windows.Forms.Label();
            this.lblFimMand = new System.Windows.Forms.Label();
            this.lblEleicao = new System.Windows.Forms.Label();
            this.lblCodSin = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.dgv_sindico = new System.Windows.Forms.DataGridView();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.dtpEleicao = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNovoRegistro = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProx = new System.Windows.Forms.Button();
            this.btnAnt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sindico)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodSind
            // 
            this.lblCodSind.AutoSize = true;
            this.lblCodSind.Location = new System.Drawing.Point(29, 37);
            this.lblCodSind.Name = "lblCodSind";
            this.lblCodSind.Size = new System.Drawing.Size(126, 17);
            this.lblCodSind.TabIndex = 0;
            this.lblCodSind.Text = "Código do Sindico:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(29, 70);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(38, 17);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF:";
            // 
            // lblInicioMand
            // 
            this.lblInicioMand.AutoSize = true;
            this.lblInicioMand.Location = new System.Drawing.Point(29, 126);
            this.lblInicioMand.Name = "lblInicioMand";
            this.lblInicioMand.Size = new System.Drawing.Size(177, 17);
            this.lblInicioMand.TabIndex = 2;
            this.lblInicioMand.Text = "Data de Inicio do Mandato:";
            // 
            // lblFimMand
            // 
            this.lblFimMand.AutoSize = true;
            this.lblFimMand.Location = new System.Drawing.Point(29, 185);
            this.lblFimMand.Name = "lblFimMand";
            this.lblFimMand.Size = new System.Drawing.Size(167, 17);
            this.lblFimMand.TabIndex = 3;
            this.lblFimMand.Text = "Data do Fim do Mandato:";
            // 
            // lblEleicao
            // 
            this.lblEleicao.AutoSize = true;
            this.lblEleicao.Location = new System.Drawing.Point(32, 244);
            this.lblEleicao.Name = "lblEleicao";
            this.lblEleicao.Size = new System.Drawing.Size(112, 17);
            this.lblEleicao.TabIndex = 4;
            this.lblEleicao.Text = "Data da Eleição:";
            // 
            // lblCodSin
            // 
            this.lblCodSin.AutoSize = true;
            this.lblCodSin.Location = new System.Drawing.Point(163, 37);
            this.lblCodSin.Name = "lblCodSin";
            this.lblCodSin.Size = new System.Drawing.Size(127, 17);
            this.lblCodSin.TabIndex = 5;
            this.lblCodSin.Text = "Exemplo de código";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(32, 90);
            this.mskCPF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskCPF.Mask = "000\\.000\\.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(120, 22);
            this.mskCPF.TabIndex = 1;
            // 
            // dgv_sindico
            // 
            this.dgv_sindico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sindico.Location = new System.Drawing.Point(299, 37);
            this.dgv_sindico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_sindico.Name = "dgv_sindico";
            this.dgv_sindico.RowHeadersWidth = 51;
            this.dgv_sindico.Size = new System.Drawing.Size(488, 252);
            this.dgv_sindico.TabIndex = 6;
            this.dgv_sindico.Click += new System.EventHandler(this.dgv_sindico_Click);
            this.dgv_sindico.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgv_sindico_KeyUp);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(32, 144);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(129, 22);
            this.dtpInicio.TabIndex = 22;
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(32, 203);
            this.dtpFim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(129, 22);
            this.dtpFim.TabIndex = 23;
            // 
            // dtpEleicao
            // 
            this.dtpEleicao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEleicao.Location = new System.Drawing.Point(32, 265);
            this.dtpEleicao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEleicao.Name = "dtpEleicao";
            this.dtpEleicao.Size = new System.Drawing.Size(129, 22);
            this.dtpEleicao.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNovoRegistro);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnIncluir);
            this.groupBox1.Location = new System.Drawing.Point(32, 334);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(417, 78);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ações";
            // 
            // btnNovoRegistro
            // 
            this.btnNovoRegistro.Location = new System.Drawing.Point(7, 22);
            this.btnNovoRegistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNovoRegistro.Name = "btnNovoRegistro";
            this.btnNovoRegistro.Size = new System.Drawing.Size(124, 38);
            this.btnNovoRegistro.TabIndex = 14;
            this.btnNovoRegistro.Text = "Novo Registro";
            this.btnNovoRegistro.UseVisualStyleBackColor = true;
            this.btnNovoRegistro.Click += new System.EventHandler(this.btnNovoRegistro_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(268, 22);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(125, 38);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir Registro";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(139, 22);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(121, 38);
            this.btnIncluir.TabIndex = 16;
            this.btnIncluir.Text = "Incluir Registros";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProx);
            this.groupBox2.Controls.Add(this.btnAnt);
            this.groupBox2.Location = new System.Drawing.Point(503, 334);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(284, 78);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Navegação";
            // 
            // btnProx
            // 
            this.btnProx.Location = new System.Drawing.Point(5, 22);
            this.btnProx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProx.Name = "btnProx";
            this.btnProx.Size = new System.Drawing.Size(125, 38);
            this.btnProx.TabIndex = 15;
            this.btnProx.Text = "Próximo";
            this.btnProx.UseVisualStyleBackColor = true;
            this.btnProx.Click += new System.EventHandler(this.btnProx_Click);
            // 
            // btnAnt
            // 
            this.btnAnt.Location = new System.Drawing.Point(152, 22);
            this.btnAnt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(125, 38);
            this.btnAnt.TabIndex = 17;
            this.btnAnt.Text = "Anterior";
            this.btnAnt.UseVisualStyleBackColor = true;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // frmSindico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 431);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtpEleicao);
            this.Controls.Add(this.dtpFim);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.dgv_sindico);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.lblCodSin);
            this.Controls.Add(this.lblEleicao);
            this.Controls.Add(this.lblFimMand);
            this.Controls.Add(this.lblInicioMand);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblCodSind);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSindico";
            this.Text = "Cadastro de Sindico";
            this.Load += new System.EventHandler(this.frmSindico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sindico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodSind;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblInicioMand;
        private System.Windows.Forms.Label lblFimMand;
        private System.Windows.Forms.Label lblEleicao;
        private System.Windows.Forms.Label lblCodSin;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.DataGridView dgv_sindico;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DateTimePicker dtpEleicao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNovoRegistro;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProx;
        private System.Windows.Forms.Button btnAnt;
    }
}