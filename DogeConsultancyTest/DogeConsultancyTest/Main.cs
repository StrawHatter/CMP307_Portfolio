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


        //timer related variables
        private System.Windows.Forms.Timer timer1;
        int timeLeft;

        public Main()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            //intialise variables
            Globals.maxn = 0;
            Globals.cardid = 0;
            Globals.pop = 50;
            Globals.wealth = 50;

            //setup popularity and earnings counters
            popularity_score.Text = Globals.pop.ToString();
            wealth_score.Text = Globals.wealth.ToString();

            //get id of last card from database
            Globals.conn.Open();
            string selectmax = "Select MAX(id) FROM dbo.DogeCards;";
            SqlCommand Command1 = new SqlCommand(selectmax);
            Command1.Connection = Globals.conn;

            SqlDataReader dataR;
            dataR = Command1.ExecuteReader();

            while (dataR.Read())
            {
                //sets the id of the last card as the ma number of cards
                Globals.maxn = Int32.Parse(dataR[0].ToString());
            }

            
            dataR.Close();
            Globals.conn.Close();
            //checks to make sure max no of cards has not yet been reached
            if (Globals.cardid < Globals.maxn)
            {
                ExistCheck3:
                Globals.cardid = Globals.cardid + 1;

                //gets data for next card
                Globals.conn.Open();
                string selectText = "Select * from dbo.DogeCards where id = " + Globals.cardid + ";";
                SqlCommand Command2 = new SqlCommand(selectText);
                Command2.Connection = Globals.conn;
                //returns value of next id in database (if row doesn't exist then returns 0)
                int exists = System.Convert.ToInt32(Command2.ExecuteScalar());

                //if value exists
                if (exists > 0)
                {

                    Globals.cardid = System.Convert.ToInt32(Command2.ExecuteScalar());//change cardid to id from execute scalar

                    SqlDataReader dataR2;
                    dataR2 = Command2.ExecuteReader();
                    //get all card data
                    while (dataR2.Read())
                    {
                        Globals.id = dataR2[6].ToString();
                        Globals.cardid = System.Convert.ToInt32(dataR2[0]);
                        Globals.url = dataR2[5].ToString();
                        Globals.wealthy = System.Convert.ToInt32(dataR2[1]);
                        Globals.wealthn = System.Convert.ToInt32(dataR2[2]);
                        Globals.popy = System.Convert.ToInt32(dataR2[3]);
                        Globals.popn = System.Convert.ToInt32(dataR2[4]);

                    }
                    dataR2.Close();
                    Globals.conn.Close();






                }
                //if executescalar returns null then go back and try again with next row in database
                else if (exists == 0)
                {

                    Globals.conn.Close();
                    goto ExistCheck3;

                }
                //display all card data
                image_card.ImageLocation = Globals.url;
                image_description.Text = Globals.id;




                //loads name onto form
                player_namem.Text = Globals.usernamesend.ToString();



                //initialise the timer
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
            //update the popualarity, earnings and total score variables
            Globals.score = Globals.score + Globals.popy;
            Globals.pop = Globals.pop + Globals.popy;
            Globals.wealth = Globals.wealth + Globals.wealthn;

            //cap popularity and wealth at 100
            if (Globals.pop > 100)
            {
                Globals.pop = 100;
            }

            if (Globals.wealth > 100)
            {
                Globals.wealth = 100;
            }
            //update popularity, wealth and total score on form
            popularity_score.Text = Globals.pop.ToString();
            wealth_score.Text = Globals.wealth.ToString();
            total_score.Text = Globals.score.ToString();

            //end game if popularity  or wealth reaches 0
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
                //check if current card is not last card in database
                if (Globals.cardid < Globals.maxn)
                {
                ExistCheck:
                    Globals.cardid = Globals.cardid + 1;

                    //get next card data
                    Globals.conn.Open();
                    string selectText = "Select * from dbo.DogeCards where id = " + Globals.cardid + ";";
                    SqlCommand Command2 = new SqlCommand(selectText);
                    Command2.Connection = Globals.conn;


                    //returns value of next id in database (if row doesn't exist then returns 0)
                    int exists = System.Convert.ToInt32(Command2.ExecuteScalar());

                    //if card exists
                    if (exists > 0)
                    {

                        Globals.cardid = System.Convert.ToInt32(Command2.ExecuteScalar());//change cardid to id from execute scalar

                        SqlDataReader dataR2;
                        dataR2 = Command2.ExecuteReader();
                        //get all card data
                        while (dataR2.Read())
                        {
                            Globals.id = dataR2[6].ToString();
                            Globals.cardid = System.Convert.ToInt32(dataR2[0]);
                            Globals.url = dataR2[5].ToString();
                            Globals.wealthy = System.Convert.ToInt32(dataR2[1]);
                            Globals.wealthn = System.Convert.ToInt32(dataR2[2]);
                            Globals.popy = System.Convert.ToInt32(dataR2[3]);
                            Globals.popn = System.Convert.ToInt32(dataR2[4]);

                        }
                        dataR2.Close();
                        Globals.conn.Close();






                    }
                    else if (exists == 0)
                    {
                        //if executescalar returns null then go back and try again with next row in database

                        Globals.conn.Close();
                        goto ExistCheck;

                    }
                    //display card details
                    image_card.ImageLocation = Globals.url;
                    image_description.Text = Globals.id;

                    int score = Convert.ToInt32(total_score.Text);

                }
                else if (Globals.cardid >= Globals.maxn)
                {
                    //if card is last in database then end game
                    EndGame endgame = new EndGame();
                    endgame.Show();
                    this.Hide();
                }
            }
        }


        private void no_button_Click(object sender, EventArgs e)
        {
            //update the popualarity, earnings and total score variables
            Globals.score = Globals.score + Globals.wealthy;
            Globals.pop = Globals.pop + Globals.popn;
            Globals.wealth = Globals.wealth + Globals.wealthy;
          
            //cap popularity and wealth at 100
            if (Globals.pop > 100)
            {
                Globals.pop = 100;
            }

            if (Globals.wealth > 100)
            {
                Globals.wealth = 100;
            }


            //update popularity, wealth and total score on form
            popularity_score.Text = Globals.pop.ToString();
            wealth_score.Text = Globals.wealth.ToString();
            total_score.Text = Globals.score.ToString();


            //end game if popularity  or wealth reaches 0
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
                //check if current card is not last card in database
                if (Globals.cardid < Globals.maxn)
                {
                Existcheck2:

                    Globals.cardid = Globals.cardid + 1;

                    //get next card data
                    Globals.conn.Open();
                    string selectText = "Select * from dbo.DogeCards where id = " + Globals.cardid + ";";
                    SqlCommand Command2 = new SqlCommand(selectText);
                    Command2.Connection = Globals.conn;


                    //returns value of next id in database (if row doesn't exist then returns 0)
                    int exists = System.Convert.ToInt32(Command2.ExecuteScalar());

                    //if card exists
                    if (exists > 0)
                    {


                        Globals.cardid = System.Convert.ToInt32(Command2.ExecuteScalar());//change cardid to id from execute scalar

                        SqlDataReader dataR2;
                        dataR2 = Command2.ExecuteReader();

                        //get all card data
                        while (dataR2.Read())
                        {
                            Globals.id = dataR2[6].ToString();
                            Globals.cardid = System.Convert.ToInt32(dataR2[0]);
                            Globals.url = dataR2[5].ToString();
                            Globals.wealthy = System.Convert.ToInt32(dataR2[1]);
                            Globals.wealthn = System.Convert.ToInt32(dataR2[2]);
                            Globals.popy = System.Convert.ToInt32(dataR2[3]);
                            Globals.popn = System.Convert.ToInt32(dataR2[4]);

                        }
                        dataR2.Close();
                        Globals.conn.Close();






                    }
                    else if (exists == 0)
                    {
                        //if executescalar returns null then go back and try again with next row in database
                        Globals.conn.Close();
                        goto Existcheck2;

                    }

                    //display card details
                    image_card.ImageLocation = Globals.url;
                    image_description.Text = Globals.id;
                    int score = Convert.ToInt32(total_score.Text);


                }
                else if (Globals.cardid >= Globals.maxn)
                {
                    //if card is last in database then end game
                    EndGame endgame = new EndGame();
                    endgame.Show();
                    this.Hide();
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            //exit button
            Application.Exit();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //code for timer
            int timeleftdis;
            if (timeLeft > 0)
            {
                //code for counting timer down
                timeLeft= timeLeft - 1;
                timeleftdis = timeLeft + 1;
                timer.Text = timeleftdis.ToString();
            }
            else if (timeLeft == 0)
            {
                timer.Text = "0";
                timer1.Stop();
                MessageBox.Show("Out of time!");
                //ends game if timer reaches 0
                EndGame endgame = new EndGame();
                endgame.Show();
                this.Hide();
            }
        }


        private void help_button_Click(object sender, EventArgs e)
        {
            //help button code
            MessageBox.Show("Use the left and right buttons located next to the image at the center of the page. "+"\n"+ "Click left button = Yes."+"\n"+"Click right button= No."+"\n"+"The button at the top right ('x') can be used to exit the program at any time.","Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    }

