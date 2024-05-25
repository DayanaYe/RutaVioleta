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
    public partial class TipoViolencia : Form
    {
        public TipoViolencia()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblViolenciaEconomica_Click(object sender, EventArgs e)
        {

        }

        private void bttAtras2_Click(object sender, EventArgs e)
        {
            VinculoDetalle primerform = new VinculoDetalle();
            primerform.Show();
            this.Close();
        }

        private void bttSiguiente3_Click(object sender, EventArgs e)
        {
            TipoViolenciaPrejuicio tercerform = new TipoViolenciaPrejuicio();
            tercerform.Show();
            this.Close();
        }

        private void bttCancelar3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TipoViolencia_Load(object sender, EventArgs e)
        {

        }
    }
}
