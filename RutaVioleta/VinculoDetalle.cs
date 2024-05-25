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
    public partial class VinculoDetalle : Form
    {
        public VinculoDetalle()
        {
            InitializeComponent();
        }

        private void lblPrimerNombre_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttSiguiente1_Click(object sender, EventArgs e)
        {
            TipoViolencia tercerform = new TipoViolencia();
            tercerform.Show();
            this.Close();
        }

        private void bttAtras1_Click(object sender, EventArgs e)
        {
            DatosGenerales primerform = new DatosGenerales();
            primerform.Show();
            this.Close();
        }

        private void bttCancelar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
