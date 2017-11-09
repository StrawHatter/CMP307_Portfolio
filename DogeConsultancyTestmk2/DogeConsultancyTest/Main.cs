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
    public partial class Main : Form
    {
        public string ShowMe { get; set; }
        //  public int image_card_no { get; set; }
        public int nran { get; set; }
        public int maxn { get; set; }
        public string id { get; set; }
        private System.Windows.Forms.Timer timer1;
        int timeLeft;

        public Main()
        {
            InitializeComponent();


        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Globals.maxn = 0;
            Globals.nran = 0;
            SqlConnection conn1;
            string connectionstring = "Data Source=vmwsql07.uad.ac.uk; Initial Catalog=sql1605044; User ID=sql1605044; Password=q?D46+il";
            conn1 = new SqlConnection(connectionstring);
            conn1.Open();
            string selectmax = "Select MAX(id) FROM dbo.DogeCards;";
            SqlCommand Command1 = new SqlCommand(selectmax);
            Command1.Connection = conn1;
           
            SqlDataReader dataR;
             dataR = Command1.ExecuteReader();

               while (dataR.Read())
                 {
                Globals.maxn = Int32.Parse(dataR[0].ToString());
                   }






         


            
            dataR.Close();
            conn1.Close();

            if (Globals.nran <= Globals.maxn)
            {
                Globals.nran = Globals.nran + 1;
            }
            else if (Globals.nran >= Globals.maxn)
            {
                MessageBox.Show("Training complete and data saved, please exit.");
            }

            SqlConnection conn2;
            string connectionstring2 = "Data Source=vmwsql07.uad.ac.uk; Initial Catalog=sql1605044; User ID=sql1605044; Password=q?D46+il";
            conn2 = new SqlConnection(connectionstring2);
            conn2.Open();
            string selectText = "Select * from dbo.DogeCards where id = " + Globals.nran + ";";
                SqlCommand Command2 = new SqlCommand(selectText);
                Command2.Connection = conn2;
            SqlDataReader dataR2;
            dataR2 = Command2.ExecuteReader();

            while (dataR2.Read())
            {
                Globals.id = dataR2[6].ToString();


            }










            dataR2.Close();
            conn2.Close();

            
            //  string pinsertStatement = "INSERT INTO dbo.customers(firstname, surname) VALUES('test','test')";
            // SqlCommand pinsertCommand = new SqlCommand(pinsertStatement, conn);
            //
            //         pinsertCommand.ExecuteNonQuery();














          //  image_card.ImageLocation = "http://mayar.abertay.ac.uk/~1605044/dogecards/" + Globals.nran + ".png";
            image_description.Text = Globals.id;
            //   image_description.Text = Globals.id;


            player_namem.Text = ShowMe;




            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 60000; // 1 minute
            timeLeft = 29;
            timer.Text = "30";
            timer1.Start();
        }



        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (Globals.nran < Globals.maxn)
            {
                Globals.nran = Globals.nran + 1;


                SqlConnection conn2;
                string connectionstring2 = "Data Source=vmwsql07.uad.ac.uk; Initial Catalog=sql1605044; User ID=sql1605044; Password=q?D46+il";
                conn2 = new SqlConnection(connectionstring2);
                conn2.Open();
                string selectText = "Select * from dbo.DogeCards where id = " + Globals.nran + ";";
                SqlCommand Command2 = new SqlCommand(selectText);
                Command2.Connection = conn2;
                SqlDataReader dataR2;
                dataR2 = Command2.ExecuteReader();

                while (dataR2.Read())
                {
                    Globals.id = dataR2[6].ToString();


                }
                dataR2.Close();
                conn2.Close();



               
           //     image_card.ImageLocation = "http://mayar.abertay.ac.uk/~1605044/dogecards/" + Globals.nran + ".png";
                image_description.Text = Globals.id;



                int score = Convert.ToInt32(score_l.Text);

                MessageBox.Show("yes event, example: correct decision");

                score = score + 1;

                score_l.Text = score.ToString();

            }
            else if (Globals.nran >= Globals.maxn)
            {
                MessageBox.Show("Training complete and data saved, please exit.");
            }
        }
    private void button2_Click(object sender, EventArgs e)
        {


            if (Globals.nran < Globals.maxn)
            {
                Globals.nran = Globals.nran + 1;






                SqlConnection conn2;
            string connectionstring2 = "Data Source=vmwsql07.uad.ac.uk; Initial Catalog=sql1605044; User ID=sql1605044; Password=q?D46+il";
            conn2 = new SqlConnection(connectionstring2);
            conn2.Open();
            string selectText = "Select * from dbo.DogeCards where id = " + Globals.nran + ";";
            SqlCommand Command2 = new SqlCommand(selectText);
            Command2.Connection = conn2;
            SqlDataReader dataR2;
            dataR2 = Command2.ExecuteReader();

            while (dataR2.Read())
            {
                Globals.id = dataR2[6].ToString();


               
            }
            dataR2.Close();
            conn2.Close();
           
           //     image_card.ImageLocation = "http://mayar.abertay.ac.uk/~1605044/dogecards/" + Globals.nran + ".png";
                image_description.Text = Globals.id;
            

           


            int score = Convert.ToInt32(score_l.Text);
            MessageBox.Show("no event, example: wrong decision");

            score = score + 0;

            score_l.Text = score.ToString();
            }
            else if (Globals.nran >= Globals.maxn)
            {
                MessageBox.Show("Training complete and data saved, please exit.");
            }
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft= timeLeft - 1;
                timer.Text = timeLeft.ToString();
            }
            else if (timeLeft == 0)
            {
                timer1.Stop();
                MessageBox.Show("Time up, data saved. Please exit.");
            }
        }
    }
    }

