using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace DogeConsultancyTest
{
    public partial class Form2 : Form
    {
        public string ShowMe { get; set; }
      //  public int image_card_no { get; set; }
        public int nran { get; set; }
        

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {


            SqlConnection conn;
            string connectionstring = "Data Source=vmwsql07.uad.ac.uk; Initial Catalog=sql1605044; User ID=sql1605044; Password=q?D46+il";
            conn = new SqlConnection(connectionstring);



            Random random = new Random();
            int randomNumber = random.Next(1, 10);

            Globals.nran = randomNumber;
            string selectText = "Select * from dbo.DogeCards where id = " + Globals.nran + ";";
            SqlCommand Command = new SqlCommand(selectText);
            Command.Connection = conn;

            SqlDataReader dataR;
            dataR = Command.ExecuteReader();

            dataR.Close();










            image_card.ImageLocation = "http://mayar.abertay.ac.uk/~1605044/dogecards/"+Globals.nran+".png";
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

 
    }
}
