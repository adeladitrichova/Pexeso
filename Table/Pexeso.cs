using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Security.Policy;
using System.Windows.Forms;
using Table.Properties;

namespace Table
{
    public partial class Pexeso : Form
    {
        int count = 0;
        protected bool pandi = false;
        public Pexeso()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
        

            if (pandi)
            {
                Random rnd = new Random();
                this.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                pandi = false;
                
            }
            else
            {
                Random rnd = new Random();
                pandi = true;
                this.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)); //this. = okno                                                                                   // pictureBoxN = picture box 300 iq ja vim
 
            }
            count++;
            if (count % 100 == 0)
            {
                this.pictureBox1.Image = Image.FromFile("../../../Resources/SILLY100smoll.png");
            }
            else if (count % 10 == 0)
                {
                    this.pictureBox1.Image = Image.FromFile("../../../Resources/SILLY23.png");
                }
            else
            {
                this.pictureBox1.Image = Image.FromFile("../../../Resources/SILLYsmoll.png");
            }

            pictureBox1.Location = new Point(Random.Shared.Next(1, this.Size.Width - 100), Random.Shared.Next(1, this.Size.Height - 100));
            
            label1.Text = "už jsi chytil: "+count.ToString()+ ((count > 1) ? ((count > 4) ? " pand" : " pandi") : " pandu");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}