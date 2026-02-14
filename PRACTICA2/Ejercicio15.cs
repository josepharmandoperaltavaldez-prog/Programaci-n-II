using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PRACTICA2
{
    public partial class Ejercicio15 : Form
    {
        public Ejercicio15()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            ofdAbrir.Filter = "Archivos de texto (*.txt)|*.txt";

            if (ofdAbrir.ShowDialog() == DialogResult.OK)
            {
                string lectura = File.ReadAllText(ofdAbrir.FileName);
                txtContenido.Text = lectura;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            sfdGuardar.Filter = "Archivos de texto (*.txt)|*.txt";

            if (sfdGuardar.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfdGuardar.FileName, txtContenido.Text);
                MessageBox.Show("Archivo guardado exitosamente.");
            }
        }
    }
    
}
