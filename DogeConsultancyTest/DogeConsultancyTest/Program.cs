using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace DogeConsultancyTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


                  SqlConnection conn;
           string connectionstring = "Data Source=vmwsql07.uad.ac.uk; Initial Catalog=sql1605044; User ID=sql1605044; Password=q?D46+il";
           conn = new SqlConnection(connectionstring);

           try
           {
               conn.Open();
               System.Diagnostics.Debug.Write("Success");
              conn.Close();
           }
          catch (Exception e)
           {
               System.Diagnostics.Debug.Write(e.ToString());
           }

/*
           string selectText = "Select * from dbo.customers;";
           SqlCommand Command = new SqlCommand(selectText);
           Command.Connection = conn;

           SqlDataReader dataR;
           dataR = Command.ExecuteReader();

           while (dataR.Read())
           {
               System.Diagnostics.Debug.WriteLine(dataR[2].ToString());
           }
           dataR.Close();


          //  string pinsertStatement = "INSERT INTO dbo.customers(firstname, surname) VALUES('test','test')";
           // SqlCommand pinsertCommand = new SqlCommand(pinsertStatement, conn);
           //
           //         pinsertCommand.ExecuteNonQuery();
     */



            Application.Run(new Form1());
        }
    }
}
