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
            Application.Exit();
        }

        private void remove_submit_Click(object sender, EventArgs e)
        {
           string chosenremoveid = remove_list.Text;

            SqlConnection conn;
            string connectionstring = "Data Source=vmwsql07.uad.ac.uk; Initial Catalog=sql1605044; User ID=sql1605044; Password=q?D46+il";
            conn = new SqlConnection(connectionstring);
            conn.Open();
            string deletestring = "Delete FROM dbo.DogeCards where id = @chosenremoveid;";
            SqlCommand Command = new SqlCommand(deletestring);
            Command.Parameters.AddWithValue("@chosenremoveid", chosenremoveid);
            Command.Connection = conn;
            Command.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Data for ID "+chosenremoveid+" has been removed.");
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            SqlConnection conn1;
            string connectionstring = "Data Source=vmwsql07.uad.ac.uk; Initial Catalog=sql1605044; User ID=sql1605044; Password=q?D46+il";
            conn1 = new SqlConnection(connectionstring);
            conn1.Open();
            string selectstring = "Select id FROM dbo.DogeCards;";
            SqlCommand Command1 = new SqlCommand(selectstring);
            Command1.Connection = conn1;

            SqlDataReader dataR;
            dataR = Command1.ExecuteReader();

            while (dataR.Read())
            {
                remove_list.Items.Add(dataR[0]);
            }


            dataR.Close();
            conn1.Close();



        }
    }
}
