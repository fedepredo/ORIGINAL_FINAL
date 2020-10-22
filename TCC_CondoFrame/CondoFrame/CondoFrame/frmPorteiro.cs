using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace CondoFrame
{
    public partial class frmPorteiro : Form
    {

        OleDbConnection conn = Conexao.obterConexao();
        OleDbDataReader dr_porteiro;
        BindingSource bs_porteiro = new BindingSource();
        String _query;


        public frmPorteiro()
        {
            InitializeComponent();
        }

        private void frmPorteiro_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = CondoFrame.Conexao.obterConexao();
            carregar_grid();
        }

        private void carregar_grid()
        {
            _query = "Select * from porteiro";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_porteiro = _dataCommand.ExecuteReader();
            if (dr_porteiro.HasRows == true)
            {
                bs_porteiro.DataSource = dr_porteiro;
                dgv_porteiro.DataSource = bs_porteiro;
                dgv_porteiro.Columns[0].HeaderText = "Código do Porteiro";
                dgv_porteiro.Columns[1].HeaderText = "Nome";
                dgv_porteiro.Columns[2].HeaderText = "RG";
                dgv_porteiro.Columns[3].HeaderText = "CPF";
                dgv_porteiro.Columns[4].HeaderText = "Data de admissão";
                dgv_porteiro.Columns[5].HeaderText = "Data de demissão";

                dgv_porteiro.Columns[0].Width = 15;
                dgv_porteiro.Columns[1].Width = 150;
                dgv_porteiro.Columns[2].Width = 100;
                dgv_porteiro.Columns[3].Width = 100;
                dgv_porteiro.Columns[4].Width = 100;
                dgv_porteiro.Columns[5].Width = 100;

                dgv_porteiro.RowsDefaultCellStyle.BackColor = Color.Bisque;
                dgv_porteiro.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

                igualar_text();
            }
            else
            {
                MessageBox.Show("Não temos porteiros cadastrados !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

       

        private void igualar_text()
        {
            lbl_codPORT.DataBindings.Add("Text", bs_porteiro, "codporteiro");
            lbl_codPORT.DataBindings.Clear();

            txtNamePort.DataBindings.Add("Text", bs_porteiro, "nome");
            txtNamePort.DataBindings.Clear();

            mtxtRGPort.DataBindings.Add("Text", bs_porteiro, "rg");
            mtxtRGPort.DataBindings.Clear();

            mtxtCPFPort.DataBindings.Add("Text", bs_porteiro, "cpf");
            mtxtCPFPort.DataBindings.Clear();


            dtpaddPORT.DataBindings.Add("Text", bs_porteiro, "dataadmissao");
            dtpaddPORT.DataBindings.Clear();

            dtpdemPORT.DataBindings.Add("Text", bs_porteiro, "datademisao");
            dtpdemPORT.DataBindings.Clear();

        }
        private void dgv_porteiro_Click(object sender, EventArgs e)
        {
            igualar_text();
        }
        private void dgv_porteiro_KeyUp(object sender, KeyEventArgs e)
        {
            igualar_text();
        }
        private void limpar()
        {
            lbl_codPORT.Text = "";
            txtNamePort.Clear();
            mtxtRGPort.Clear();
            mtxtCPFPort.Clear();
            dtpaddPORT.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dtpdemPORT.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }
        private bool valida()
        {
            bool erro = true;
            if (txtNamePort.Text == "")
            {
                MessageBox.Show("Nome inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNamePort.Focus();
            }

            else if (mtxtRGPort.Text == "")
            {
                MessageBox.Show("RG inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtxtRGPort.Focus();
            }
            else if (mtxtCPFPort.MaskFull == false)
            {
                MessageBox.Show("CPF inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtxtCPFPort.Focus();
            }


            else
            {
                erro = false;
            }
            return erro;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            limpar();
            txtNamePort.Focus();
        }
        private void btnIncluirPort_Click(object sender, EventArgs e)
        {
            bool teste;
            teste = valida(); 
            if (teste == false)
            {
                    _query = "Insert into porteiro (nome,rg,cpf,dataadmissao,datademisao) Values ";
                    _query += "('" + txtNamePort.Text + "'," +
                    "'" + mtxtRGPort.Text + "'," +
                    "'" + mtxtCPFPort.Text + "'," +
                    "'" + dtpaddPORT.Text + "'," +
                    "'" + dtpdemPORT.Text + "')";
                    try
                {
                        OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                        _dataCommand.ExecuteNonQuery();
                        carregar_grid();
                        MessageBox.Show("Incluido com sucesso !!!!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Problemas com a Inclusão  !!!!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }
        private void btnExcluirPort_Click(object sender, EventArgs e)
        {
            _query = "delete from porteiro where codporteiro like '" + lbl_codPORT.Text + "'";
            try
            {
                OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                _dataCommand.ExecuteNonQuery();
                carregar_grid();
                MessageBox.Show("Excluido com sucesso !!!!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas com a Exclusão  !!!!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (bs_porteiro.Count == bs_porteiro.Position + 1)
                MessageBox.Show("Fim de arquivo encontrado !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                bs_porteiro.MoveNext();
            igualar_text();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (bs_porteiro.Position == 0)
                MessageBox.Show("Inicio de arquivo encontrado !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                bs_porteiro.MovePrevious();
            igualar_text();
        }
    }
}