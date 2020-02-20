using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serpientes_Escaleras
{
    public partial class jugadores : Form
    {
        public string jugador1, jugador2;
        int p;
        public jugadores()
        {
            InitializeComponent();
        }
        Queue micola = new Queue();

        private void button1_Click(object sender, EventArgs e)
        {

            jugador1 = (textBox1.Text);
            jugador2 = (textBox2.Text);

            micola.Enqueue(textBox1.Text);
            micola.Enqueue(textBox2.Text);
            listBox1.Items.Clear();
            foreach (string a in micola)
            {
                listBox1.Items.Add(a);
            }

            Form1 IR = new Form1();
            IR.label5.Text = textBox1.Text;
            IR.label6.Text = textBox2.Text;
            //this.Hide();
            IR.Show();

           


        }

            private void button2_Click(object sender, EventArgs e)
            {
                principal IR = new principal();
                this.Hide();
                IR.Show();

            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void jugadores_Load(object sender, EventArgs e)
            {

            }

            private void button3_Click(object sender, EventArgs e)
            {
                micola.Clear();
                textBox1.Clear();
                textBox2.Clear();
            }

            private void mostrar_Click(object sender, EventArgs e)
            {

            }
        }
    }
