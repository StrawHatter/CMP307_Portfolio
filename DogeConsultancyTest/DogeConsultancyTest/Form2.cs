using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogeConsultancyTest
{
    public partial class Form2 : Form
    {
        public string ShowMe { get; set; }
        

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

            player_namem.Text = ShowMe;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int score = Convert.ToInt32(score_l.Text);

            MessageBox.Show("yes event, example: correct decision");

            score = score + 1;

            score_l.Text = score.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int score = Convert.ToInt32(score_l.Text);
            MessageBox.Show("no event, example: wrong decision");

            score = score + 0;

            score_l.Text = score.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
