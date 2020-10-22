namespace CondoFrame
{
    partial class frmPorteiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPorteiro));
            this.lblCodPort = new System.Windows.Forms.Label();
            this.lblNomePort = new System.Windows.Forms.Label();
            this.lblRgPort = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamePort = new System.Windows.Forms.TextBox();
            this.mtxtRGPort = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCPFPort = new System.Windows.Forms.MaskedTextBox();
            this.lbl_codPORT = new System.Windows.Forms.Label();
            this.dgv_porteiro = new System.Windows.Forms.DataGridView();
            this.btnExcluirPort = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnIncluirPort = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpaddPORT = new System.Windows.Forms.DateTimePicker();
            this.dtpdemPORT = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_porteiro)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodPort
            // 
            this.lblCodPort.AutoSize = true;
            this.lblCodPort.Location = new System.Drawing.Point(20, 24);
            this.lblCodPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodPort.Name = "lblCodPort";
            this.lblCodPort.Size = new System.Drawing.Size(94, 13);
            this.lblCodPort.TabIndex = 0;
            this.lblCodPort.Text = "Código do Porteiro";
            // 
            // lblNomePort
            // 
            this.lblNomePort.AutoSize = true;
            this.lblNomePort.Location = new System.Drawing.Point(20, 61);
            this.lblNomePort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomePort.Name = "lblNomePort";
            this.lblNomePort.Size = new System.Drawing.Size(89, 13);
            this.lblNomePort.TabIndex = 1;
            this.lblNomePort.Text = "Nome do Porteiro";
            // 
            // lblRgPort
            // 
            this.lblRgPort.AutoSize = true;
            this.lblRgPort.Location = new System.Drawing.Point(20, 105);
            this.lblRgPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRgPort.Name = "lblRgPort";
            this.lblRgPort.Size = new System.Drawing.Size(23, 13);
            this.lblRgPort.TabIndex = 2;
            this.lblRgPort.Text = "RG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data de Admissão";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data de Demissão";
            // 
            // txtNamePort
            // 
            this.txtNamePort.Location = new System.Drawing.Point(22, 77);
            this.txtNamePort.Margin = new System.Windows.Forms.Padding(2);
            this.txtNamePort.Name = "txtNamePort";
            this.txtNamePort.Size = new System.Drawing.Size(166, 20);
            this.txtNamePort.TabIndex = 6;
            // 
            // mtxtRGPort
            // 
            this.mtxtRGPort.Location = new System.Drawing.Point(22, 122);
            this.mtxtRGPort.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtRGPort.Mask = "99\\.000\\.000C->a";
            this.mtxtRGPort.Name = "mtxtRGPort";
            this.mtxtRGPort.Size = new System.Drawing.Size(93, 20);
            this.mtxtRGPort.TabIndex = 7;
            // 
            // mtxtCPFPort
            // 
            this.mtxtCPFPort.Location = new System.Drawing.Point(22, 166);
            this.mtxtCPFPort.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtCPFPort.Mask = "000\\.000\\.000-00";
            this.mtxtCPFPort.Name = "mtxtCPFPort";
            this.mtxtCPFPort.Size = new System.Drawing.Size(93, 20);
            this.mtxtCPFPort.TabIndex = 8;
            // 
            // lbl_codPORT
            // 
            this.lbl_codPORT.AutoSize = true;
            this.lbl_codPORT.Location = new System.Drawing.Point(126, 24);
            this.lbl_codPORT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_codPORT.Name = "lbl_codPORT";
            this.lbl_codPORT.Size = new System.Drawing.Size(40, 13);
            this.lbl_codPORT.TabIndex = 11;
            this.lbl_codPORT.Text = "Código";
            // 
            // dgv_porteiro
            // 
            this.dgv_porteiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_porteiro.Location = new System.Drawing.Point(206, 24);
            this.dgv_porteiro.Name = "dgv_porteiro";
            this.dgv_porteiro.RowHeadersWidth = 51;
            this.dgv_porteiro.Size = new System.Drawing.Size(615, 262);
            this.dgv_porteiro.TabIndex = 12;
            // 
            // btnExcluirPort
            // 
            this.btnExcluirPort.Location = new System.Drawing.Point(208, 18);
            this.btnExcluirPort.Name = "btnExcluirPort";
            this.btnExcluirPort.Size = new System.Drawing.Size(94, 31);
            this.btnExcluirPort.TabIndex = 13;
            this.btnExcluirPort.Text = "Excluir Registro";
            this.btnExcluirPort.UseVisualStyleBackColor = true;
            this.btnExcluirPort.Click += new System.EventHandler(this.btnExcluirPort_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 31);
            this.button2.TabIndex = 14;
            this.button2.Text = "Novo Registro";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(4, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 31);
            this.button3.TabIndex = 15;
            this.button3.Text = "Próximo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnIncluirPort
            // 
            this.btnIncluirPort.Location = new System.Drawing.Point(112, 18);
            this.btnIncluirPort.Name = "btnIncluirPort";
            this.btnIncluirPort.Size = new System.Drawing.Size(91, 31);
            this.btnIncluirPort.TabIndex = 16;
            this.btnIncluirPort.Text = "Incluir Registros";
            this.btnIncluirPort.UseVisualStyleBackColor = true;
            this.btnIncluirPort.Click += new System.EventHandler(this.btnIncluirPort_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(104, 18);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 31);
            this.button5.TabIndex = 17;
            this.button5.Text = "Anterior";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnIncluirPort);
            this.groupBox1.Controls.Add(this.btnExcluirPort);
            this.groupBox1.Location = new System.Drawing.Point(24, 303);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(314, 54);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ações";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Location = new System.Drawing.Point(608, 303);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(213, 54);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Navegação";
            // 
            // dtpaddPORT
            // 
            this.dtpaddPORT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpaddPORT.Location = new System.Drawing.Point(22, 212);
            this.dtpaddPORT.Margin = new System.Windows.Forms.Padding(2);
            this.dtpaddPORT.Name = "dtpaddPORT";
            this.dtpaddPORT.Size = new System.Drawing.Size(98, 20);
            this.dtpaddPORT.TabIndex = 20;
            // 
            // dtpdemPORT
            // 
            this.dtpdemPORT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdemPORT.Location = new System.Drawing.Point(22, 265);
            this.dtpdemPORT.Name = "dtpdemPORT";
            this.dtpdemPORT.Size = new System.Drawing.Size(98, 20);
            this.dtpdemPORT.TabIndex = 21;
            // 
            // frmPorteiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 367);
            this.Controls.Add(this.dtpdemPORT);
            this.Controls.Add(this.dtpaddPORT);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_porteiro);
            this.Controls.Add(this.lbl_codPORT);
            this.Controls.Add(this.mtxtCPFPort);
            this.Controls.Add(this.mtxtRGPort);
            this.Controls.Add(this.txtNamePort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRgPort);
            this.Controls.Add(this.lblNomePort);
            this.Controls.Add(this.lblCodPort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPorteiro";
            this.Text = "0";
            this.Load += new System.EventHandler(this.frmPorteiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_porteiro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodPort;
        private System.Windows.Forms.Label lblNomePort;
        private System.Windows.Forms.Label lblRgPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamePort;
        private System.Windows.Forms.MaskedTextBox mtxtRGPort;
        private System.Windows.Forms.MaskedTextBox mtxtCPFPort;
        private System.Windows.Forms.Label lbl_codPORT;
        private System.Windows.Forms.DataGridView dgv_porteiro;
        private System.Windows.Forms.Button btnExcluirPort;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnIncluirPort;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpaddPORT;
        private System.Windows.Forms.DateTimePicker dtpdemPORT;
    }
}