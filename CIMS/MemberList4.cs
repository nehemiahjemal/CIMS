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
    public partial class MemberList4 : Form
    {
        SqlConnection con = null;

        public int senderFlag=0;
        public MemberList4(int x)
        {
            senderFlag = x;
            InitializeComponent();
            con = DBConnection.Connect();
            con.Open();
          
        }


        public void displayMembers()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select Member_id , Member_name,  Member_sex,  Member_sefer,  Member_phone1,  Member_homeTeam from member where member_dFlag = 'False' and Member_deathFlag = 'False' and Member_LeaveFlag= 'False' and Member_backFlag= 'False'  ", con);
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
               


            }

        }



        private void ListDGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {


            if (ListDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
            {
                e.Cancel = true;
            }



        }

        private void ListDGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(senderFlag==1)
            {
                Department.selectedmember = ListDGV.SelectedRows[0].Cells[0].Value.ToString();

                this.Close();

            }

             else if (senderFlag == 2)
            {
                HomeTeamForm.selectedHead = ListDGV.SelectedRows[0].Cells[0].Value.ToString();

                this.Close();

            }

            else if (senderFlag == 3)
            {
                HomeTeamForm.selectedWriter = ListDGV.SelectedRows[0].Cells[0].Value.ToString();

                this.Close();

            }

            else if (senderFlag == 4)
            {
                Family_Form.selectedRep = ListDGV.SelectedRows[0].Cells[0].Value.ToString();

                this.Close();

            }

            else if (senderFlag == 5)
            {
                IncomeForm.incomeby = ListDGV.SelectedRows[0].Cells[0].Value.ToString();

                this.Close();

            }

            else if (senderFlag == 6)
            {
                IncomeForm.recvdBy = ListDGV.SelectedRows[0].Cells[0].Value.ToString();

                this.Close();

            }




        }

        private void MemberList4_Load(object sender, EventArgs e)
        {
            displayMembers();
            byName_rdb.Checked = true;
        }

        private void valueTbox_TextChanged(object sender, EventArgs e)
        {
            if (byName_rdb.Checked == true)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select member_id,  Member_name,  Member_sex,  Member_sefer,  Member_phone1,  Member_homeTeam from member where member_dFlag = 'False' and Member_deathFlag = 'False' and Member_LeaveFlag= 'False' and Member_backFlag= 'False' and member_name like '%" + valueTbox.Text + "%' ", con);
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
                    


                }
            }

            else if (byPhone_rdb.Checked == true)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select Member_id,  Member_name,  Member_sex,  Member_sefer,  Member_phone1,  Member_homeTeam from member where member_dFlag = 'False' and Member_deathFlag = 'False' and Member_LeaveFlag= 'False' and Member_backFlag= 'False' and member_phone1 like '%" + valueTbox.Text + "%' ", con);
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
                  


                }
            }
        }
    }
}
