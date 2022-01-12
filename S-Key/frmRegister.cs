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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        //đăng ký
       
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text==String.Empty || txtPass.Text==String.Empty|| txtRePass.Text==String.Empty)
            {
                MessageBox.Show("Enter info!");
                return;
            }
            else
            {
                if (txtPass.Text == txtRePass.Text)
                {
                    string data = txtEmail.Text.ToString() + txtPass.Text.ToString();
                    string hash1 = INFOUSER.hash_512(data);
                    
                    string data1 = hash1 + txtPass.Text.ToString();
                    string hash2 = INFOUSER.hash_512(data1);
                    string username = txtEmail.Text.ToString();

                    string query2 = "insert into INFO_USER values ('" + hash2 + "','" + username + "')";
                    string query1 = "select * from INFO_USER where EMAIL_ = '" + username + "'";
                    using (SqlConnection conn = new SqlConnection(INFOUSER.constr))
                    {
                        conn.Open();
                        bool has = false;
                        SqlCommand cmd1 = new SqlCommand(query1, conn);
                        SqlCommand cmd2 = new SqlCommand(query2, conn);
                        using (SqlDataReader reader = cmd1.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                has = true;
                                MessageBox.Show("This account has already existed!");
                            }
                        }
                        if (has == false)
                        {
                            using (SqlDataReader reader1 = cmd2.ExecuteReader())
                            {

                            }
                            MessageBox.Show("Sign up success!");
                            Thread th = new Thread(OpenLogin);
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();
                        }
                        conn.Close();
                    }
                }
                else
                    MessageBox.Show("Confirm password was wrong!  Try again");
            }
           
        }
        private void OpenLogin(object obj)
        {
            Application.Run(new frmLogin());
        }

    }
 }

