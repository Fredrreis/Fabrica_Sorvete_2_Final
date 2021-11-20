using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fabrica_Sorvete_11901055_Frederico.Ui
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void cadastrarSorvetesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSorvetes formSorvetes  = new FormSorvetes();
            formSorvetes.ShowDialog();
        }

        private void agendarEntregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEntrega formEntrega = new FormEntrega();
            formEntrega.ShowDialog();
        }
    }
}
