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
        public string CopyUser { get; set; }
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
            Globals.pop = 50;
            Globals.wealth = 50;
            popularity_score.Text = Globals.pop.ToString();
            wealth_score.Text = Globals.wealth.ToString();
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
                ExistCheck3:
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

                    Globals.nran = System.Convert.ToInt32(Command2.ExecuteScalar());//change nran to id from execute scalar

                    SqlDataReader dataR2;
                    dataR2 = Command2.ExecuteReader();

                    while (dataR2.Read())
                    {
                        Globals.id = dataR2[6].ToString();
                        Globals.nran = System.Convert.ToInt32(dataR2[0]);
                        Globals.url = dataR2[5].ToString();
                        Globals.wealthy = System.Convert.ToInt32(dataR2[1]);
                        Globals.wealthn = System.Convert.ToInt32(dataR2[2]);
                        Globals.popy = System.Convert.ToInt32(dataR2[3]);
                        Globals.popn = System.Convert.ToInt32(dataR2[4]);

                    }
                    dataR2.Close();
                    conn2.Close();






                }
                else if (exists == 0)
                {


                    goto ExistCheck3;

                }
                image_card.ImageLocation = Globals.url;
                image_description.Text = Globals.id;





                player_namem.Text = CopyUser;




                timer1 = new System.Windows.Forms.Timer();
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Interval = 60000; // 1 minute
                timeLeft = 29;
                timer.Text = "30";
                timer1.Start();
            }
        }


        private void yes_button_Click(object sender, EventArgs e)
        {
            Globals.score = Globals.score + Globals.popy;
            Globals.pop = Globals.pop + Globals.popy;
            Globals.wealth = Globals.wealth + Globals.wealthn;

            if (Globals.pop > 100)
            {
                Globals.pop = 100;
            }

            if (Globals.wealth > 100)
            {
                Globals.wealth = 100;
            }
            popularity_score.Text = Globals.pop.ToString();
            wealth_score.Text = Globals.wealth.ToString();
            total_score.Text = Globals.score.ToString();

            if (Globals.pop < 1)
            {
                popularity_score.Text = "0";
                MessageBox.Show("Your popularity reached 0! Please try again.");
                EndGame endgame = new EndGame();
                endgame.Show();
                this.Hide();
            }
            else if (Globals.wealth < 1)
            {
                wealth_score.Text = "0";
                MessageBox.Show("Your earnings reached 0! Please try again.");
                EndGame endgame = new EndGame();
                endgame.Show();
                this.Hide();
            }
            else
            {
                if (Globals.nran < Globals.maxn)
                {
                ExistCheck:
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

                        Globals.nran = System.Convert.ToInt32(Command2.ExecuteScalar());//change nran to id from execute scalar

                        SqlDataReader dataR2;
                        dataR2 = Command2.ExecuteReader();

                        while (dataR2.Read())
                        {
                            Globals.id = dataR2[6].ToString();
                            Globals.nran = System.Convert.ToInt32(dataR2[0]);
                            Globals.url = dataR2[5].ToString();
                            Globals.wealthy = System.Convert.ToInt32(dataR2[1]);
                            Globals.wealthn = System.Convert.ToInt32(dataR2[2]);
                            Globals.popy = System.Convert.ToInt32(dataR2[3]);
                            Globals.popn = System.Convert.ToInt32(dataR2[4]);

                        }
                        dataR2.Close();
                        conn2.Close();






                    }
                    else if (exists == 0)
                    {


                        goto ExistCheck;

                    }
                    image_card.ImageLocation = Globals.url;
                    image_description.Text = Globals.id;

                    int score = Convert.ToInt32(total_score.Text);

                }
                else if (Globals.nran >= Globals.maxn)
                {
                    MessageBox.Show("Training complete.");
                    EndGame endgame = new EndGame();
                    endgame.Show();
                    this.Hide();
                }
            }
        }


        private void no_button_Click(object sender, EventArgs e)
        {
            Globals.score = Globals.score + Globals.wealthy;
            Globals.pop = Globals.pop + Globals.popn;
            Globals.wealth = Globals.wealth + Globals.wealthy;

            if (Globals.pop > 100)
            {
                Globals.pop = 100;
            }

            if (Globals.wealth > 100)
            {
                Globals.wealth = 100;
            }

            popularity_score.Text = Globals.pop.ToString();
            wealth_score.Text = Globals.wealth.ToString();
            total_score.Text = Globals.score.ToString();

            if (Globals.pop < 1)
            {
                popularity_score.Text = "0";
                MessageBox.Show("Your popularity reached 0! Please try again.");
                EndGame endgame = new EndGame();
                endgame.Show();
                this.Hide();
            }
            else if (Globals.wealth < 1)
            {
                wealth_score.Text = "0";
                MessageBox.Show("Your earnings reached 0! Please try again.");
                EndGame endgame = new EndGame();
                endgame.Show();
                this.Hide();
            }
            else
            {
                if (Globals.nran < Globals.maxn)
                {
                Existcheck2:

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


                        Globals.nran = System.Convert.ToInt32(Command2.ExecuteScalar());//change nran to id from execute scalar

                        SqlDataReader dataR2;
                        dataR2 = Command2.ExecuteReader();

                        while (dataR2.Read())
                        {
                            Globals.id = dataR2[6].ToString();
                            Globals.nran = System.Convert.ToInt32(dataR2[0]);
                            Globals.url = dataR2[5].ToString();
                            Globals.wealthy = System.Convert.ToInt32(dataR2[1]);
                            Globals.wealthn = System.Convert.ToInt32(dataR2[2]);
                            Globals.popy = System.Convert.ToInt32(dataR2[3]);
                            Globals.popn = System.Convert.ToInt32(dataR2[4]);

                        }
                        dataR2.Close();
                        conn2.Close();






                    }
                    else if (exists == 0)
                    {


                        goto Existcheck2;

                    }
                    image_card.ImageLocation = Globals.url;
                    image_description.Text = Globals.id;
                    int score = Convert.ToInt32(total_score.Text);


                }
                else if (Globals.nran >= Globals.maxn)
                {
                    MessageBox.Show("Training complete.");
                    EndGame endgame = new EndGame();
                    endgame.Show();
                    this.Hide();
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                MessageBox.Show("Out of time!");
                EndGame endgame = new EndGame();
                endgame.Show();
                this.Hide();
            }
        }


        private void help_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use the left and right buttons located next to the image at the center of the page. "+"\n"+ "Click left button = Yes."+"\n"+"Click right button= No."+"\n"+"The button at the top right ('x') can be used to exit the program at any time.","Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    }

