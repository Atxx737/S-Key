using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_Key
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public static int id_max = countbutton();
        public static int countbutton()
        {
            int count = 0;
            string query = "select COUNT(*) from DATA_PASS";
            using (SqlConnection conn = new SqlConnection(INFOUSER.constr))
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand(query, conn);

                using (SqlDataReader reader2 = cmd2.ExecuteReader())
                {
                    if (reader2.HasRows)
                    {
                        while (reader2.Read())
                        {
                            count = Int32.Parse(reader2[0].ToString().Trim());
                        }
                    }
                }
                conn.Close();
            }
            return count;
            
        }
        /*Lưu mật khẩu*/
        public static Button oldBtn = new Button() { Width = 80, Location = new Point(0, 0) };

        public void AddButton(string txtbutton,int idbutton)
        {
            Button button = new Button()
            {
                Location = new Point(oldBtn.Location.X + 80, oldBtn.Location.Y),
                Width = 80,
                Height = 80,
                Text = txtbutton.ToString(),
                Tag = idbutton
                // hienj id pass
            };
            Main.buttonList.Add(button);
            button.Click += Bnt_Click;
            fpanelPassword.Controls.Add(button);
            oldBtn = button;
        }
        //hiển thị thông tin
        public static void Bnt_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int id_button = Int32.Parse(btn.Tag.ToString().Trim());
            Main.GetData(id_button);
        }

        /*Tạo mật khẩu*/
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int thuong = 0, hoa = 0, ktdb = 0, so = 0,  length;
            if (chkLower.Checked == true)
            {
                thuong = 1;
            }
            if (chkUpper.Checked == true)
            {
                hoa = 1;
            }
            if (chkNumber.Checked == true)
            {
                so = 1;
            }
            if (chkSymbol.Checked == true)
            {
                ktdb = 1;
            }
            
            try
            {
                length = Int32.Parse(txtLength.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Enter length of password!");
                return;
            }
            length = Int32.Parse(txtLength.Text.Trim());

            txtGeneratePass.Text = Main.CreatePassword(length, thuong, hoa, ktdb, so);
        }








        /* Check password*/
        private void btnCheck_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            richtxtResult.Visible = true;

            string pw = txtPassword.Text;
            string x;
            int point = 0;
            int countUpper = 0;
            int countLower = 0;
            int countNum = 0;
            int countSym = 0;
            int countLetter = 0;

            /*Password Length:
            5 Points: Less than 4 characters
            10 Points: 5 to 7 characters
            25 Points: 8 or more
             */
            if (pw.Length <= 4)
                point += 5;
            else if (pw.Length <= 7)
                point += 10;
            else
                point += 25;
            x = "\nYour password length is " + pw.Length.ToString();

            //Check từng ký tự trong password xem là chữ hoa, chữ thường, số hay ký tự đặc biệt
            foreach (char kytu in pw.ToCharArray())
            {
                if (char.IsLetterOrDigit(kytu))
                {
                    if (char.IsLetter(kytu))
                    {
                        if (char.IsUpper(kytu))
                        {
                            countUpper++;
                            countLetter++;
                        }
                        if (char.IsLower(kytu))
                        {
                            countLower++;
                            countLetter++;
                        }
                    }
                    else
                        countNum++;
                }
                else
                    countSym++;
            }
            x += "\nYour password has " + countLower + " lowercase characters\n";
            x += "Your password has " + countUpper + " uppercase characters\n";
            x += "Your password has " + countNum + " numbers\n";
            x += "Your password has " + countSym + " symbols\n";

            /*Numbers:
            0 Points: No numbers
            10 Points: 1,2 number
            20 Points: 3 or more numbers
            */
            if (countNum != 0)
            {
                if (countNum <= 2)
                    point += 10;
                else
                    point += 20;
            }

            /*Characters:
            0 Points: No characters
            10 Points: 1 character
            25 Points: More than 1 character
             */
            if (countSym != 0)
            {
                if (countSym == 1)
                    point += 10;
                else
                    point += 25;
            }

            /*Letters:
            0 Points: No letters
            10 Points: Letters are all one case
            20 Points: Letters are upper case and lower case
             */
            if (countLetter != 0 && (countLower == 0 || countUpper == 0))
                point += 10;
            else if (countUpper != 0 && countLower != 0)
                point += 20;

            /*Bonus:
            2 Points: Letters and numbers
            3 Points: Letters, numbers, and characters
            5 Points: Mixed case letters, numbers, and characters
             */
            if (countLower != 0 && countUpper != 0 && countNum != 0 && countSym != 0)
                point += 5;
            else if (countLetter != 0 && countNum != 0 && countSym != 0)
                point += 3;
            else if (countLetter != 0 && countNum != 0)
                point += 2;

            /*Password Text Range:
            >= 90: Very sercure
            >= 80: Sercure
            >= 70: Very Strong
            >= 60: Strong
            >= 50: Average
            >= 25: Weak
            >= 0: Very Weak
             */
            if (point >= 90) //very secure
            {
                textBox2.BackColor = Color.Green;
                textBox2.Text = "VERY SERCURE";
                richtxtResult.Text = x;
            }
            else if (point >= 80) //sercure
            {
                textBox2.BackColor = Color.Lime;
                textBox2.Text = "SERCURE";
                richtxtResult.Text = x;
            }
            else if (point >= 70) //very strong
            {
                textBox2.BackColor = Color.GreenYellow;
                textBox2.Text = "VERY STRONG";
                richtxtResult.Text = x;
            }
            else if (point >= 60) //strong
            {
                textBox2.BackColor = Color.YellowGreen;
                textBox2.Text = "STRONG";
                richtxtResult.Text = x;
            }
            else if (point >= 50) //average
            {
                textBox2.BackColor = Color.Yellow;
                textBox2.Text = "AVERAGE";
                richtxtResult.Text = x;
            }
            else if (point >= 25) //weak
            {
                textBox2.BackColor = Color.OrangeRed;
                textBox2.Text = "WEAK";
                richtxtResult.Text = x;
            }
            else //very weak
            {
                textBox2.BackColor = Color.Red;
                textBox2.Text = "VERY WEAK";
                richtxtResult.Text = x;
            }


        }
        public static string bntname;
        public static int idbutton;
        private void frmMain_Load(object sender, EventArgs e)
        {
            int count =0;
            string query = "select * from DATA_PASS where ID_USER = " + INFOUSER.id_user + " ";
            string query1 = "select count(*) from DATA_PASS where ID_USER = " + INFOUSER.id_user + " ";
            using (SqlConnection conn = new SqlConnection(INFOUSER.constr))
            {
                conn.Open();
                SqlCommand cmd2 = new SqlCommand(query1, conn);
                using(SqlDataReader dataReader = cmd2.ExecuteReader())
                {
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                            count = Int32.Parse(dataReader[0].ToString().Trim());
                    }
                    
                }
                
                DataSet data = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(data);
                for(int i = 0; i< count;i++)
                {
                    bntname = data.Tables[0].Rows[i]["USER_"].ToString();
                    string name = Main.DecryptString(INFOUSER.key, bntname);
                    idbutton = Int32.Parse(data.Tables[0].Rows[i]["ID_PASS"].ToString().Trim());
                    AddButton(name, idbutton);
                }
                conn.Close();
            }
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Data f = new Data();
            f.Show();
        }
    }
}

    
