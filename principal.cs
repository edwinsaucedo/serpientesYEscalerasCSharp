using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serpientes_Escaleras
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_jugar_Click(object sender, EventArgs e)
        {
            jugadores IR = new jugadores();
            this.Hide();
            IR.Show();

        }

        private void btn_como_Click(object sender, EventArgs e)
        {

            this.listBox1.Visible = true;
            this.button2.Visible = true;
            Stack<string> reglas = new Stack<string>();
            reglas.Push("7.-El jugador que llegue a la casilla 80 gana el juego");
            reglas.Push(" ");
            reglas.Push("   desciende por ésta hasta la casilla donde finaliza su cola");
            reglas.Push("   cae en una en donde comienza la  cabeza de una  serpiente,  ");
            reglas.Push("   la  casilla  donde  ésta  termina.  Si, por  el contrario,");
            reglas.Push("   casilla donde comienza una escalera,  sube por ella hasta");
            reglas.Push("6.-Si al finalizar un movimiento un jugador cae en una");
            reglas.Push(" ");
            reglas.Push("    resultado no tedra ningun efecto de avance en el tablero.");
            reglas.Push("    necesario  lanzar  el  dado  por  primera  vez  pero  el ");
            reglas.Push("5.- Para  poder  habilitar  la  ficha  de  cada  jugador  es  ");
            reglas.Push(" ");
            reglas.Push("   en sentido ascendente");
            reglas.Push("4.-Las fichas se mueven según la numeración del tablero,");
            reglas.Push(" ");
            reglas.Push("   cantidad de casillas que deben avanzar.");
            reglas.Push("   se turnan para lanzar el dado que  les  indicará  la ");
            reglas.Push("3.-Cada jugador Los jugadores comienzan con una ficha  y");
            reglas.Push(" ");
            reglas.Push("2.- Ingresa los nombres de los jugadores");
            reglas.Push(" ");
            reglas.Push("1.-Pulsa el boton jugar para comenzar");
            reglas.Push(" ");
            reglas.Push(" ");
            reglas.Push("                     INSTRUCCIONES:           ");
            listBox1.Items.Clear();
            foreach (string r in reglas)
            {
                listBox1.Items.Add(r);
            }

        }

        private void principal_Load(object sender, EventArgs e)
        {
            this.button2.Visible = false;
            this.listBox1.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.Visible=false;
            this.button2.Visible = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.listBox1.Visible = false;
            this.button2.Visible = false;
        }
    }
}
