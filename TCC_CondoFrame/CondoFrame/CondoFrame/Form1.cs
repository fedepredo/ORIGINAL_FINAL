using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondoFrame
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Today.ToLongDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void cadastrarCondôminoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCondomino newfuncao1 = new frmCondomino();
            newfuncao1.ShowDialog();
        }

        private void cadastrarSindicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSindico newfuncao2 = new frmSindico();
            newfuncao2.ShowDialog();
        }

        private void cadastrarPorterioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPorteiro newfuncao3 = new frmPorteiro();
            newfuncao3.ShowDialog();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void correspondênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void reclamaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult mensagem = MessageBox.Show("Deseja finalizar a aplicação?", "Encerrar", MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (mensagem == System.Windows.Forms.DialogResult.Yes)

            {
                this.Close();
            }
        }

        private void cadernoDigitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgenda newfuncao6 = new frmAgenda();
            newfuncao6.ShowDialog();
        }

        private void correspondênciaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCorrespondencia newfuncao5 = new frmCorrespondencia();
            newfuncao5.ShowDialog();
        }
    }
}
