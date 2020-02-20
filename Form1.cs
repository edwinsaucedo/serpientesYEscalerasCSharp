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
    public partial class Form1 : Form
    {
        string jugador1;
         int score = 0,score2=0;
        int banderazo = 0;//turno rojo
        //int[] pos = new int[81];
        bool rojo = false, azul=false;
        int segundos=0;
        int x = 16, y = 406, p =0;
        int bx = 16, by = 406, a=0;
        
        public Form1()
        {
            InitializeComponent();
           
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Deseas salir del jeugo?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            else
            {
                principal ir = new principal();
                ir.Visible = true;
                Visible = false;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox83_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int dado;
            
            Random sorteo = new Random();
            dado = sorteo.Next(1, 7);
            

            if (dado == 1)
            {
                pictureBoxdado2.Image = Image.FromFile("dado_1.png");
                labeldado2.Text = dado.ToString();
            }
            if (dado == 2)
            {
                pictureBoxdado2.Image = Image.FromFile("dado_2.png");
                labeldado2.Text = dado.ToString();
            }
            if (dado == 3)
            {
                pictureBoxdado2.Image = Image.FromFile("dado_3.png");
                labeldado2.Text = dado.ToString();
            }
            if (dado == 4)
            {
                pictureBoxdado2.Image = Image.FromFile("dado_4.png");
                labeldado2.Text = dado.ToString();
            }
            if (dado == 5)
            {
                pictureBoxdado2.Image = Image.FromFile("dado_5.png");
                labeldado2.Text = dado.ToString();
            }
            if (dado == 6)
            {
                pictureBoxdado2.Image = Image.FromFile("dado_6.png");
                labeldado2.Text = dado.ToString();
            }
//////---------------DADO--------
            if (azul == true)
            {
                a = coordenadas.movimiento(ref bx, ref by, a, dado, pictureBox5, label18);
                label11.Text = a.ToString();
            }

            if ((labeldado2.Text == "6"|| labeldado2.Text == "5"|| labeldado2.Text == "4" || labeldado2.Text == "3" || labeldado2.Text == "2"|| labeldado2.Text == "1") && azul == false)
            {
                pictureBox5.Visible = true;
                pictureBox3.Visible = false;
                azul = true;
                pictureBox5.Location = new Point(x, y);
                label7.Text = x.ToString();
                label10.Text = y.ToString();
                label12.Text = a.ToString();
                a++;

            }
            if (a == 80)
            {
                MessageBox.Show("Eres el Ganador.....:D");
                button3.Enabled = false;
                score += 1;
                Recorrido IR = new Recorrido(p, a);

                IR.Show();

            }
            a = coordenadas.serpientescord(ref bx, ref by, a, pictureBox5);
            a = coordenadas.escalerascord(ref bx, ref by, a, pictureBox5);
            label12.Text = a.ToString();

            if (dado == 6)
            {
                banderazo = 1;
            }
            else
            {
                banderazo = 0;
                button3.Enabled = false;
                button1.Enabled = true;
                label17.Text = "turno de: "+label5.Text;//j1
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dado;
            Random sorteo = new Random();
            dado = sorteo.Next(1, 7);


            if (dado == 1)
            {
                pictureBox2.Image = Image.FromFile("dado_1.png");
                label1.Text = dado.ToString();
            }
            if (dado == 2)
            {
                pictureBox2.Image = Image.FromFile("dado_2.png");
                label1.Text = dado.ToString();
            }
            if (dado == 3)
            {
                pictureBox2.Image = Image.FromFile("dado_3.png");
                label1.Text = dado.ToString();
            }
            if (dado == 4)
            {
                pictureBox2.Image = Image.FromFile("dado_4.png");
                label1.Text = dado.ToString();
            }
            if (dado == 5)
            {
                pictureBox2.Image = Image.FromFile("dado_5.png");
                label1.Text = dado.ToString();
            }
            if (dado == 6)
            {
                pictureBox2.Image = Image.FromFile("dado_6.png");
                label1.Text = dado.ToString();
            }

            //----------------DADO--------
            if (rojo == true)
            {
               p= coordenadas.movimiento(ref x, ref y,  p, dado,  pictureBox4, label18);
                label9.Text = p.ToString();

            }


            if ((label1.Text=="6"|| label1.Text == "5"|| label1.Text == "4"|| label1.Text == "3"|| label1.Text == "2"|| label1.Text == "1" ) && rojo==false)
            {
                pictureBox4.Visible = true;
                pictureBox1.Visible = false;
                rojo = true;
                pictureBox4.Location = new Point(x, y);
                label7.Text = x.ToString();
                label8.Text = y.ToString();
                label10.Text = p.ToString();
                p++;
              
            }
            if(p==80)
            {
                MessageBox.Show("Eres el Ganador.....:D");
                button1.Enabled = false;
                // score2 += 1;
                Recorrido IR = new Recorrido(p,a);

                IR.Show();


            }
            p = coordenadas.serpientescord(ref x, ref y, p, pictureBox4);
            p = coordenadas.escalerascord(ref x, ref y, p, pictureBox4);
            label9.Text = p.ToString();

            if(dado==6)
            {
                banderazo = 0;
            }
            else {
                banderazo = 1;
                button1.Enabled = false;
                button3.Enabled = true;
                label17.Text = "turno de: "+label6.Text;//j2
                
               
            }

        }

        

      



        private void label1_Click(object sender, EventArgs e)
        {

        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            label11.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label10.Visible = false;
            label18.Visible = false;
            if (banderazo==0)
            {
                button3.Enabled = false;
                label17.Text = "turno de: "+label5.Text;
            }
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            
 


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           

        }

        private void estadoDeJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recorrido IR = new Recorrido(p, a);

            IR.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        
    }
}
