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
    public partial class Recorrido : Form
    {
        public Recorrido(int p,int a)
        {
            InitializeComponent();
            //this.score = score;
            //this.score2 = score2;
            this.p = p;
            this.a = a;
            //this.jugador1 = jugador1;
        }
        
        List<int> lista_recorrido = new List<int>();
        int score,score2;
        int p,a;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        string jugador1;
        private void Recorrido_Load(object sender, EventArgs e)
        {
            

            //pos1 = IR.label9.Text;
            //IR.label2.Text = textBox2.Text;
          
                textBox1.Text = Convert.ToString(p);
                lista_recorrido.Add(p);

            
                textBox2.Text = Convert.ToString(a);
                lista_recorrido.Add(a);

           textBox3.Text= Convert.ToString( lista_recorrido.Average());
            textBox4.Text = Convert.ToString(lista_recorrido.Max());
            textBox5.Text = Convert.ToString(lista_recorrido.Min());

            //lista_recorrido.Add(jugador1);

            listBox2.Items.Clear();
                foreach (int a in lista_recorrido)
                {
                    listBox2.Items.Add(a);
                }
         

            //dos
        }
    }
}
