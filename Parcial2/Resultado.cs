using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Resultado : Form
    {
        string nombre;
        double puntaje = 0;
        public Resultado(string nom, double score)
        {
            nombre = nom;
            puntaje = score;
            InitializeComponent();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {                   
         label1.Text = nombre + " " + "su puntuación es" + " " + puntaje.ToString("N1");            
        }
    }
}
