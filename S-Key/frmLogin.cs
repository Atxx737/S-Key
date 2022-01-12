using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_Key
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //mở đăng ký
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Thread th = new Thread(OpenRegister);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenRegister(object obj)
        {
            Application.Run(new frmRegister());
        }

        //đăng nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string data = txtEmail.Text.ToString() + txtPass.Text.ToString();
            string hash1 = INFOUSER.hash_512(data);
            string hash2 = INFOUSER.hash_512(hash1 + txtPass.Text.ToString());

            string query1 = "SELECT * FROM INFO_USER where HASH_ ='" + hash2 + "'";
            using (SqlConnection conn = new SqlConnection(INFOUSER.constr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query1, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        INFOUSER.key = hash1;
                        
                        MessageBox.Show("Login success!");
                        while(reader.Read())
                        {
                            INFOUSER.id_user = Int32.Parse(reader[0].ToString().Trim());
                                
                        }
                        this.Close();
                        Thread th = new Thread(OpenMain);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }
                    else
                        MessageBox.Show("Incorrect username or password");
                }
                conn.Close();

            }
        }

        private void getinfo(int id)
        {
            int idpass = 1;
            bool hasrows;
            do
            {
                string query2 = "SELECT * FROM INFO_USER where ID_USER = '" + id + "'and ID_PASS = " + idpass + " ";
                using (SqlConnection conn = new SqlConnection(INFOUSER.constr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query2, conn);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            hasrows = true;
                            while (reader.Read())
                            {

                            }
                        }
                        else
                            hasrows = false;
                    }
                    conn.Close();
                }
            } while (hasrows);
        }

        //mở cửa sổ chính
        private void OpenMain(object obj)
        {
            Application.Run(new frmMain());
        }


    }
}

