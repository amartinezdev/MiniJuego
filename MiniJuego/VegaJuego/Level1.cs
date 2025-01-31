using System.Media;

namespace VegaJuego
{
    public partial class Level1 : Form
    {
        Link Player;
        Broncas Enemigo1;
        public Level1()
        {
            InitializeComponent();
            IniciarPersonajes();
            IniciarOpcionesDelMapa();
        }
        private void IniciarPersonajes()
        {
            //Lienzo, coordenadaX, coordenadaY, salud, escudo y arma
            Player = new Link(this, 0, 0, 30, 0, 0);
            Enemigo1 = new Broncas(this, 0, 300);
        }

        private void Level1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Player.mover(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Enemigo1.mover();
        }

        private void IniciarOpcionesDelMapa()
        {
            labelVida.Text = "Salud: " + Player.Salud;
            labelEscudo.Text = "Escudo: " + Player.Escudo;
            labelArma.Text = "Arma: " + Player.Arma;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelArma_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
