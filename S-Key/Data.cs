using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_Key
{
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPassWord.Text == "" || txtURL.Text == "" || txtUserName.Text == "")
                MessageBox.Show("Enter URL USER PASS plz!");
            else
            {
                string key = INFOUSER.key;
                //ham mã hóa
                string url, username, password;
                url = txtURL.Text;
                username = txtUserName.Text;
                password = txtPassWord.Text;
                string encrypt1 = Main.EncryptString(key, url);
                string encrypt2 = Main.EncryptString(key, username);
                string encrypt3 = Main.EncryptString(key, password);

                //lưu vô data
                string query2 = "insert into DATA_PASS values ('" + encrypt1 + "','" + encrypt2 + "','" + encrypt3 + "'," + INFOUSER.id_user + ")";
                using (SqlConnection conn = new SqlConnection(INFOUSER.constr))
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand(query2, conn);

                    using (SqlDataReader reader2 = cmd2.ExecuteReader())
                    {
                        MessageBox.Show("Save success!");
                        frmMain.bntname = username;
                        Close();
                    }
                    conn.Close();
                }
            }
   
        }

        private void Data_Load(object sender, EventArgs e)
        {

        }
    }
}
