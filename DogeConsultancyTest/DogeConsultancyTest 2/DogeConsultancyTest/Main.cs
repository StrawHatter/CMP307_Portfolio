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

                int exists = System.Convert.ToInt32(Command2.ExecuteScalar());


                if (exists > 0)
                {
                    //Username exist
                    MessageBox.Show(exists.ToString());
                    Globals.nran = System.Convert.ToInt32(Command2.ExecuteScalar());//change nran to id from execute scalar

                    SqlDataReader dataR2;
                    dataR2 = Command2.ExecuteReader();

                    while (dataR2.Read())
                    {
                        Globals.id = dataR2[6].ToString();
                        Globals.nran = System.Convert.ToInt32(dataR2[0]);

                    }
                    dataR2.Close();
                    conn2.Close();






                }
                else if (exists == 0)
                {




                    Globals.nran = Globals.nran + 1;
                    MessageBox.Show(Globals.nran.ToString());
                    SqlConnection conn3;
                    string connectionstring3 = "Data Source=vmwsql07.uad.ac.uk; Initial Catalog=sql1605044; User ID=sql1605044; Password=q?D46+il";
                    conn3 = new SqlConnection(connectionstring3);
                    conn3.Open();
                    string selectText2 = "Select * from dbo.DogeCards where id = " + Globals.nran + ";";
                    SqlCommand Command3 = new SqlCommand(selectText2);
                    Command3.Connection = conn3;


                    SqlDataReader dataR3;
                    dataR3 = Command3.ExecuteReader();
                    while (dataR3.Read())
                    {
                        Globals.id = dataR3[6].ToString();
                        Globals.nran = System.Convert.ToInt32(dataR3[0]);
                        MessageBox.Show(Globals.nran.ToString());
                    }
                    dataR3.Close();
                    conn3.Close();
                }
                image_card.ImageLocation = "http://mayar.abertay.ac.uk/~1605044/dogecards/" + Globals.nran + ".png";
                image_description.Text = Globals.id;




















                player_namem.Text = ShowMe;




                timer1 = new System.Windows.Forms.Timer();
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Interval = 60000; // 1 minute
                timeLeft = 29;
                timer.Text = "30";
                timer1.Start();
            }
        }



        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
        
        }

        private void yes_button_Click(object sender, EventArgs e)
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

                int exists = System.Convert.ToInt32(Command2.ExecuteScalar());


                if (exists > 0)
                {
                    //Username exist
                    MessageBox.Show(exists.ToString());
                    Globals.nran = System.Convert.ToInt32(Command2.ExecuteScalar());//change nran to id from execute scalar

                    SqlDataReader dataR2;
                    dataR2 = Command2.ExecuteReader();

                    while (dataR2.Read())
                    {
                        Globals.id = dataR2[6].ToString();
                        Globals.nran = System.Convert.ToInt32(dataR2[0]);

                    }
                    dataR2.Close();
                    conn2.Close();






                }
                else if (exists == 0)
                {




                    Globals.nran = Globals.nran + 1;
                    MessageBox.Show(Globals.nran.ToString());
                    SqlConnection conn3;
                    string connectionstring3 = "Data Source=vmwsql07.uad.ac.uk; Initial Catalog=sql1605044; User ID=sql1605044; Password=q?D46+il";
                    conn3 = new SqlConnection(connectionstring3);
                    conn3.Open();
                    string selectText2 = "Select * from dbo.DogeCards where id = " + Globals.nran + ";";
                    SqlCommand Command3 = new SqlCommand(selectText2);
                    Command3.Connection = conn3;


                    SqlDataReader dataR3;
                    dataR3 = Command3.ExecuteReader();
                    while (dataR3.Read())
                    {
                        Globals.id = dataR3[6].ToString();
                        Globals.nran = System.Convert.ToInt32(dataR3[0]);
                        MessageBox.Show(Globals.nran.ToString());
                    }
                    dataR3.Close();
                    conn3.Close();
                }
                image_card.ImageLocation = "http://mayar.abertay.ac.uk/~1605044/dogecards/" + Globals.nran + ".png";
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
    private void no_button_Click(object sender, EventArgs e)
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

                int exists = System.Convert.ToInt32(Command2.ExecuteScalar());
                

                if (exists > 0)
                {
                    //Username exist
                    MessageBox.Show(exists.ToString());
                    Globals.nran = System.Convert.ToInt32(Command2.ExecuteScalar());//change nran to id from execute scalar

                    SqlDataReader dataR2;
                    dataR2 = Command2.ExecuteReader();

                    while (dataR2.Read())
                    {
                        Globals.id = dataR2[6].ToString();
                        Globals.nran = System.Convert.ToInt32(dataR2[0]);

                    }
                    dataR2.Close();
                    conn2.Close();






                }
                else if (exists == 0)
                {


                   

                    Globals.nran = Globals.nran + 1;
                    MessageBox.Show(Globals.nran.ToString());
                    SqlConnection conn3;
                    string connectionstring3 = "Data Source=vmwsql07.uad.ac.uk; Initial Catalog=sql1605044; User ID=sql1605044; Password=q?D46+il";
                    conn3 = new SqlConnection(connectionstring3);
                    conn3.Open();
                    string selectText2 = "Select * from dbo.DogeCards where id = " + Globals.nran + ";";
                    SqlCommand Command3 = new SqlCommand(selectText2);
                    Command3.Connection = conn3;


                    SqlDataReader dataR3;
                    dataR3 = Command3.ExecuteReader();
                    while (dataR3.Read())
                    {
                        Globals.id = dataR3[6].ToString();
                        Globals.nran = System.Convert.ToInt32(dataR3[0]);
                        MessageBox.Show(Globals.nran.ToString());
                    }
                    dataR3.Close();
                    conn3.Close();
                }
                image_card.ImageLocation = "http://mayar.abertay.ac.uk/~1605044/dogecards/" + Globals.nran + ".png";
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

        private void help_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use the left and right buttons located next to the image at the center of the page. "+"\n"+ "Click left button = Yes."+"\n"+"Click right button= No."+"\n"+"The button at the top right ('x') can be used to exit the program at any time.","Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    }

