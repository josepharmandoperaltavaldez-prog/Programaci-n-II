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
    public partial class Ejercicio11 : Form
    {
        public Ejercicio11()
        {
            InitializeComponent();
        }

        private void btnMostrarFecha_Click(object sender, EventArgs e)
        {
            DateTime fechaElegida = dtpFecha.Value;

            lblFechaResultado.Text = "Seleccionaste el: " + fechaElegida.ToShortDateString();
        }
    }
    
}
