using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Fabrica_Sorvete_11901055_Frederico.Code.DTO;
using Fabrica_Sorvete_11901055_Frederico.Code.BLL;

namespace Fabrica_Sorvete_11901055_Frederico.Ui
{
    public partial class FormSorvetes : Form
    {

        SorvetesBLL newbll = new SorvetesBLL();
        SorvetesDTO newdto = new SorvetesDTO();
        public FormSorvetes()
        {
            InitializeComponent();
        }

        private void FormSorvetes_Load(object sender, EventArgs e)
        {
            dtgListarSorvetes.DataSource = newbll.Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            newdto.Id = int.Parse(txtID.Text);
            newdto.Tipo = txtTipo.Text;
            newdto.Sabor = txtSabor.Text;
            newdto.Preco = double.Parse(txtPreco.Text);
          
            newbll.Inserir(newdto);

            MessageBox.Show("Cadastrado com sucesso!", "Sorvetes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtID.Clear();
            txtTipo.Clear();
            txtSabor.Clear();
            txtPreco.Clear();
        }
        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            newdto.Id = int.Parse(txtID.Text);
            newdto.Tipo = txtSabor.Text;
            newdto.Sabor = txtTipo.Text;
            newdto.Preco = double.Parse(txtPreco.Text);

            newbll.Editar(newdto);

            MessageBox.Show("Alterado com sucesso!", "Sorvetes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            newbll.Listar();

            txtID.Clear();
            txtTipo.Clear();
            txtSabor.Clear();
            txtPreco.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            newdto.Id = int.Parse(txtID.Text);

            newbll.Excluir(newdto);

            MessageBox.Show("Excluído com sucesso!", "Sorvetes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            newbll.Listar();

            txtID.Clear();
            txtTipo.Clear();
            txtSabor.Clear();
            txtPreco.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgListarSorvetes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dtgListarSorvetes.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTipo.Text = dtgListarSorvetes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSabor.Text = dtgListarSorvetes.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPreco.Text = dtgListarSorvetes.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPreco_Click(object sender, EventArgs e)
        {

        }

        private void dtgListarSorvetes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSabor_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }

        private void lblSabor_Click(object sender, EventArgs e)
        {

        }
    }
}
