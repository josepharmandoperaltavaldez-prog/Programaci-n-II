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
    public partial class Ejercicio13 : Form
    {
        public Ejercicio13()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            tmrCarga.Start();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            tmrCarga.Stop();
        }

        private void tmrCarga_Tick(object sender, EventArgs e)
        {
            if (pbProgreso.Value < 100)
            {
                pbProgreso.Value += 1;
            }
            else
            {
                tmrCarga.Stop();
                MessageBox.Show("Carga completada");
            }
        }
    }
    
}
