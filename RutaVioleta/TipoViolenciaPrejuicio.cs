using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RutaVioleta
{
    public partial class TipoViolenciaPrejuicio : Form
    {
        public TipoViolenciaPrejuicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttAtras3_Click(object sender, EventArgs e)
        {
            TipoViolencia primerform = new TipoViolencia();
            primerform.Show();
            this.Close();
        }

        private void bttCancelar4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TipoViolenciaPrejuicio_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bttGuardar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
