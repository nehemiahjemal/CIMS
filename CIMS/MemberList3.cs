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
    public partial class MemberList3 : Form
    {
        SqlConnection con = null;
        public MemberList3()
        {
            InitializeComponent();
            con = DBConnection.Connect();
            con.Open();
            byName_rdb.Checked = true;
            displayList();
        }


        public void displayList()
        {
            if (byName_rdb.Checked == true)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select member_id,  Member_name,  Member_sex,  Member_dob,  Member_phone1 from member where member_name like '%" + valueTbox.Text + "%' and member_dFlag = 'False' and Member_deathFlag = 'False' and Member_LeaveFlag= 'False' and Member_backFlag= 'False' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);



                ListDGV.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = ListDGV.Rows.Add();



                    ListDGV.Rows[n].Cells[0].Value = item[0].ToString();
                    ListDGV.Rows[n].Cells[1].Value = item[1].ToString();
                    ListDGV.Rows[n].Cells[2].Value = item[2].ToString();
                    
                    DateTime DOB = Convert.ToDateTime(item[3]);

                    DateTime today = System.DateTime.Today.Date;

                    int age = today.Year - DOB.Year;

                    ListDGV.Rows[n].Cells[3].Value = age;







                    ListDGV.Rows[n].Cells[4].Value = item[4].ToString();



                }
            }

            else if (byPhone_rdb.Checked == true)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select Member_id,  Member_name,  Member_sex,  Member_dob,  Member_phone1 from member where member_phone1 like '%" + valueTbox.Text + "%' and  member_dFlag = 'False' and Member_deathFlag = 'False' and Member_LeaveFlag= 'False' and Member_backFlag= 'False'   ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);



                ListDGV.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = ListDGV.Rows.Add();



                    ListDGV.Rows[n].Cells[0].Value = item[0].ToString();
                    ListDGV.Rows[n].Cells[1].Value = item[1].ToString();
                    ListDGV.Rows[n].Cells[2].Value = item[2].ToString();

                    DateTime DOB = Convert.ToDateTime(item[3]);

                    DateTime today = System.DateTime.Today.Date;

                    int age = today.Year - DOB.Year;

                    ListDGV.Rows[n].Cells[3].Value = age;







                    ListDGV.Rows[n].Cells[4].Value = item[4].ToString();

                }
            }
        }



        private void valueTbox_TextChanged(object sender, EventArgs e)
        {
            displayList();
        }

        private void MemberList3_Load(object sender, EventArgs e)
        {

        }

        private void ListDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string qry = "insert into MemberDept (MemberDept_member, MemberDept_dept, MemberDept_role, MemberDept_startDate, MemberDept_endDate, MemberDept_active, MemberDept_remark) values ('"+ListDGV.SelectedRows[0].Cells[0].Value+"' , '"+Department.selectedDept+"', 'member', '"+System.DateTime.Today.Date+"', '9999-01-01', 'True', '')";

         
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Member Successfully Added!");






        }
    }
}
