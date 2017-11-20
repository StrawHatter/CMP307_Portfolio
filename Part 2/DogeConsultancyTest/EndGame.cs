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
            //exit program
            Welcome Welcome = new Welcome();
            Welcome.Show();
            this.Close();
        }

        private void EndGame_Load(object sender, EventArgs e)
        {
            //sql insert command (saves score to database
            string insertStatement = "Update dbo.dogeUsers Set Score = @score Where Username = @username;";
            SqlCommand insertCommand = new SqlCommand(insertStatement, Globals.conn);
            insertCommand.Connection = Globals.conn;
            Globals.conn.Open();
            insertCommand.Parameters.AddWithValue("@score", SqlDbType.Int).Value = Globals.score;
            insertCommand.Parameters.AddWithValue("@username", Globals.usernamesend);
            insertCommand.ExecuteNonQuery();
            Globals.conn.Close();
        }
    }
}
