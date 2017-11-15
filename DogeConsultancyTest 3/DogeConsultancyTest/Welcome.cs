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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void submitw_Click(object sender, EventArgs e)
        {

            int adminuser; //reused code from previous module - 1605044
            string adminpass;
            bool correctlog;
            bool adminauth;


            adminuser = System.Int32.Parse(Username.Text);
            adminpass = Password.Text;

            SqlConnection conn;
            string connectionstring = "Data Source=vmwsql07.uad.ac.uk; Initial Catalog=sql1605044; User ID=sql1605044; Password=q?D46+il";
            conn = new SqlConnection(connectionstring);

            string selectText = "Select * from dbo.DogeUsers where Username = @username and Password = @password;";
            SqlCommand Command = new SqlCommand(selectText);
            Command.Parameters.AddWithValue("@username", adminuser);
            Command.Parameters.AddWithValue("@password", adminpass);
            Command.Connection = conn;
            conn.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(Command);
            da.Fill(ds);
            conn.Close();

            correctlog = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));
            if (correctlog)
            {

                SqlConnection conn2;
                string connectionstring2 = "Data Source=vmwsql07.uad.ac.uk; Initial Catalog=sql1605044; User ID=sql1605044; Password=q?D46+il";
                conn2 = new SqlConnection(connectionstring2);
                string loginSelect = "Select * from dbo.DogeUsers where Username = @username and Password = @password and Admin = @admin;";
                SqlCommand sqlcmd2 = new SqlCommand(loginSelect);
                sqlcmd2.Parameters.AddWithValue("@username", adminuser);
                sqlcmd2.Parameters.AddWithValue("@password", adminpass);
                sqlcmd2.Parameters.AddWithValue("@admin", "1");
                
                
                sqlcmd2.Connection = conn2;
                conn2.Open();

               DataSet dataset = new DataSet();
               SqlDataAdapter dataadapter = new SqlDataAdapter(sqlcmd2);
               dataadapter.Fill(dataset);
               conn2.Close();


               adminauth = ((dataset.Tables.Count > 0) && (dataset.Tables[0].Rows.Count > 0));
               if (adminauth == true)
               {
                    SqlConnection conn4;
                    string connectionstring4 = "Data Source=vmwsql07.uad.ac.uk; Initial Catalog=sql1605044; User ID=sql1605044; Password=q?D46+il";
                    conn4 = new SqlConnection(connectionstring4);
                    string displayuser2 = "Select Username from dbo.DogeUsers where Username = @username and Password = @password;";
                    SqlCommand sqlcmd4 = new SqlCommand(displayuser2);
                    sqlcmd4.Parameters.AddWithValue("@username", adminuser);
                    sqlcmd4.Parameters.AddWithValue("@password", adminpass);


                    sqlcmd4.Connection = conn4;
                    conn4.Open();
                    SqlDataReader dataR2;
                    dataR2 = sqlcmd4.ExecuteReader();

                    while (dataR2.Read())
                    {
                        Globals.usernamesend = dataR2[0].ToString();
                    }
                    Admin frmadmin = new Admin();
                    frmadmin.CopyAdmin = Globals.usernamesend;
                    frmadmin.Show();
                   this.Hide();
               }
               else
               {
                    SqlConnection conn3;
                    string connectionstring3 = "Data Source=vmwsql07.uad.ac.uk; Initial Catalog=sql1605044; User ID=sql1605044; Password=q?D46+il";
                    conn3 = new SqlConnection(connectionstring3);
                    string displayuser = "Select Username from dbo.DogeUsers where Username = @username and Password = @password;";
                    SqlCommand sqlcmd3 = new SqlCommand(displayuser);
                    sqlcmd3.Parameters.AddWithValue("@username", adminuser);
                    sqlcmd3.Parameters.AddWithValue("@password", adminpass);


                    sqlcmd3.Connection = conn3;
                    conn3.Open();
                    SqlDataReader dataR;
                    dataR = sqlcmd3.ExecuteReader();

                    while (dataR.Read())
                    {
                         Globals.usernamesend = dataR[0].ToString();
                    }
                    this.Hide();

                    Main frm2 = new Main();
                    frm2.CopyUser = Globals.usernamesend;
                    frm2.Show();
                } 

            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
