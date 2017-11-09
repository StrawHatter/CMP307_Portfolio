using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DogeConsultancyTest
{
    public static class Globals
    {
        public static int[] image_card_no;
        public static int nran;
        public static int maxn;
        public static string id;
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
