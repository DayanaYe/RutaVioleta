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
            DialogResult result = MessageBox.Show("¿Seguro que quieres cancelar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); // Cerrar el formulario si el usuario selecciona "Sí"
            }
        }

        private void bttAtras_Click(object sender, EventArgs e)
        {
            frmAutenticacion primerform = new frmAutenticacion();
            primerform.Show();
            this.Close();
        }

        private void bttSiguiente1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || 
                string.IsNullOrWhiteSpace(textBox4.Text) || (CboTipoDocumento.SelectedIndex == -1)
                || (CboDepartamentoResidencia.SelectedIndex == -1) || (cboSexo.SelectedIndex == -1) || (cboOrientaciónSexual.SelectedIndex == -1)
                || (cboIdentidadGenero.SelectedIndex == -1) || (comboBox1.SelectedIndex == -1) || (cboMunicipioResidencia.SelectedIndex== -1))
            {
                MessageBox.Show("No se puede dejar espacios sin responder");
                return;
            }
            VinculoDetalle tercerform = new VinculoDetalle();
            tercerform.Show();
            this.Close();



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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar el efecto de la tecla presionada
                e.Handled = true;
            }
        }

        private void txtSegundoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar el efecto de la tecla presionada
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar el efecto de la tecla presionada
                e.Handled = true;
            }
        }

        

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar el efecto de la tecla presionada
                e.Handled = true;
            }
        }

        private void txtSegundoApellido_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar el efecto de la tecla presionada
                e.Handled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void cboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboSede_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void CboDepartamentoResidencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}   
