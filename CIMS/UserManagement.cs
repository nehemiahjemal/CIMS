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
    public partial class UserManagement : Form
    {

        SqlConnection con = null;

        public UserManagement()
        {
            InitializeComponent();

            con = DBConnection.Connect();
            con.Open();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'churchDBDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.churchDBDataSet.Member);
            FillDgv();

        }




        public void FillDgv()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select Account_uname, Account_paswd,  Account_member from Account ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

           


            usersDGV.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = usersDGV.Rows.Add();



                usersDGV.Rows[n].Cells[0].Value = item[0].ToString();
                usersDGV.Rows[n].Cells[1].Value = item[1].ToString();
                usersDGV.Rows[n].Cells[2].Value = Convert.ToInt32(item[2].ToString());
           


            }

          

        }

        private void usersDGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (usersDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
