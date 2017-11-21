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
using System.Security.Cryptography;

namespace DogeConsultancyTest
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void submitw_Click(object sender, EventArgs e)
        {
            //checks passwords in both boxes match
            if (Password.Text == passwordverify.Text)
            {

                int id;
                string lengthtest;
                string unhashed;
                string hashedpass;
                lengthtest = Username.Text;
                unhashed = Password.Text;
                bool insert = false;
                bool exists;
                bool usercheck;
                int int1;
                int adminuser = 0;

                usercheck = Int32.TryParse(Username.Text, out int1);
                if (usercheck == false)
                {
                    //prevents conflicting data types when checking for existing users in case a string is entered in the user box
                    adminuser = 0;
                }
                else if (usercheck == true)
                {
                    //allows the parsing of username after checking that it's an int
                    adminuser = Int32.Parse(Username.Text);
                }

                //checks to see if user already exists in database
                string loginSelect = "Select * from dbo.DogeUsers where Username = @username;";
                SqlCommand sqlcmd2 = new SqlCommand(loginSelect);
                sqlcmd2.Parameters.AddWithValue("@username", adminuser);



                sqlcmd2.Connection = Globals.conn;
                Globals.conn.Open();

                DataSet dataset = new DataSet();
                SqlDataAdapter dataadapter = new SqlDataAdapter(sqlcmd2);
                dataadapter.Fill(dataset);
                Globals.conn.Close();


                exists = ((dataset.Tables.Count > 0) && (dataset.Tables[0].Rows.Count > 0));
                if (exists == true)
                {
                    MessageBox.Show("This user already exists");
                }
                else if (exists == false)
                {
                    //input validation
                    if (string.IsNullOrEmpty(Username.Text) || string.IsNullOrEmpty(Password.Text) || !int.TryParse(Username.Text, out id) || lengthtest.Length > 7 || lengthtest.Length < 7)
                    {
                        MessageBox.Show("One or more fields have been left empty or entered incorrectly. Remember User ID must be a 7 digit integer.");
                    }
                    else
                    {
                        //hash function for password
                        var hash = SecurePasswordHasher.Hash(unhashed);
                        hashedpass = hash;
                        //sql insert command
                        string insertStatement = "INSERT INTO dbo.DogeUsers(username,password,admin) VALUES(@username,@hashedpassword,@admin)";
                        SqlCommand insertCommand = new SqlCommand(insertStatement, Globals.conn);
                        insertCommand.Connection = Globals.conn;
                        Globals.conn.Open();
                        insertCommand.Parameters.AddWithValue("@username", SqlDbType.Int).Value = Username.Text;
                        insertCommand.Parameters.AddWithValue("@hashedpassword", SqlDbType.NVarChar).Value = hashedpass;
                        insertCommand.Parameters.AddWithValue("@admin", SqlDbType.Bit).Value = insert;

                        insertCommand.ExecuteNonQuery();
                        MessageBox.Show("Data added successfully.");
                        Globals.conn.Close();
                        //takes you back to admin form when data added correctly
                        Admin Admin = new Admin();
                        Admin.Show();
                        this.Hide();


                    }
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match. Please try again.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Admin Admin = new Admin();
            Admin.Show();
            this.Close();
        }

        private void exit_admin_Click(object sender, EventArgs e)
        {
            Welcome Welcome = new Welcome();
            Welcome.Show();
            this.Close();        
        }
    }
}
