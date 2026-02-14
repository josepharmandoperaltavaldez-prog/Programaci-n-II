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
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operacion;

        public Calculadora()
        {
            InitializeComponent();
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "0";
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "9";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            primero = double.Parse(txtPantalla.Text); 
            operacion = "+";                         
            txtPantalla.Clear();                      
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            primero = double.Parse(txtPantalla.Text); 
            operacion = "-";                          
            txtPantalla.Clear();                      
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            primero = double.Parse(txtPantalla.Text); 
            operacion = "*";                          
            txtPantalla.Clear();                      
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            primero = double.Parse(txtPantalla.Text); 
            operacion = "/";                          
            txtPantalla.Clear();                     
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(txtPantalla.Text); 
            double resultado = 0;

            switch (operacion)
            {
                case "+": resultado = primero + segundo; break;
                case "-": resultado = primero - segundo; break;
                case "*": resultado = primero * segundo; break;
                case "/":
                    if (segundo != 0) resultado = primero / segundo;
                    else MessageBox.Show("No se puede dividir por cero");
                    break;
            }
            txtPantalla.Text = resultado.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();

            primero = 0;
            segundo = 0;
            operacion = "";
        }
    }
}
