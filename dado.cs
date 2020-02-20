using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serpientes_Escaleras
{
    class dado
    {
        public static int lanzar(PictureBox px)
        {
            int dado;
            Random sorteo = new Random();
            dado = sorteo.Next(1, 7);


            if (dado == 1)
            {
                px.Image = Image.FromFile("dado_1.png");
               
            }
            if (dado == 2)
            {
                px.Image = Image.FromFile("dado_2.png");
               
            }
            if (dado == 3)
            {
                px.Image = Image.FromFile("dado_3.png");
                
            }
            if (dado == 4)
            {
                px.Image = Image.FromFile("dado_4.png");
                
            }
            if (dado == 5)
            {
                px.Image = Image.FromFile("dado_5.png");
               ;
            }
            if (dado == 6)
            {
                px.Image = Image.FromFile("dado_6.png");
                
            }
            return dado;

        }
    }
}
