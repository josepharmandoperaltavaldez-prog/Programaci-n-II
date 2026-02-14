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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            double num1, num2, suma;

            try
            {
                num1 = double.Parse(txtNumero1.Text);
                num2 = double.Parse(txtNumero2.Text);

                suma = num1 + num2;

                lblResultado.Text = "La suma es: " + suma.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, ingresa solo números válidos.");
            }
        }
    }
}

