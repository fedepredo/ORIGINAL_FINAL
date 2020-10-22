namespace CondoFrame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarCondôminoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarSindicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarPorterioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadernoDigitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correspondênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reclamaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblData,
            this.lblHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 487);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1187, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblData
            // 
            this.lblData.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(41, 20);
            this.lblData.Text = "Data";
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(42, 20);
            this.lblHora.Text = "Hora";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.cadernoDigitalToolStripMenuItem,
            this.reclamaçõesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1187, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarCondôminoToolStripMenuItem,
            this.cadastrarSindicoToolStripMenuItem,
            this.cadastrarPorterioToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastrarCondôminoToolStripMenuItem
            // 
            this.cadastrarCondôminoToolStripMenuItem.Name = "cadastrarCondôminoToolStripMenuItem";
            this.cadastrarCondôminoToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.cadastrarCondôminoToolStripMenuItem.Text = "Cadastrar Condômino";
            this.cadastrarCondôminoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarCondôminoToolStripMenuItem_Click);
            // 
            // cadastrarSindicoToolStripMenuItem
            // 
            this.cadastrarSindicoToolStripMenuItem.Name = "cadastrarSindicoToolStripMenuItem";
            this.cadastrarSindicoToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.cadastrarSindicoToolStripMenuItem.Text = "Cadastrar Sindico";
            this.cadastrarSindicoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarSindicoToolStripMenuItem_Click);
            // 
            // cadastrarPorterioToolStripMenuItem
            // 
            this.cadastrarPorterioToolStripMenuItem.Name = "cadastrarPorterioToolStripMenuItem";
            this.cadastrarPorterioToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.cadastrarPorterioToolStripMenuItem.Text = "Cadastrar Porterio";
            this.cadastrarPorterioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarPorterioToolStripMenuItem_Click);
            // 
            // cadernoDigitalToolStripMenuItem
            // 
            this.cadernoDigitalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservasToolStripMenuItem,
            this.correspondênciaToolStripMenuItem});
            this.cadernoDigitalToolStripMenuItem.Name = "cadernoDigitalToolStripMenuItem";
            this.cadernoDigitalToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.cadernoDigitalToolStripMenuItem.Text = "Caderno Digital";
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.reservasToolStripMenuItem.Text = "Reservas";
            this.reservasToolStripMenuItem.Click += new System.EventHandler(this.reservasToolStripMenuItem_Click);
            // 
            // correspondênciaToolStripMenuItem
            // 
            this.correspondênciaToolStripMenuItem.Name = "correspondênciaToolStripMenuItem";
            this.correspondênciaToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.correspondênciaToolStripMenuItem.Text = "Correspondência";
            this.correspondênciaToolStripMenuItem.Click += new System.EventHandler(this.correspondênciaToolStripMenuItem_Click);
            // 
            // reclamaçõesToolStripMenuItem
            // 
            this.reclamaçõesToolStripMenuItem.Name = "reclamaçõesToolStripMenuItem";
            this.reclamaçõesToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.reclamaçõesToolStripMenuItem.Text = "Reclamações";
            this.reclamaçõesToolStripMenuItem.Click += new System.EventHandler(this.reclamaçõesToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(365, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 178);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Form1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1187, 513);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CondoFrame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarCondôminoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarSindicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarPorterioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadernoDigitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correspondênciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reclamaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

