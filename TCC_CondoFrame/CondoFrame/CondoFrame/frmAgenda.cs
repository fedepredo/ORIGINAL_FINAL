using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CondoFrame
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void agendarReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReserva newfuncao4 = new frmReserva();
            newfuncao4.ShowDialog();
        }
    }
}
