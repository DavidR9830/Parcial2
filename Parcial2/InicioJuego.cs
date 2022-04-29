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
    public partial class InicioJuego : Form
    {
        string nombre;
        double puntaje = 0;
        public InicioJuego(string nom, double score)
        {
            nombre = nom;
            puntaje = score;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
           Pregunta1 pregunta1 = new Pregunta1(nombre, puntaje);
           pregunta1.Show();
            this.Hide();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            nombre =txtNombre.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
