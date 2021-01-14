using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CIMS
{
    public partial class Login : Form
    {
        SqlConnection con = null;
        public static string currentUser = "";
        
        public Login()
        {
            InitializeComponent();
            con = DBConnection.Connect();
            con.Open();
            paswdBox.Focus();
            int x = System.DateTime.Today.Year;
            label4.Text = "Product Registered By Repi Full Gospel Local Church.                                                                                   Copy rights " + x + " By Ankuar Tech Solutions.";

        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                paswdBox.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String uname =  unameBox.Text;
            String pass = paswdBox.Text ;

            


            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from account where account_uname = '" + uname + "' and account_paswd = '" + pass + "'", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
                {

                //  current_Username = tbUname.Text;
                Login.currentUser = uname;
                
                Menu m = new Menu();
                m.Show();
                this.Hide();


            }
            else
            {

                MessageBox.Show("Wrong Credentials!"); 
               // lblerror.Text = "Wrong Username Or Password!";
              //  NotifyIcon notify = new NotifyIcon();
              //  notify.ShowBalloonTip(3000, "Message", "Your Data Has Been Successfully Saved", ToolTipIcon.Info);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'churchDBDataSet.Account' table. You can move, or remove it, as needed.
            try
            {
                this.accountTableAdapter.Fill(this.churchDBDataSet.Account);
                paswdBox.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Something Went Wrong!   "+ex.Message.ToString());
            } 

        }

        private void paswdBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                String uname = unameBox.Text;
                String pass = paswdBox.Text;




                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from account where account_uname = '" + uname + "' and account_paswd = '" + pass + "'", con);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {

                    //  current_Username = tbUname.Text;
                    Login.currentUser = uname;
                    Menu m = new Menu();
                    this.Hide();
                    m.Show();
                    


                }
                else
                {

                    MessageBox.Show("Wrong Credentials!");
                    // lblerror.Text = "Wrong Username Or Password!";
                    //  NotifyIcon notify = new NotifyIcon();
                    //  notify.ShowBalloonTip(3000, "Message", "Your Data Has Been Successfully Saved", ToolTipIcon.Info);
                }
            }

            }
        }
}
