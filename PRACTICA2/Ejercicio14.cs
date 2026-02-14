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
    public partial class Ejercicio14 : Form
    {
        public Ejercicio14()
        {
            InitializeComponent();
        }

        private void tcEjercicios_Click(object sender, EventArgs e)
        {
            string pestañaActual = tcEjercicios.SelectedTab.Text;

            this.Text = "Estás en: " + pestañaActual;
        }
    }
}

