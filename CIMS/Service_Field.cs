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
    public partial class Service_Field : Form
    {
        SqlConnection con = null;
        public Service_Field()
        {
            InitializeComponent();
            con = DBConnection.Connect();
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string qry = null;
            qry = "insert into  ServiceArea ( ServiceArea_name ) values ( '" + serviceFieldTbox.Text + "')";

            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            this.Close();
        }
    }
}
