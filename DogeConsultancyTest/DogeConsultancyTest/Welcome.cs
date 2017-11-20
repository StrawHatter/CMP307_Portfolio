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
    public partial class Welcome : Form
    {
        

        public Welcome()
        {
            InitializeComponent();
            
        }


        private void submitw_Click(object sender, EventArgs e)
        {

            int adminuser = 0; //reused and adapted code from previous module - 1605044
            string adminpass;
            bool adminauth;
            int int1;
            bool usercheck;
            string checkpass = "a"; //if this string is left null, the hashing function returns an error (as it can't hash a null value)
            bool exists = false;
            //checks the user ID is an integer
            usercheck = Int32.TryParse(Username.Text, out int1);
            if (usercheck == false)
            {
                //prevents a hash function crash where the database returns null values (hash function cant work with null values)
                adminuser = 0;
            }
            else if (usercheck == true)
            {
                //allows the parsing of username after checking that it's an int
                adminuser = Int32.Parse(Username.Text);
            }
            //take unhashed password into variable
            adminpass = Password.Text;

            //sql select username from database
            string selectText = "Select * from dbo.DogeUsers WHERE username = @username;";
            SqlCommand Command = new SqlCommand(selectText);
            Command.Parameters.AddWithValue("@username", adminuser);
            Command.Connection = Globals.conn;
            Globals.conn.Open();

            SqlDataReader dataR;
            dataR = Command.ExecuteReader();

            while (dataR.Read())
            {
                    checkpass = dataR[2].ToString();     
                if (dataR.HasRows)
                {
                    //prevents the hash algorithm attemtping to hash null values by only accepting inputs if value is returned from the database
                    exists = true;
                }
            }
            dataR.Close();

            Globals.conn.Close();

            if (exists)
            {


                //verify password with hashed password from the database
                var result = SecurePasswordHasher.Verify(adminpass, checkpass);
                if (result)
                {
                    //select statement to determine whether user or admin
                    string loginSelect = "Select * from dbo.DogeUsers where Username = @username and Admin = @admin;";
                    SqlCommand sqlcmd2 = new SqlCommand(loginSelect);
                    sqlcmd2.Parameters.AddWithValue("@username", adminuser);
                    sqlcmd2.Parameters.AddWithValue("@admin", "1");


                    sqlcmd2.Connection = Globals.conn;
                    Globals.conn.Open();

                    DataSet dataset = new DataSet();
                    SqlDataAdapter dataadapter = new SqlDataAdapter(sqlcmd2);
                    dataadapter.Fill(dataset);
                    Globals.conn.Close();


                    adminauth = ((dataset.Tables.Count > 0) && (dataset.Tables[0].Rows.Count > 0));
                    if (adminauth == true)
                    {

                        //select statement to display username on admin page
                        string displayuser2 = "Select Username from dbo.DogeUsers where Username = @username;";
                        SqlCommand sqlcmd4 = new SqlCommand(displayuser2);
                        sqlcmd4.Parameters.AddWithValue("@username", adminuser);


                        sqlcmd4.Connection = Globals.conn;
                        Globals.conn.Open();
                        SqlDataReader dataR2;
                        dataR2 = sqlcmd4.ExecuteReader();

                        while (dataR2.Read())
                        {
                            Globals.usernamesend = Int32.Parse(dataR2[0].ToString());
                        }
                        Globals.conn.Close();
                        //show admin form
                        Admin frmadmin = new Admin();
                        frmadmin.Show();
                        this.Hide();
                    }
                    else
                    {
                        //select username to display on training page
                        string displayuser = "Select Username from dbo.DogeUsers where Username = @username;";
                        SqlCommand sqlcmd3 = new SqlCommand(displayuser);
                        sqlcmd3.Parameters.AddWithValue("@username", adminuser);


                        sqlcmd3.Connection = Globals.conn;
                        Globals.conn.Open();
                        SqlDataReader dataR2;
                        dataR2 = sqlcmd3.ExecuteReader();

                        while (dataR2.Read())
                        {
                            Globals.usernamesend = Int32.Parse(dataR2[0].ToString());
                        }
                        dataR2.Close();
                        Globals.conn.Close();
                        this.Hide();
                        //display main form
                        Main frm2 = new Main();
                        frm2.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }

            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
