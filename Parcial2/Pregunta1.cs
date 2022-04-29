namespace Parcial2
{
    public partial class Pregunta1 : Form
    {
        string nombre;
        double puntaje = 0;
        int respuesta = 0;
        public Pregunta1(string nom, double score)
        {
            nombre = nom;
            puntaje = score;
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            respuesta = 0;
        }

        private void rdbOpcion2_CheckedChanged(object sender, EventArgs e)
        {
            respuesta = 0;
        }

        private void rdbOpcion3_CheckedChanged(object sender, EventArgs e)
        {
            respuesta = 1;
        }

        private void rdbOpcion4_CheckedChanged(object sender, EventArgs e)
        {
            respuesta = 0;
        }

        private void btnSiguiente1_Click(object sender, EventArgs e)
        {
            if (respuesta == 1)
            {
                puntaje += 5 * 0.25;
            }
            Pregunta2 pregunta2 = new Pregunta2(nombre, puntaje);
            pregunta2.Show();
            this.Hide();
        }

        private void Pregunta1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}