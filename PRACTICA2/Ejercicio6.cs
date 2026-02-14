using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA2
{
    public partial class Ejercicio6 : Form
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void cmbColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbColores.SelectedItem.ToString())
            {
                case "Rojo":
                    this.BackColor = Color.Red;
                    break;
                case "Verde":
                    this.BackColor = Color.Green;
                    break;
                case "Azul":
                    this.BackColor = Color.Blue;
                    break;
                default:
                    this.BackColor = SystemColors.Control;
                    break;
            }
        }
    }
}
