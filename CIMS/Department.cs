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
    public partial class Department : Form
    {
        SqlConnection con = null;
        public static int selectedDept=0;
        public static string selectedmember = "0";
        public string state = "new"; // new or update





        public Department()
        {
            InitializeComponent();
            con = DBConnection.Connect();
            con.Open();
        }

        private void Department_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'churchDBDataSet.sefer' table. You can move, or remove it, as needed.
            this.seferTableAdapter.Fill(this.churchDBDataSet.sefer);
            // TODO: This line of code loads data into the 'churchDBDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.churchDBDataSet.Member);
            // TODO: This line of code loads data into the 'churchDBDataSet.ServiceArea' table. You can move, or remove it, as needed.
            this.serviceAreaTableAdapter.Fill(this.churchDBDataSet.ServiceArea);
            displayDept();
        }


        public void DeptMembersDisplay()
        {
            if (Dept_DGV.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select department first!");
            }
            else if (Dept_DGV.SelectedRows.Count > 0)
            {
                string qry = "select member_id, member_name, member_sex, member_dob, member_phone1, member_sefer from member where member_id in (select memberDept_member from MemberDept where MemberDept_dept = '"+Dept_DGV.SelectedRows[0].Cells[0].Value+"' and memberDept_active = 'True' ) " ;

                SqlDataAdapter sda = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);



                deptMembers_DGV.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = deptMembers_DGV.Rows.Add();



                    deptMembers_DGV.Rows[n].Cells[0].Value = item[0].ToString();
                    deptMembers_DGV.Rows[n].Cells[1].Value = item[1].ToString();
                    deptMembers_DGV.Rows[n].Cells[2].Value = item[2].ToString();


                    DateTime DOB = Convert.ToDateTime(item[3]);

                    DateTime today = System.DateTime.Today.Date;

                   

                    int age = today.Year - DOB.Year;

                    deptMembers_DGV.Rows[n].Cells[3].Value = age;

                    deptMembers_DGV.Rows[n].Cells[4].Value = item[4].ToString();
                    deptMembers_DGV.Rows[n].Cells[5].Value = Convert.ToInt32(item[5]);




                }







            }
        }



        public void displayDept()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select  Dept_id, Dept_name, Dept_head, Dept_serviceArea from  Dept   ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);



            Dept_DGV.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = Dept_DGV.Rows.Add();



                Dept_DGV.Rows[n].Cells[0].Value = item[0].ToString();
                Dept_DGV.Rows[n].Cells[1].Value = item[1].ToString();
                Dept_DGV.Rows[n].Cells[2].Value = Convert.ToInt32(item[3].ToString());
                Dept_DGV.Rows[n].Cells[3].Value = Convert.ToInt32(item[2].ToString());




            }

        }

        private void Dept_DGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
            if (Dept_DGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
            {
                e.Cancel = true;
            }
        }

        public void clearFields()
        {
            dept_nameTextBox.Clear();
            dept_headComboBox.SelectedIndex = 0;
            dept_serviceAreaComboBox.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (dept_nameTextBox.Text != "")
            {



                if (state == "new")
                {

                    var confirmResult = MessageBox.Show("Are you sure to Add New Department?", "CIMS", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {


                        string qry = null;
                        qry = "insert into  Dept ( Dept_name,  Dept_serviceArea,  Dept_head  ) values ( '" + dept_nameTextBox.Text + "' , '" + dept_serviceAreaComboBox.SelectedValue + "' , '" + dept_headComboBox.SelectedValue + "'  )";

                        SqlCommand cmd = new SqlCommand(qry, con);
                        cmd.ExecuteNonQuery();
                        displayDept();
                        clearFields();
                        MessageBox.Show("Department Successfully Added!");
                        state = "new";

                    }


                }
                else if (state == "update")
                {

                    var confirmResult = MessageBox.Show("Are you sure to Update Existing Department?", "CIMS", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(Dept_DGV.SelectedRows[0].Cells[0].Value);

                        string qry = " update dept set dept_name = '" + dept_nameTextBox.Text + "' , dept_serviceArea = '" + dept_serviceAreaComboBox.SelectedValue + "', dept_head= '" + dept_headComboBox.SelectedValue + "'   where dept_id ='" + id + "'  ";
                        SqlCommand cmd = new SqlCommand(qry, con);
                        cmd.ExecuteNonQuery();
                        clearFields();
                        displayDept();


                        MessageBox.Show("Successfully Edited!!");

                        state = "new";


                    }




                }




            }

            else
            {
                MessageBox.Show("Department Name is Empty!");
            }

               
        }

        private void button3_Click(object sender, EventArgs e)
        {
            state = "new";
            clearFields();
            Dept_DGV.ClearSelection();
            deptMembers_DGV.Rows.Clear();
        }

        private void Dept_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            state = "update";



            dept_nameTextBox.Text = Dept_DGV.SelectedRows[0].Cells[1].Value.ToString();
            dept_serviceAreaComboBox.SelectedValue = Dept_DGV.SelectedRows[0].Cells[2].Value;
            dept_headComboBox.SelectedValue = Dept_DGV.SelectedRows[0].Cells[3].Value;

            DeptMembersDisplay();
            





        }

        private void button2_Click(object sender, EventArgs e)
        {

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Department.selectedDept = Convert.ToInt32(Dept_DGV.SelectedRows[0].Cells[0].Value) ;

            MemberList3 ml = new MemberList3();
            ml.ShowDialog();
            DeptMembersDisplay();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (deptMembers_DGV.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please Select Member First!");
            }
            else if (deptMembers_DGV.SelectedRows.Count > 0)

            {
                var confirmResult = MessageBox.Show("Are you sure Removing " + deptMembers_DGV.SelectedRows[0].Cells[1].Value.ToString() + " From " + Dept_DGV.SelectedRows[0].Cells[1].Value.ToString() + " ? ", "CIMS", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {

                    int Smember = Convert.ToInt32(deptMembers_DGV.SelectedRows[0].Cells[0].Value);
                int Sdept = Convert.ToInt32(Dept_DGV.SelectedRows[0].Cells[0].Value);

                string qry = "update MemberDept set MemberDept_active = 'False' where MemberDept_member = '" + Smember + "' and MemberDept_dept = '" + Sdept + "' and MemberDept_Active = 'True'";

                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Member Removed Successfully Removed!");
                    DeptMembersDisplay();


                }

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Service_Field sf = new Service_Field();
            sf.ShowDialog();


        }

        private void dept_serviceAreaComboBox_DropDown(object sender, EventArgs e)
        {
            
            this.serviceAreaTableAdapter.Fill(this.churchDBDataSet.ServiceArea);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            MemberList4 m4 = new MemberList4(1);
            m4.ShowDialog();

            if(selectedmember != "0")
            {
                dept_headComboBox.SelectedValue = selectedmember;
            }
            
        }
    }
}
