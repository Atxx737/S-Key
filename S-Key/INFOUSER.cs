using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace S_Key
{
    class INFOUSER
    {
        public class pass
        {
            public int id_pass;
            public string URL;
            public string name;
            public string username;
            public string password;
        }

        public static pass[] pas = new pass[1000];
        public static void setpasses(int id, string URL, string name, string username, string password)
        {
            pas[id].id_pass = id;
            pas[id].URL = URL;
            pas[id].name = name;
            pas[id].username = username;
            pas[id].password = password;
        }
        public static string hash_512(string rawdata)
        {
            using (SHA512 sha512Hash = SHA512.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha512Hash.ComputeHash(Encoding.UTF8.GetBytes(rawdata));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }

        }


        public static string constr = @"Data Source=DESKTOP-L7L4HMB\SQLEXPRESS;Initial Catalog=SKEY;Integrated Security=True";
        public static string key;
        public static int id_user;
        public static int id_pass;
    }
}
