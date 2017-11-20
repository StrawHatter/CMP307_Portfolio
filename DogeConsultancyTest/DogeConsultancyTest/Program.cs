using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Security.Cryptography;

namespace DogeConsultancyTest
{
    public static class Globals
    {
        //global variables
        //id of card pulled from database
        public static int cardid;
        //id of last card in database
        public static int maxn;
        //displays card description
        public static string id;
        //used to store the userID for various functions (including saving score at end)
        public static int usernamesend;
        //stores the url of the card image
        public static string url;
        //stores the positive value of earnings of the current card
        public static int wealthy;
        //stores the negative value of earnings of the current card
        public static int wealthn;
        //stores the positive value of popularity of the current card
        public static int popy;
        //stores the negative value of popularity of the current card
        public static int popn;
        //stores overall popularity value
        public static int pop;
        //stores overall wealth value
        public static int wealth;
        //stores user score
        public static int score;
        //stores connection string to database
        public static string connectionstring;
        public static SqlConnection conn;
        
    }

    public sealed class SecurePasswordHasher //Password hashing code found at https://stackoverflow.com/questions/4181198/how-to-hash-a-password/10402129#10402129
    {
        
        // Size of salt
        
        private const int SaltSize = 16;

        
        // Size of hash
        
        private const int HashSize = 20;

        
        // Creates a hash from a password
        
        // "password" = the password
        // iterations = number of iterations
        public static string Hash(string password, int iterations)
        {
            //create salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SaltSize]);

            //create hash
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            var hash = pbkdf2.GetBytes(HashSize);

            //combine salt and hash
            var hashBytes = new byte[SaltSize + HashSize];
            Array.Copy(salt, 0, hashBytes, 0, SaltSize);
            Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

            //convert to base64
            var base64Hash = Convert.ToBase64String(hashBytes);

            //format hash with extra information
            return string.Format("$MYHASH$V1${0}${1}", iterations, base64Hash);
        }
        // Creates a hash from a password with 10000 iterations
        // password = the password
        public static string Hash(string password)
        {
            return Hash(password, 10000);
        }


        // Check if hash is supported

        // hashString = the hash
        public static bool IsHashSupported(string hashString)
        {
            return hashString.Contains("$MYHASH$V1$");
        }

        
        // verify a password against a hash
        
        // password = the password
        // hashedPassword = the hash

        public static bool Verify(string password, string hashedPassword)
        {
            //check hash
            if (!IsHashSupported(hashedPassword))
            {
                throw new NotSupportedException("The hashtype is not supported");
            }

            //extract iteration and Base64 string
            var splittedHashString = hashedPassword.Replace("$MYHASH$V1$", "").Split('$');
            var iterations = int.Parse(splittedHashString[0]);
            var base64Hash = splittedHashString[1];

            //get hashbytes
            var hashBytes = Convert.FromBase64String(base64Hash);

            //get salt
            var salt = new byte[SaltSize];
            Array.Copy(hashBytes, 0, salt, 0, SaltSize);

            //create hash with given salt
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            byte[] hash = pbkdf2.GetBytes(HashSize);

            //get result
            for (var i = 0; i < HashSize; i++)
            {
                if (hashBytes[i + SaltSize] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
    static class Program
    {

        // The main entry point for the application.
        
        [STAThread]

        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //connection string for all sql statements
            Globals.connectionstring = "Data Source=vmwsql07.uad.ac.uk; Initial Catalog=sql1605044; User ID=sql1605044; Password=q?D46+il";
            Globals.conn = new SqlConnection(Globals.connectionstring);


            Application.Run(new Welcome());
        }
    }
}
