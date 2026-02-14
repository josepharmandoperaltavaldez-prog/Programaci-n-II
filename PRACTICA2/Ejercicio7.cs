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
    public partial class Ejercicio7 : Form
    {
        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNuevoElemento.Text))
            {
                lstElementos.Items.Add(txtNuevoElemento.Text);

                txtNuevoElemento.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, escribe algo para agregar.");
            }
            
        }
    }
}




