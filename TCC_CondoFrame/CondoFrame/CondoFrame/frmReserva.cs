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
    public partial class frmReserva : Form
    {
        OleDbConnection conn = Conexao.obterConexao();
        OleDbDataReader dr_reservas;
        BindingSource bs_reservas = new BindingSource();
        String _query;

        public frmReserva()
        {
            InitializeComponent();
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = CondoFrame.Conexao.obterConexao();
            carregar_grid();
        }

        private void carregar_grid()
        {
            _query = "Select * from reservas";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_reservas = _dataCommand.ExecuteReader();
            if (dr_reservas.HasRows == true)
            {
                bs_reservas.DataSource = dr_reservas;
                dgv_reserva.DataSource = bs_reservas;
                dgv_reserva.Columns[0].HeaderText = "CPF";
                dgv_reserva.Columns[1].HeaderText = "Nome";
                dgv_reserva.Columns[2].HeaderText = "Horário Marcado";
                dgv_reserva.Columns[3].HeaderText = "Data Marcada";
                dgv_reserva.Columns[4].HeaderText = "Local da Reserva";

                dgv_reserva.Columns[0].Width = 90;
                dgv_reserva.Columns[1].Width = 150;
                dgv_reserva.Columns[2].Width = 100;
                dgv_reserva.Columns[3].Width = 100;
                dgv_reserva.Columns[4].Width = 100;

                dgv_reserva.RowsDefaultCellStyle.BackColor = Color.Bisque;
                dgv_reserva.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

                igualar_text();
            }
            else
            {
                MessageBox.Show("Não temos Reservas cadastradas !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void igualar_text()
        {
            mskCPF.DataBindings.Add("Text", bs_reservas, "CPF");
            mskCPF.DataBindings.Clear();

            txtNome.DataBindings.Add("Text", bs_reservas, "Nome_Morador");
            txtNome.DataBindings.Clear();

            txtHora.DataBindings.Add("Text", bs_reservas, "Horario_Reserva");
            txtHora.DataBindings.Clear();

            dtpReserva.DataBindings.Add("Text", bs_reservas, "Dia_Reserva");
            dtpReserva.DataBindings.Clear();


            txtLocal.DataBindings.Add("Text", bs_reservas, "Local_Reserva");
            txtLocal.DataBindings.Clear();

        }

        private void dgv_reserva_KeyUp(object sender, KeyEventArgs e)
        {
            igualar_text();
        }
        private void limpar()
        {
            mskCPF.Clear();
            txtNome.Clear();
            txtHora.Clear();
            dtpReserva.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtLocal.Clear();

        }
        private bool valida()
        {
            bool erro = true;
            if (txtNome.Text == "")
            {
                MessageBox.Show("Nome inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.Focus();
            }

            else if (txtHora.Text == "")
            {
                MessageBox.Show("Hora inválida. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtHora.Focus();
            }
            else if (mskCPF.MaskFull == false)
            {
                MessageBox.Show("CPF inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mskCPF.Focus();
            }
            else if (txtLocal.Text == "")
            {
                MessageBox.Show("Local inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLocal.Focus();
            }
            else if (dtpReserva.Text == "")
            {
                MessageBox.Show("Data inválida. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpReserva.Focus();
            }

            else
            {
                erro = false;
            }
            return erro;
        }

        private void btnNovo_Click(object sender, EventArgs e)
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
                _query = "Insert into reservas (CPF,Nome_Morador,Horario_Reserva,Dia_Reserva,Local_Reserva) Values ";
                _query += "('" + mskCPF.Text + "'," +
                "'" + txtNome.Text + "'," +
                "'" + txtHora.Text + "'," +
                "'" + dtpReserva.Text + "'," +
                "'" + txtLocal.Text + "')";
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

        private void btnAlt_Click(object sender, EventArgs e)
        {
            bool teste;
            teste = valida();
            if (teste == false)
            {
                _query = "Update reservas set Nome ='" + txtNome.Text + "',";
                _query += "Horario_Reserva = '" + txtHora.Text + "',";
                _query += "Dia_Reserva = '" + dtpReserva.Text + "',";
                _query += "Local_reserva = '" + dtpReserva.Text + "' ";
                _query += "where CPF like '" + mskCPF.Text + "' ";
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _query = "delete from reservas where CPF like '" + mskCPF.Text + "'";
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
            if (bs_reservas.Count == bs_reservas.Position + 1)
                MessageBox.Show("Fim de arquivo encontrado !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                bs_reservas.MoveNext();
            igualar_text();
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            if (bs_reservas.Position == 0)
                MessageBox.Show("Inicio de arquivo encontrado !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                bs_reservas.MovePrevious();
            igualar_text();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            _query = "Select * from reservas where CPF like '" + mskCPF.Text + "%'";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_reservas = _dataCommand.ExecuteReader();

            if (dr_reservas.HasRows == true)
            {
                bs_reservas.DataSource = dr_reservas;
            }
            else
            {
                MessageBox.Show("Não temos Reservas cadastradas com este CPF !!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPesquisa.Text = "";
            }
        }
    }
}
