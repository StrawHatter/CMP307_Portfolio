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
    public partial class Form1 : Form
    {






        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void submitw_Click(object sender, EventArgs e)
        {

            string adminuser; //reused code from previous module - 1605044
            string adminpass;
            Boolean correctlog;

            adminuser = Username.Text;
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
                string p_n = Username.Text;


                this.Hide();

                Form2 frm2 = new Form2();
                frm2.ShowMe = p_n;
                frm2.Show();

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
