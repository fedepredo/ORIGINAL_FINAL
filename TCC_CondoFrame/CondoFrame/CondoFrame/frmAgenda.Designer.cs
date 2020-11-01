namespace CondoFrame
{
    partial class frmAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenda));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarRelatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lerRelatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inadimplênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarInadimplênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservasToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.inadimplênciasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarReservasToolStripMenuItem});
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.reservasToolStripMenuItem.Text = "Reservas";
            // 
            // agendarReservasToolStripMenuItem
            // 
            this.agendarReservasToolStripMenuItem.Name = "agendarReservasToolStripMenuItem";
            this.agendarReservasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.agendarReservasToolStripMenuItem.Text = "Agendar Reservas";
            this.agendarReservasToolStripMenuItem.Click += new System.EventHandler(this.agendarReservasToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarRelatórioToolStripMenuItem,
            this.lerRelatórioToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // criarRelatórioToolStripMenuItem
            // 
            this.criarRelatórioToolStripMenuItem.Name = "criarRelatórioToolStripMenuItem";
            this.criarRelatórioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.criarRelatórioToolStripMenuItem.Text = "Criar Relatório";
            // 
            // lerRelatórioToolStripMenuItem
            // 
            this.lerRelatórioToolStripMenuItem.Name = "lerRelatórioToolStripMenuItem";
            this.lerRelatórioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lerRelatórioToolStripMenuItem.Text = "Ler Relatório";
            // 
            // inadimplênciasToolStripMenuItem
            // 
            this.inadimplênciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarInadimplênciaToolStripMenuItem});
            this.inadimplênciasToolStripMenuItem.Name = "inadimplênciasToolStripMenuItem";
            this.inadimplênciasToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.inadimplênciasToolStripMenuItem.Text = "Inadimplências";
            // 
            // registrarInadimplênciaToolStripMenuItem
            // 
            this.registrarInadimplênciaToolStripMenuItem.Name = "registrarInadimplênciaToolStripMenuItem";
            this.registrarInadimplênciaToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.registrarInadimplênciaToolStripMenuItem.Text = "Registrar inadimplência";
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAgenda";
            this.Text = "Caderno Digital";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarRelatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lerRelatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inadimplênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarInadimplênciaToolStripMenuItem;
    }
}