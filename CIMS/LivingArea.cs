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
    
    public partial class LivingArea : Form
    {
        SqlConnection con = null;
        public LivingArea()
        {
            InitializeComponent();
            con = DBConnection.Connect();
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string qry = null;
            qry = "insert into  sefer ( sefer_Name ) values ( '" + seferBox.Text + "')";

            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void seferBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void seferBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                string qry = null;
                qry = "insert into  sefer ( sefer_Name ) values ( '" + seferBox.Text + "')";

                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                this.Close();

            }

        }
    }
}
