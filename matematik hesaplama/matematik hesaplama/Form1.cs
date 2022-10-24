using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matematik_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int birkenar;
            int alan, çevre;


            birkenar = Convert.ToInt32(textBox3.Text);
            alan = birkenar * birkenar;
            çevre = 4 * birkenar;
            label13.Text = alan.ToString();
            label8.Text = çevre.ToString();

                




      

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

            label13.Visible = false;
            textBox4.Visible = false;
            label7.Text = "KARE";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = "DİKDÖRTGEN";
            label13.Text = "KISA KENAR";
        }
    }
}
