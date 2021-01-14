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
    public partial class IncomeReasonForm : Form
    {

        SqlConnection con = null;
        
        public IncomeReasonForm()
        {
            InitializeComponent();
            con = DBConnection.Connect();
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string qry = null;
            qry = "insert into  incomeSource ( incomeSource_Name ) values ( '" + incomeSource_nameTextBox.Text + "')";

            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            this.Close();
        }

        private void incomeSource_nameTextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                string qry = null;
                qry = "insert into  incomeSource ( incomeSource_Name ) values ( '" + incomeSource_nameTextBox.Text + "')";

                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                this.Close();
            }
        }
    }
}
