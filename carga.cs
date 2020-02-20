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
    public partial class carga : Form
    {
        public carga()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void carga_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }
        public void fn_prbar()
        {
            progressBar1.Increment(1);
            label1.Text = progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == progressBar1.MarqueeAnimationSpeed)
            {
                timer1.Stop();
                this.Hide();
                principal ir = new principal();
                ir.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fn_prbar();
        }
    }
}
