namespace CondoFrame
{
    partial class frmReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReserva));
            this.txtPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpReserva = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProx = new System.Windows.Forms.Button();
            this.btnAnt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAlt = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgv_reserva = new System.Windows.Forms.DataGridView();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtLocal = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRgPort = new System.Windows.Forms.Label();
            this.lblNomePort = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reserva)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(399, 361);
            this.txtPesquisa.Mask = "000\\.000\\.000-00";
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(154, 22);
            this.txtPesquisa.TabIndex = 40;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Pesquisar pro CPF:";
            // 
            // dtpReserva
            // 
            this.dtpReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReserva.Location = new System.Drawing.Point(26, 239);
            this.dtpReserva.Margin = new System.Windows.Forms.Padding(4);
            this.dtpReserva.Name = "dtpReserva";
            this.dtpReserva.Size = new System.Drawing.Size(129, 22);
            this.dtpReserva.TabIndex = 38;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProx);
            this.groupBox2.Controls.Add(this.btnAnt);
            this.groupBox2.Location = new System.Drawing.Point(578, 398);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(284, 66);
            this.groupBox2.TabIndex = 36;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAlt);
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.btnIncluir);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Location = new System.Drawing.Point(8, 398);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(545, 66);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ações";
            // 
            // btnAlt
            // 
            this.btnAlt.Location = new System.Drawing.Point(278, 22);
            this.btnAlt.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(125, 38);
            this.btnAlt.TabIndex = 17;
            this.btnAlt.Text = "Alterar Registro";
            this.btnAlt.UseVisualStyleBackColor = true;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(17, 22);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(124, 38);
            this.btnNovo.TabIndex = 14;
            this.btnNovo.Text = "Novo Registro";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(149, 22);
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
            this.btnExcluir.Location = new System.Drawing.Point(411, 22);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(125, 38);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir Registro";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgv_reserva
            // 
            this.dgv_reserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reserva.Location = new System.Drawing.Point(262, 31);
            this.dgv_reserva.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_reserva.Name = "dgv_reserva";
            this.dgv_reserva.RowHeadersWidth = 51;
            this.dgv_reserva.Size = new System.Drawing.Size(600, 322);
            this.dgv_reserva.TabIndex = 34;
            this.dgv_reserva.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgv_reserva_KeyUp);
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(25, 59);
            this.mskCPF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskCPF.Mask = "000\\.000\\.000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(123, 22);
            this.mskCPF.TabIndex = 32;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(25, 299);
            this.txtLocal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(184, 22);
            this.txtLocal.TabIndex = 31;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(25, 114);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(220, 22);
            this.txtNome.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Data da Reserva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Horário Marcado (horas e minutos)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "CPF";
            // 
            // lblRgPort
            // 
            this.lblRgPort.AutoSize = true;
            this.lblRgPort.Location = new System.Drawing.Point(23, 278);
            this.lblRgPort.Name = "lblRgPort";
            this.lblRgPort.Size = new System.Drawing.Size(119, 17);
            this.lblRgPort.TabIndex = 26;
            this.lblRgPort.Text = "Local da Reserva";
            // 
            // lblNomePort
            // 
            this.lblNomePort.AutoSize = true;
            this.lblNomePort.Location = new System.Drawing.Point(23, 94);
            this.lblNomePort.Name = "lblNomePort";
            this.lblNomePort.Size = new System.Drawing.Size(140, 17);
            this.lblNomePort.TabIndex = 25;
            this.lblNomePort.Text = "Nome do Condômino";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(26, 176);
            this.txtHora.Mask = "00:00";
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(77, 22);
            this.txtHora.TabIndex = 41;
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 477);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpReserva);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_reserva);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRgPort);
            this.Controls.Add(this.lblNomePort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReserva";
            this.Text = "Agendar Reservas";
            this.Load += new System.EventHandler(this.frmReserva_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpReserva;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProx;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgv_reserva;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.MaskedTextBox txtLocal;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRgPort;
        private System.Windows.Forms.Label lblNomePort;
        private System.Windows.Forms.MaskedTextBox txtHora;
    }
}