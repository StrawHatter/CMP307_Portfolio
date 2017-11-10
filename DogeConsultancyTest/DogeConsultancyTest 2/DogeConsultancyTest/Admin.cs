﻿using System;
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

        private void add_submit_Click(object sender, EventArgs e)
        {
            int eps;
            int ens;
            int pps;
            int pns;

            if (string.IsNullOrEmpty(image_description_input.Text) || string.IsNullOrEmpty(e_pos_score.Text) || string.IsNullOrEmpty(e_neg_score.Text) || string.IsNullOrEmpty(p_pos_score.Text) || string.IsNullOrEmpty(p_neg_score.Text) || !int.TryParse(e_pos_score.Text, out eps) || !int.TryParse(e_neg_score.Text, out ens) || !int.TryParse(p_pos_score.Text, out pps) || !int.TryParse(p_neg_score.Text, out pns) || eps < 0 || pps < 0 || eps > 100 || pps > 100 || ens > 0 || pns > 0 || ens < -100 || pns < -100) 
                {
                MessageBox.Show("One or more fields have been left empty or entered incorrectly.");
            }else
            {

                //sql connection
                SqlConnection conn;
                string connectionstring = "Data Source=vmwsql07.uad.ac.uk; Initial Catalog=sql1605044; User ID=sql1605044; Password=q?D46+il";
                conn = new SqlConnection(connectionstring);
                //sql insert command
                 string insertStatement = "INSERT INTO dbo.DogeCards(description, wealthyes, wealthno, popularityyes, popularityno,img) VALUES(@img_desc,@earn_pos ,@earn_neg ,@pop_pos ,@pop_neg,'www.google.co.uk')";
                 SqlCommand insertCommand = new SqlCommand(insertStatement, conn);
                insertCommand.Connection = conn;
                conn.Open();
                insertCommand.Parameters.AddWithValue("@img_desc", SqlDbType.VarChar).Value = image_description_input.Text;
                insertCommand.Parameters.Add("@earn_pos", SqlDbType.Int).Value = e_pos_score.Text;
                insertCommand.Parameters.Add("@earn_neg", SqlDbType.Int).Value = e_neg_score.Text;
                insertCommand.Parameters.Add("@pop_pos", SqlDbType.Int).Value = p_pos_score.Text;
                insertCommand.Parameters.Add("@pop_neg", SqlDbType.Int).Value = p_neg_score.Text;
                

                insertCommand.ExecuteNonQuery();
                MessageBox.Show("Data added successfully.");
                conn.Close();
            }

            
        }

    }
}
