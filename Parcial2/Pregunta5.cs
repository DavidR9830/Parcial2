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
    public partial class Pregunta5 : Form
    {
        string nombre;
        double puntaje;
        int respuesta = 0;
        public Pregunta5(string nom, double score)
        {
            nombre = nom;
            puntaje = score;
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            respuesta = 0;
        }
        private void rdbFalso_CheckedChanged(object sender, EventArgs e)
        {
            respuesta = 1;
        }

        private void btnSiguiente5_Click(object sender, EventArgs e)
        {
            if (respuesta == 1)
            {
                puntaje += 5 * 0.20;
        
            }
            Resultado resultado = new Resultado (nombre, puntaje);
            resultado.Show();
            this.Hide();
        }

        
    }
    
}
