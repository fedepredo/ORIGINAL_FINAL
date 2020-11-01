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
    public partial class frmSindico : Form
    {

        OleDbConnection conn = Conexao.obterConexao();
        OleDbDataReader dr_sindico;
        BindingSource bs_sindico = new BindingSource();
        String _query;


        public frmSindico()
        {
            InitializeComponent();
        }

        private void frmSindico_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = CondoFrame.Conexao.obterConexao();
            carregar_grid();
        }

        private void carregar_grid()
        {
            _query = "Select * from sindico";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_sindico = _dataCommand.ExecuteReader();
            if (dr_sindico.HasRows == true)
            {
                bs_sindico.DataSource = dr_sindico;
                dgv_sindico.DataSource = bs_sindico;
                dgv_sindico.Columns[0].HeaderText = "Cod_Sindico";
                dgv_sindico.Columns[1].HeaderText = "CPF";
                dgv_sindico.Columns[2].HeaderText = "iniciomandato";
                dgv_sindico.Columns[3].HeaderText = "fimmandato";
                dgv_sindico.Columns[4].HeaderText = "dataeleicao";


                dgv_sindico.Columns[0].Width = 15;
                dgv_sindico.Columns[1].Width = 150;
                dgv_sindico.Columns[2].Width = 100;
                dgv_sindico.Columns[3].Width = 100;
                dgv_sindico.Columns[4].Width = 100;


                dgv_sindico.RowsDefaultCellStyle.BackColor = Color.Bisque;
                dgv_sindico.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

                igualar_text();
            }
            else
            {
                MessageBox.Show("Não temos síndicos cadastrados !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void igualar_text()
        {
            lblCodSin.DataBindings.Add("Text", bs_sindico, "Cod_Sindico");
            lblCodSin.DataBindings.Clear();

            mskCPF.DataBindings.Add("Text", bs_sindico, "CPF");
            mskCPF.DataBindings.Clear();

            dtpInicio.DataBindings.Add("Text", bs_sindico, "iniciomandato");
            dtpInicio.DataBindings.Clear();

            dtpFim.DataBindings.Add("Text", bs_sindico, "fimmandato");
            dtpFim.DataBindings.Clear();


            dtpEleicao.DataBindings.Add("Text", bs_sindico, "dataeleicao");
            dtpEleicao.DataBindings.Clear();

        }

        private void dgv_sindico_Click(object sender, EventArgs e)
        {
            igualar_text();
        }

        private void dgv_sindico_KeyUp(object sender, KeyEventArgs e)
        {
            igualar_text();
        }

        private void limpar()
        {
            lblCodSin.Text = "";
            mskCPF.Clear();
            dtpInicio.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dtpFim.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dtpEleicao.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private bool valida()
        {
            bool erro = true;
            if (mskCPF.MaskFull == false)
            {
                MessageBox.Show("CPF inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mskCPF.Focus();
            }

            else if (dtpInicio.Text == "")
            {
                MessageBox.Show("Data de início do mandato inválida. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpInicio.Focus();
            }
            else if (dtpFim.Text == "")
            {
                MessageBox.Show("Data do fim do mandato inválida. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpFim.Focus();
            }
            else if (dtpEleicao.Text == "")
            {
                MessageBox.Show("Data de eleição. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpEleicao.Focus();
            }

            else
            {
                erro = false;
            }
            return erro;
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            limpar();
            mskCPF.Focus();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            bool teste;
            teste = valida();
            if (teste == false)
            {
                _query = "Insert into sindico (CPF,iniciomandato,fimmandato,dataeleicao) Values ";
                _query += "('" + mskCPF.Text + "'," + "'" + dtpInicio.Text + "'," + "'" + dtpFim.Text + "'," + "'" + dtpEleicao.Text + "')";
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _query = "delete from sindico where Cod_Sindico like '" + lblCodSin.Text + "'";
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

        private void btnProx_Click(object sender, EventArgs e)
        {
            if (bs_sindico.Count == bs_sindico.Position + 1)
                MessageBox.Show("Fim de arquivo encontrado !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                bs_sindico.MoveNext();
            igualar_text();
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            if (bs_sindico.Position == 0)
                MessageBox.Show("Inicio de arquivo encontrado !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                bs_sindico.MovePrevious();
            igualar_text();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            _query = "Select * from sindico where CPF like '" + mskCPF.Text + "%'";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_sindico = _dataCommand.ExecuteReader();

            if (dr_sindico.HasRows == true)
            {
                bs_sindico.DataSource = dr_sindico;
            }
            else
            {
                MessageBox.Show("Não temos Síndicos cadastrados com este CPF !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPesquisa.Text = "";
            }
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            bool teste;
            teste = valida();
            if (teste == false)
            {
                _query = "Update sindico set CPF ='" + mskCPF.Text + "',";
                _query += "iniciomandato = '" + dtpInicio.Text + "',";
                _query += "fimmandato = '" + dtpFim.Text + "',";
                _query += "dataeleicao = '" + dtpEleicao.Text + "' ";
                _query += "where Cod_Sindico like '" + lblCodSin.Text + "' ";
                try
                {
                    OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                    _dataCommand.ExecuteNonQuery();
                    carregar_grid();
                    MessageBox.Show("Alterado com sucesso !!!!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception)
                {
                    MessageBox.Show("Problemas com a Alteração  !!!!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
