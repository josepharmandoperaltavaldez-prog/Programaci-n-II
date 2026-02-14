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
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rbOpcion1.Checked)
            {
                lblResultado.Text = "Seleccionaste: " + rbOpcion1.Text;
            }
            else if (rbOpcion2.Checked)
            {
                lblResultado.Text = "Seleccionaste: " + rbOpcion2.Text;
            }
            else if (rbOpcion3.Checked)
            {
                lblResultado.Text = "Seleccionaste: " + rbOpcion3.Text;
            }
            else
            {
                lblResultado.Text = "Por favor, selecciona una opción.";
            }
        }
    }
    
}
