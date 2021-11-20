using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Fabrica_Sorvete_11901055_Frederico.Code.DAL;
using Fabrica_Sorvete_11901055_Frederico.Code.DTO;
using Fabrica_Sorvete_11901055_Frederico.Code.BLL;


namespace Fabrica_Sorvete_11901055_Frederico.Ui
{
    public partial class FormEntrega : Form
    {
        EntregaBLL entregabll = new EntregaBLL();
        EntregaDTO entregadto = new EntregaDTO();
        public FormEntrega()
        {
            InitializeComponent();
            SorvetesBLL sorvetebll = new SorvetesBLL();

            cmbxTipo.DataSource = sorvetebll.Listar();
            cmbxTipo.ValueMember = "idSorvete";
            cmbxTipo.DisplayMember = "tipo";

            cmbxSabor.DataSource = sorvetebll.Listar();
            cmbxSabor.ValueMember = "idSorvete";
            cmbxSabor.DisplayMember = "sabor";


        }

        private void FormEntrega_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            entregadto.Identrega = int.Parse(txtIDEntrega.Text);
            entregadto.Endereco = txtEndereco.Text;
            entregadto.Numtelefone = mskNumTelefone.Text;
            entregadto.Cep = mskCEP.Text;
            entregadto.Tiposorvete = cmbxTipo.Text;
            entregadto.Quantidade = int.Parse(txtQuantidade.Text);

            entregabll.Inserir(entregadto);

            MessageBox.Show("Seu pedido foi realizado com sucesso!", "Entrega", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtIDEntrega.Clear();
            txtEndereco.Clear();
            mskNumTelefone.Clear();
            mskCEP.Clear();
            cmbxTipo.ResetText();
            cmbxSabor.ResetText();
            txtQuantidade.Clear();
        }

        private void cmbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            entregadto.Identrega = int.Parse(txtIDEntrega.Text);
            entregadto.Endereco = txtEndereco.Text;
            entregadto.Numtelefone = mskNumTelefone.Text;
            entregadto.Cep = mskCEP.Text;
            entregadto.Tiposorvete = cmbxTipo.Text;
            entregadto.Quantidade = int.Parse(txtQuantidade.Text);

            entregabll.Editar(entregadto);

            MessageBox.Show("Seu pedido foi alterado com sucesso!", "Entrega", MessageBoxButtons.OK, MessageBoxIcon.Information);

            entregabll.Listar();

            txtIDEntrega.Clear();
            txtEndereco.Clear();
            mskNumTelefone.Clear();
            mskCEP.Clear();
            cmbxTipo.ResetText();
            cmbxSabor.ResetText();
            txtQuantidade.Clear();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            entregadto.Identrega = int.Parse(txtIDEntrega.Text);

            entregabll.Excluir(entregadto);

            MessageBox.Show("Seu pedido foi excluído com sucesso!", "Entrega", MessageBoxButtons.OK, MessageBoxIcon.Information);

            entregabll.Listar();

            txtIDEntrega.Clear();
            txtEndereco.Clear();
            mskNumTelefone.Clear();
            mskCEP.Clear();
            cmbxTipo.ResetText();
            cmbxSabor.ResetText();
            txtQuantidade.Clear();
        }

        private void dtgListarEntregas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDEntrega.Text = dtgListarEntregas.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtEndereco.Text = dtgListarEntregas.Rows[e.RowIndex].Cells[1].Value.ToString();
            mskNumTelefone.Text = dtgListarEntregas.Rows[e.RowIndex].Cells[2].Value.ToString();
            mskCEP.Text = dtgListarEntregas.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbxTipo.Text = dtgListarEntregas.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbxSabor.Text = dtgListarEntregas.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtQuantidade.Text = dtgListarEntregas.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
