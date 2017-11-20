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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void exit_admin_Click(object sender, EventArgs e)
        {
            //Closes the program
            Welcome Welcome = new Welcome();
            Welcome.Show();
            this.Hide();
        }

        private void remove_submit_Click(object sender, EventArgs e)
        {
           //stores the id of the row to be removed from the database
           string chosenremoveid = remove_list.Text;

            //sql command to delete chosen row from database
            Globals.conn.Open();
            string deletestring = "Delete FROM dbo.DogeCards where id = @chosenremoveid;";
            SqlCommand Command = new SqlCommand(deletestring);
            Command.Parameters.AddWithValue("@chosenremoveid", chosenremoveid);
            Command.Connection = Globals.conn;
            Command.ExecuteNonQuery();

            Globals.conn.Close();
            //repopulate the combo box
            remove_list.Text = "";
            remove_list.Items.Clear();
            Globals.conn.Open();
            string selectstring2 = "Select id FROM dbo.DogeCards;";
            SqlCommand Command2 = new SqlCommand(selectstring2);
            Command2.Connection = Globals.conn;

            SqlDataReader dataR2;
            dataR2 = Command2.ExecuteReader();

            while (dataR2.Read())
            {
                remove_list.Items.Add(dataR2[0]);
            }


            dataR2.Close();
            Globals.conn.Close();
            //deletion confirmation message
            MessageBox.Show("Data for ID "+chosenremoveid+" has been removed.");

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            //dislays admin user ID on form
            welcome_admin.Text = "Welcome "+Globals.usernamesend;
            Globals.conn.Open();
            string selectstring = "Select id FROM dbo.DogeCards;";
            SqlCommand Command1 = new SqlCommand(selectstring);
            Command1.Connection = Globals.conn;

            SqlDataReader dataR;
            dataR = Command1.ExecuteReader();
            //populates combo box with id numbers
            while (dataR.Read())
            {
                remove_list.Items.Add(dataR[0]);
            }


            dataR.Close();
            Globals.conn.Close();



        }

        private void add_submit_Click(object sender, EventArgs e)
        {
            //input validation variables
            int eps;
            int ens;
            int pps;
            int pns;

            //input validation
            if (string.IsNullOrEmpty(image_description_input.Text) || string.IsNullOrEmpty(e_pos_score.Text) || string.IsNullOrEmpty(e_neg_score.Text) || string.IsNullOrEmpty(p_pos_score.Text) || string.IsNullOrEmpty(p_neg_score.Text) || !int.TryParse(e_pos_score.Text, out eps) || !int.TryParse(e_neg_score.Text, out ens) || !int.TryParse(p_pos_score.Text, out pps) || !int.TryParse(p_neg_score.Text, out pns) || eps < 0 || pps < 0 || eps > 15 || pps > 15 || ens > 0 || pns > 0 || ens < -15 || pns < -15) 
                {
                MessageBox.Show("One or more fields have been left empty or entered incorrectly.");
            }else
            {
                //sql insert command
                 string insertStatement = "INSERT INTO dbo.DogeCards(description, wealthyes, wealthno, popularityyes, popularityno,img) VALUES(@img_desc,@earn_pos ,@earn_neg ,@pop_pos ,@pop_neg, @img)";
                 SqlCommand insertCommand = new SqlCommand(insertStatement, Globals.conn);
                insertCommand.Connection = Globals.conn;
                Globals.conn.Open();
                insertCommand.Parameters.AddWithValue("@img_desc", SqlDbType.NVarChar).Value = image_description_input.Text;
                insertCommand.Parameters.AddWithValue("@earn_pos", SqlDbType.Int).Value = e_pos_score.Text;
                insertCommand.Parameters.AddWithValue("@earn_neg", SqlDbType.Int).Value = e_neg_score.Text;
                insertCommand.Parameters.AddWithValue("@pop_pos", SqlDbType.Int).Value = p_pos_score.Text;
                insertCommand.Parameters.AddWithValue("@pop_neg", SqlDbType.Int).Value = p_neg_score.Text;
                insertCommand.Parameters.AddWithValue("@img", SqlDbType.NVarChar).Value = image_url_input.Text;

                insertCommand.ExecuteNonQuery();
                MessageBox.Show("Data added successfully.");
                Globals.conn.Close();

                //clear text boxes
                image_description_input.Text = "";
                e_neg_score.Text = "Example: -15";
                e_pos_score.Text = "Example: 15";
                p_pos_score.Text = "Example: 15";
                p_neg_score.Text = "Example: -15";
                image_url_input.Text = "";

                //repopulate combo box with ids
                remove_list.Items.Clear();
                Globals.conn.Open();
                string selectstringupdate = "Select id FROM dbo.DogeCards;";
                SqlCommand Commandupdate = new SqlCommand(selectstringupdate);
                Commandupdate.Connection = Globals.conn;

                SqlDataReader dataRupdate;
                dataRupdate = Commandupdate.ExecuteReader();

                while (dataRupdate.Read())
                {
                    remove_list.Items.Add(dataRupdate[0]);
                }


                dataRupdate.Close();
                Globals.conn.Close();
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //go to new users form
            Users users = new Users();
            users.Show();
            this.Close();
        }
    }
}
