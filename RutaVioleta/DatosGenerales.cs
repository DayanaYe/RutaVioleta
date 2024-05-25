using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace RutaVioleta
{
    public partial class DatosGenerales : Form
    {
        public DatosGenerales()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DatosGenerales_Load(object sender, EventArgs e)
        {

        }

        private void bttCancelar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttAtras_Click(object sender, EventArgs e)
        {
            frmAutenticacion primerform = new frmAutenticacion();
            primerform.Show();
            this.Close();
        }

        private void bttSiguiente1_Click(object sender, EventArgs e)
        {
            VinculoDetalle tercerform = new VinculoDetalle();
            tercerform.Show();
            this.Close();



        }

        private void textBox1_TextChanged(object sender, KeyPressEventArgs e)
        {
            
          


            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es una letra ni una tecla de control, se cancela el evento
                e.Handled = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void CboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPrimerNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblDatosGenerales_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePicker1.MaxDate = DateTime.Now;


        }
    }
}   
