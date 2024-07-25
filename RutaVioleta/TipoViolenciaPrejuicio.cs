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
            DialogResult result = MessageBox.Show("¿Seguro que quieres cancelar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); // Cerrar el formulario si el usuario selecciona "Sí"
            }
        }

        private void TipoViolenciaPrejuicio_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bttGuardar2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0 || checkedListBox2.CheckedItems.Count == 0 ||
                checkedListBox3.CheckedItems.Count == 0 || checkedListBox4.CheckedItems.Count == 0)
            {
                MessageBox.Show("No se puede dejar espacios sin responder");
                return;
            }
            if (checkedListBox1.CheckedItems.Count == 1 || checkedListBox2.CheckedItems.Count == 1 ||
                checkedListBox3.CheckedItems.Count == 1 || checkedListBox4.CheckedItems.Count == 1)
            {
                MessageBox.Show("Sus datos han sido guardados correctamente");
            }
                this.Close();
        }
    }
}
