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
    public partial class MemberList2 : Form
    {
        SqlConnection con = null;
        public MemberList2()
        {
            InitializeComponent();
            con = DBConnection.Connect();
            con.Open();
            role_combo.SelectedIndex = 0;
        }


        public void displayList()
        {
            if (byName_rdb.Checked == true)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select member_id,  Member_name,  Member_sex,  Member_family,  Member_phone1,  Member_homeTeam from member where member_name like '%" + valueTbox.Text + "%' and member_dFlag = 'False' and Member_deathFlag = 'False' and Member_LeaveFlag= 'False' and Member_backFlag= 'False' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);



                ListDGV.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = ListDGV.Rows.Add();



                    ListDGV.Rows[n].Cells[0].Value = item[0].ToString();
                    ListDGV.Rows[n].Cells[1].Value = item[1].ToString();
                    ListDGV.Rows[n].Cells[2].Value = item[2].ToString();
                    ListDGV.Rows[n].Cells[3].Value = item[3];
                    ListDGV.Rows[n].Cells[4].Value = item[4].ToString();
                    ListDGV.Rows[n].Cells[5].Value = item[5];


                }
            }

            else if (byPhone_rdb.Checked == true)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select Member_id,  Member_name,  Member_sex,  Member_family,  Member_phone1,  Member_homeTeam from member where member_phone1 like '%" + valueTbox.Text + "%' and member_dFlag = 'False' and Member_deathFlag = 'False' and Member_LeaveFlag= 'False' and Member_backFlag= 'False' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);



                ListDGV.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = ListDGV.Rows.Add();



                    ListDGV.Rows[n].Cells[0].Value = item[0].ToString();
                    ListDGV.Rows[n].Cells[1].Value = item[1].ToString();
                    ListDGV.Rows[n].Cells[2].Value = item[2].ToString();
                    ListDGV.Rows[n].Cells[3].Value = item[3];
                    ListDGV.Rows[n].Cells[4].Value = item[4].ToString();
                    ListDGV.Rows[n].Cells[5].Value = item[5];


                }
            }
        }





        private void valueTbox_TextChanged(object sender, EventArgs e)
        {
            displayList();
        }

        private void ListDGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (ListDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
            {
                e.Cancel = true; 
            }
        }

        private void MemberList2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'churchDBDataSet.Family' table. You can move, or remove it, as needed.
            this.familyTableAdapter.Fill(this.churchDBDataSet.Family);
            // TODO: This line of code loads data into the 'churchDBDataSet.HomeTeam' table. You can move, or remove it, as needed.
            this.homeTeamTableAdapter.Fill(this.churchDBDataSet.HomeTeam);
            // TODO: This line of code loads data into the 'churchDBDataSet.sefer' table. You can move, or remove it, as needed.
            this.seferTableAdapter.Fill(this.churchDBDataSet.sefer);
            byName_rdb.Checked = true;
            displayList();

        }

        private void ListDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string qry = " update Member set member_family = '" + Family_Form.selectedFamily + "', member_FamRole = '"+role_combo.SelectedItem.ToString()+"'  where member_id ='" + ListDGV.SelectedRows[0].Cells[0].Value.ToString() + "'  ";

            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            displayList();

            MessageBox.Show("Successfully Added!");
        }
    }
}
