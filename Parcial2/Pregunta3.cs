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
    public partial class Pregunta3 : Form
    {
        string nombre;
        double puntaje = 0;
        
        public Pregunta3(string nom, double score)
        {
            nombre = nom;
            puntaje = score;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void btnSiguiente3_Click(object sender, EventArgs e)
        {
            if (txtPregunta3.Text == "ven conmigo si quieres vivir")
            {

                puntaje += 5 * 0.20;

            }
            Pregunta4 pregunta4 = new Pregunta4(nombre, puntaje);
            pregunta4.Show();
            this.Hide();
        }

        private void lblPregunta3_Click(object sender, EventArgs e)
        {

        }
    }
}
