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
    public partial class Ejercicio8 : Form
    {
    int contador = 0;

    public Ejercicio8()
    {
        InitializeComponent();
    }

    private void btnContar_Click(object sender, EventArgs e)
    {
        contador = contador + 1;

        lblConteo.Text = "Veces presionado: " + contador.ToString();
    }
    }
}