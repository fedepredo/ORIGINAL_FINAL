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
    public partial class frmCondomino : Form
    {
        OleDbConnection conn = Conexao.obterConexao();
        OleDbDataReader dr_condomino;
        BindingSource bs_condomino = new BindingSource();
        String _query;
        public frmCondomino()
        {
            InitializeComponent();
        }

        private void frmCondomino_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = CondoFrame.Conexao.obterConexao();
            carregar_grid();
        }
        private void carregar_grid()
        {
            _query = "Select * from condomino";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_condomino = _dataCommand.ExecuteReader();
            if (dr_condomino.HasRows == true)
            {
                bs_condomino.DataSource = dr_condomino;
                dgv_condomino.DataSource = bs_condomino;
                dgv_condomino.Columns[0].HeaderText = "CPF";
                dgv_condomino.Columns[1].HeaderText = "Nome";
                dgv_condomino.Columns[2].HeaderText = "Num_Apt";
                dgv_condomino.Columns[3].HeaderText = "Telefone";
                dgv_condomino.Columns[4].HeaderText = "email";
                dgv_condomino.Columns[5].HeaderText = "dataentrada";
                dgv_condomino.Columns[6].HeaderText = "datasaída";
                dgv_condomino.Columns[7].HeaderText = "status";

                dgv_condomino.Columns[0].Width = 15;
                dgv_condomino.Columns[1].Width = 150;
                dgv_condomino.Columns[2].Width = 100;
                dgv_condomino.Columns[3].Width = 100;
                dgv_condomino.Columns[4].Width = 100;
                dgv_condomino.Columns[5].Width = 100;
                dgv_condomino.Columns[6].Width = 100;
                dgv_condomino.Columns[7].Width = 100;

                dgv_condomino.RowsDefaultCellStyle.BackColor = Color.Bisque;
                dgv_condomino.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

                igualar_text();
            }
            else
            {
                MessageBox.Show("Não temos clientes cadastrados !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
            private void igualar_text()
            {
                mskCPF.DataBindings.Add("Text", bs_condomino, "CPF");
                mskCPF.DataBindings.Clear();

                txtNomeCond.DataBindings.Add("Text", bs_condomino, "Nome");
                txtNomeCond.DataBindings.Clear();

                mskNumApt.DataBindings.Add("Text", bs_condomino, "Num_Apt");
                mskNumApt.DataBindings.Clear();

                mskTel.DataBindings.Add("Text", bs_condomino, "Telefone");
                mskTel.DataBindings.Clear();


                mskEmailCond.DataBindings.Add("Text", bs_condomino, "email");
                mskEmailCond.DataBindings.Clear();

                dtpentrada.DataBindings.Add("Text", bs_condomino, "dataentrada");
                dtpentrada.DataBindings.Clear();

                dtpsaida.DataBindings.Add("Text", bs_condomino, "datasaída");
                dtpsaida.DataBindings.Clear();

                txtStatus.DataBindings.Add("Text", bs_condomino, "status");
                txtStatus.DataBindings.Clear();

            }
            private void dgv_condomino_Click(object sender, EventArgs e)
            {
                igualar_text();
            }
            private void dgv_condomino_KeyUp(object sender, KeyEventArgs e)
            {
                igualar_text();
            }
        private void limpar()
            {

                mskCPF.Clear();
                txtNomeCond.Clear();
                mskNumApt.Clear();
                mskTel.Clear();
                mskEmailCond.Clear();
                txtStatus.Clear();
                dtpentrada.Text = DateTime.Now.ToString("dd/MM/yyyy");
                dtpsaida.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
            private bool valida()
            {
                bool erro = true;
                if (mskCPF.MaskFull == false)
                {
                    MessageBox.Show("CPF inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mskCPF.Focus();
                }

                else if (txtNomeCond.Text == "")
                {
                    MessageBox.Show("Nome inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNomeCond.Focus();
                }
                else if (mskNumApt.Text == "")
                {
                    MessageBox.Show("Número de apartemanto inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mskNumApt.Focus();
                }
                else if (mskTel.MaskFull == false)
                {
                    MessageBox.Show("Número de telefone inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mskTel.Focus();
                }
                else if (mskEmailCond.MaskFull == false)
                {
                    MessageBox.Show("E-mail inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mskEmailCond.Focus();
                }

                else
                {
                    erro = false;
                }
                return erro;
            }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            bool teste;
            teste = valida();
            if (teste == false)
            {
                _query = "Insert into condomino (CPF, Nome, Num_Apt, Telefone, email,dataentrada,datasaída,status) Values ";
                _query += "('" + mskCPF.Text + "'," +
                "'" + txtNomeCond.Text + "'," +
                "'" + mskNumApt.Text + "'," +
                "'" + mskTel.Text + "'," +
                "'" + mskEmailCond.Text + "'," +
                "'" + dtpentrada.Text + "'," +
                "'" + dtpsaida.Text + "'," +
                "'" + txtStatus.Text + "')";
                try
                {
                    OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                    _dataCommand.ExecuteNonQuery();
                    carregar_grid();
                    MessageBox.Show("Incluido com sucesso !!!!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas com a Inclusão  !!!!\n" + _query, "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _query = "delete from condomino where CPF like '" + mskCPF.Text + "'";
            try
            {
                OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                _dataCommand.ExecuteNonQuery();
                carregar_grid();
                MessageBox.Show("Excluido com sucesso !!!!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas com a Exclusão  !!!!\n" + _query, "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            limpar();
            mskCPF.Focus();
        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            if (bs_condomino.Count == bs_condomino.Position + 1)
                MessageBox.Show("Fim de arquivo encontrado !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                bs_condomino.MoveNext();
            igualar_text();
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            if (bs_condomino.Position == 0)
                MessageBox.Show("Inicio de arquivo encontrado !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                bs_condomino.MovePrevious();
            igualar_text();
        }
    }
}

