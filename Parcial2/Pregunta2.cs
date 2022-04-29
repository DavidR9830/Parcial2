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
    public partial class Pregunta2 : Form
    {
        string nombre;
        double puntaje = 0 ;
        int respuesta = 0;
       
        public Pregunta2(string nom, double score)
        {
            nombre = nom;
            puntaje = score;
            InitializeComponent();
        }

     

        private void rdbOpcion1_CheckedChanged(object sender, EventArgs e)
        {
            respuesta = 0;
        }
        private void rdbOpcion2_CheckedChanged(object sender, EventArgs e)
        {

            respuesta = 1;

        }

        private void rdbOpcion3_CheckedChanged(object sender, EventArgs e)
        {
            respuesta = 0;
        }

        private void rdbOpcion4_CheckedChanged(object sender, EventArgs e)
        {
            puntaje += 0;
        }

        private void btnSiguiente2_Click(object sender, EventArgs e)
        {
            if (respuesta == 1)
            {
                puntaje += 5 * 0.15;
            }
            Pregunta3 pregunta3 = new Pregunta3(nombre, puntaje);
            pregunta3.Show();
            this.Hide();
        }
        private void Pregunta2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
