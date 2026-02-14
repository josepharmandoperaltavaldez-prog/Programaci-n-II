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
    public partial class Ejercicio12 : Form
    {
        public Ejercicio12()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCelsius.Text, out double celsius))
            {
                double fahrenheit = (celsius * 1.8) + 32;

                lblResultadoF.Text = string.Format("Resultado: {0:F2} °F", fahrenheit);
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una temperatura numérica válida.", "Error de conversión");
            }
        }
    }
    
}
