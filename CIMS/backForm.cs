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
    public partial class backForm : Form
    {
        SqlConnection con = null;
        public backForm()
        {
            
            InitializeComponent();
            con = DBConnection.Connect();
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string qry = "update member set member_backFlag = 'True' , member_backedDate = '" + backDate.Value + "' where member_id = '" + RegisterMember.backId + "' ";

            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Completed!");
            this.Close();
        }
    }
}
