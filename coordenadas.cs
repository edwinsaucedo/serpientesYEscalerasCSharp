using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Serpientes_Escaleras
{
    class coordenadas
    {
        public static int  movimiento(ref int x, ref int y, int p,int dado,PictureBox px,Label l )
        {

            if (dado + p > 80)
            {
                MessageBox.Show("No puedes avanzar, te pasas de la raya D;");
            }
            else
            {
                for (int i = 0; i < dado; i++)
                {
                    if (p == 10)
                    {
                        x = 19;
                        y = 354;
                        

                    }
                    else if (p == 20)
                    {
                        x = 19;
                        y = 293;
                        

                    }
                    else if (p == 30)
                    {
                        x = 19;
                        y = 247;
                        

                    }
                    else if (p == 40)
                    {
                        x = 19;
                        y = 189;
                        

                    }

                    else if (p == 50)
                    {
                        x = 19;
                        y = 130;
                        

                    }
                    else if (p == 60)
                    {
                        x = 19;
                        y = 69;
                        
                    }
                    else if (p == 70)
                    {
                        x = 19;
                        y = 13;
                        
                    }

                    //----------------validacion para escalras---------------


                    else
                    {
                        x += 65;
                        l.Text = p.ToString();
                    }
                    l.Text = p.ToString();
                    px.Location = new Point(x, y);
                    p++;
                    
                }///for

            }
            return p;
            
        }//////metodo

        public static int serpientescord(ref int x,ref int y,int p,PictureBox px)
        {
            if(p==25)
            {
                MessageBox.Show("Te toco una serpientes :(");
                x = 406;
                y = 354;
                p = 17;
                
            }
            else if (p == 44)
            {
                MessageBox.Show("Te toco una serpientes :(");
                x = 212;
                y = 411;
                p = 4;
                
            }
            else if (p == 50)
            {
                MessageBox.Show("Te toco una serpientes :(");
                x = 532;
                y = 247;
                p = 39;
                
            }
            else if (p == 79)
            {
                MessageBox.Show("Te toco una serpientes :(");
                x = 406;
                y = 79;
                p = 67;
                
            }
            else if (p == 61)
            {
                MessageBox.Show("Te toco una serpientes :(");
                x = 86;
                y = 189;
                p = 42;
                
            }
            px.Location = new Point(x, y);
            return p;
        }//metodo serpientes

        public static int escalerascord(ref int x, ref int y, int p, PictureBox px)
        {
            if(p == 8)
            {
                MessageBox.Show("Escaleraaaa :D sube a la casilla");
                x = 409;
                y = 303;
                p = 27;

            }
            else if (p == 12)
            {
                MessageBox.Show("Escaleraaaa :D sube a la casilla");
                x = 150;
                y = 303;
                p = 23;

            }
            else if (p == 37)
            {
                MessageBox.Show("Escaleraaaa :D sube a la casilla");
                x = 341;
                y = 79;
                p = 66;

            }
            else if (p == 58)
            {
                MessageBox.Show("Escaleraaaa :D sube a la casilla");
                x = 535;
                y = 79;
                p = 69;

            }
            else if (p == 64)
            {
                MessageBox.Show("Escaleraaaa :D sube a la casilla");
                x = 281;
                y = 13;
                p = 75;

            }
            px.Location = new Point(x, y);
            return p;
        }


    }
}