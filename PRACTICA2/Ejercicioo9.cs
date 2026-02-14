using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA2
{
    public partial class Ejercicioo9 : Form
    {
        public Ejercicioo9()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtEntrada.Text, out double resultado))
            {
                MessageBox.Show("¡Correcto! '" + resultado + "' es un número válido.", "Validación Exitosa");
            }
            else
            {
                MessageBox.Show("Error: La entrada no es un número válido.", "Error de Entrada",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtEntrada.Clear();
            }
        }
    }
    
}
