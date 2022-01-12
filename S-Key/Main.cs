using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_Key
{
    class Main
    {
        /*tạo password*/
        public static string CreatePassword(int length, int thuong, int hoa, int ktdb, int so) //nếu có truyền 1, nếu không truyền bất kỳ
        {
            string nor = "abcdefghijklmnopqrstuvwxyz";
            string flower = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string num = "0123456789";
            string special = "`~!@#$%^&*()-_=+;`";
            string valid = "";
            //nếu có thì cộng vào chuyễn valid
            if (thuong == 1) valid += nor;
            if (hoa == 1) valid += flower;
            if (ktdb == 1) valid += special;
            if (so == 1) valid += num;

            string pass;
            //random và check pass trước khi trả về
            do
            {
                pass = randomf(valid, length);
            } while (checkPass(pass, thuong, hoa, ktdb, so) == 0);

            return pass;
        }

        public static string randomf(string valid, int length)
        {
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();

            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        //hàm kiểm tra xem chuỗi có thỏa mãn là password hay không

        public static int checkPass(string password, int thuong, int hoa, int ktdb, int so)
        {
            int countNor = 0, countNum = 0, countFlow = 0, countSpecial = 0;

            foreach (char kt in password.ToCharArray())
            {
                if (char.IsLetterOrDigit(kt))
                {
                    if (char.IsNumber(kt)) countNum = 1;
                    if (char.IsUpper(kt)) countFlow = 1;
                    if (char.IsLower(kt)) countNor = 1;
                }
                else countSpecial = 1;
            }
            if (thuong == countNor && hoa == countFlow && ktdb == countSpecial && countNum == so)
                return 1;
            else
                return 0;
        }

        /* mã hóa AES*/
        public static byte[] IV = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        public static string EncryptString(string EncryptionKey,string clearText)
        {
            EncryptionKey = INFOUSER.key;
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
        public static string DecryptString(string EncryptionKey , string cipherText)
        {
            EncryptionKey = INFOUSER.key;
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        

        }

        /*hiển thị thông tin*/
        public static string url_pass;
        public static string user_pass;
        public static string pass_pass;
        public static void GetData(int idpass)
        {
            string query = "SELECT * FROM DATA_PASS where ID_PASS =" + idpass+ "and ID_USER = " + INFOUSER.id_user +" ";
            using (SqlConnection conn = new SqlConnection(INFOUSER.constr))
            {
                string dcrypt1="";
                string dcrypt2="";
                string dcrypt3="";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dcrypt1 = reader[1].ToString();
                            dcrypt2 = reader[2].ToString();
                            dcrypt3 = reader[3].ToString();                       
                        }
                    }
                }

                conn.Close();
                url_pass = DecryptString(INFOUSER.key, dcrypt1);
                user_pass = DecryptString(INFOUSER.key, dcrypt2);
                pass_pass = DecryptString(INFOUSER.key, dcrypt3);
                string output = "URL: " + url_pass + "\nUSER: " + user_pass + "\n PASS: " + pass_pass;
                MessageBox.Show(output);
            }
        }

        public static List<Button> buttonList = new List<Button>();
    }
}
