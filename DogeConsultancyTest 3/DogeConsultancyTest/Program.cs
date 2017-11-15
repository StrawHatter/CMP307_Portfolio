using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DogeConsultancyTest
{
    public static class Globals
    {
        public static int nran;
        public static int maxn;
        public static string id;
        public static string usernamesend;
        public static string url;
        public static int wealthy;
        public static int wealthn;
        public static int popy;
        public static int popn;
        public static int pop;
        public static int wealth;
        public static int score;
    }
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




            Application.Run(new Welcome());
        }
    }
}
