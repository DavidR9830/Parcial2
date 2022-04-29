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
    public partial class Pregunta4 : Form
    {
        string nombre;
        double puntaje;
        public Pregunta4(string nom, double score)
        {
            nombre = nom;
            puntaje = score;
            InitializeComponent();
        }

        private void lblPregunta4_Click(object sender, EventArgs e)
        {

        }
        private void txtPregunta4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSiguiente4_Click(object sender, EventArgs e)
        {
            if (txtPregunta4.Text == "metal líquido")
            {

                puntaje += 5 * 0.20;

            }
            Pregunta5 pregunta5 = new Pregunta5(nombre, puntaje);
            pregunta5.Show();
            this.Hide();
        }

        
    }
}
