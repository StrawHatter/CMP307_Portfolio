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
    public partial class EndGame : Form
    {
        public EndGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EndGame_Load(object sender, EventArgs e)
        {
            //sql connection
            SqlConnection conn;
            string connectionstring = "Data Source=vmwsql07.uad.ac.uk; Initial Catalog=sql1605044; User ID=sql1605044; Password=q?D46+il";
            conn = new SqlConnection(connectionstring);
            //sql insert command
            string insertStatement = "Update dbo.dogeUsers Set Score = @score Where Username = @username;";
            SqlCommand insertCommand = new SqlCommand(insertStatement, conn);
            insertCommand.Connection = conn;
            conn.Open();
            insertCommand.Parameters.AddWithValue("@score", SqlDbType.Int).Value = Globals.score;
            insertCommand.Parameters.AddWithValue("@username", Globals.usernamesend);
            insertCommand.ExecuteNonQuery();
            conn.Close();
        }
    }
}
