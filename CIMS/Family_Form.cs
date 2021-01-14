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
    public partial class Family_Form : Form
    {
        SqlConnection con=null;
        public static string selectedRep = "0";
        public static string selectedFamily = "";
        public static string saveFlag = "insert";   // insert or update
        public Family_Form()
        {
            InitializeComponent();
            con = DBConnection.Connect();
            con.Open();
        }



        public void displayFamily()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select  Family_id, Family_rep, Family_remark, family_NONBAM, Family_Nbam   from Family   ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);



            Family_DGV.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = Family_DGV.Rows.Add();



                Family_DGV.Rows[n].Cells[0].Value = item[0].ToString();
                Family_DGV.Rows[n].Cells[1].Value = Convert.ToInt32(item[1].ToString());
                Family_DGV.Rows[n].Cells[2].Value = item[2].ToString();
                Family_DGV.Rows[n].Cells[3].Value = item[3].ToString();
                Family_DGV.Rows[n].Cells[4].Value = item[4].ToString();



            }

        }


        public void clearFields()
        {

            family_repComboBox.SelectedIndex = 0;
            family_remarkTextBox.Clear();
            Family_NBA.Value = 0;
            Family_NBAL.Clear();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            clearFields();
            saveFlag = "insert";
        }

        private void Family_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'churchDBDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.churchDBDataSet.Member);
            displayFamily();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(saveFlag=="insert")
            {



                var confirmResult = MessageBox.Show("Are you sure to Add New Family?", "CIMS", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {

                    string qry = "insert into  Family ( family_rep, family_remark, family_NONBAM, Family_Nbam    ) values ( '" + family_repComboBox.SelectedValue + "' , '" + family_remarkTextBox.Text + "', '" + Family_NBA.Value + "', '" + Family_NBAL.Text + "' )";

                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();

                    displayFamily();
                    MessageBox.Show("New Family Successfully Added!");
                    clearFields();

                }
            }
            else if(saveFlag == "update")
            {


                var confirmResult = MessageBox.Show("Are you sure to Edit this Family Record?", "CIMS", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {





                    if (Family_DGV.SelectedRows.Count < 1)
                    {
                        MessageBox.Show("Please select a family First! ");
                    }
                    else if (Family_DGV.SelectedRows.Count > 0)
                    {
                        string qry = "update family set family_rep = '" + family_repComboBox.SelectedValue + "' , family_remark= '" + family_remarkTextBox.Text + "', family_NONBAM = '" + Family_NBA.Value + "', Family_Nbam = '" + Family_NBAL.Text + "'        where family_id = '" + Family_DGV.SelectedRows[0].Cells[0].Value + "'";
                        SqlCommand cmd = new SqlCommand(qry, con);
                        cmd.ExecuteNonQuery();
                        displayFamily();
                        /// this.memberTableAdapter.Fill(this.churchDBDataSet.Member);
                        MessageBox.Show("Successfully Edited!");

                    }


                }


            }
            
            
        }








        public void displayFamilyMembers(int id)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select member_id,  member_Name, member_phone1, Member_FamRole  from member where member_family = '" + id + "'  ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            Fmember_DGV.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = Fmember_DGV.Rows.Add();



                Fmember_DGV.Rows[n].Cells[0].Value = item[0].ToString();
                Fmember_DGV.Rows[n].Cells[1].Value = item[1].ToString();
                Fmember_DGV.Rows[n].Cells[2].Value = item[2].ToString();
                Fmember_DGV.Rows[n].Cells[3].Value = item[3].ToString();
               


            }

        }








        private void Family_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
            family_repComboBox.SelectedValue =  Family_DGV.SelectedRows[0].Cells[1].Value;
          family_remarkTextBox.Text = Family_DGV.SelectedRows[0].Cells[2].Value.ToString();

            Family_NBA.Text = Family_DGV.SelectedRows[0].Cells[3].Value.ToString();
            Family_NBAL.Text = Family_DGV.SelectedRows[0].Cells[4].Value.ToString();

           
            displayFamilyMembers(Convert.ToInt32(Family_DGV.SelectedRows[0].Cells[0].Value));

            saveFlag = "update";


            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ( Family_DGV.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please Select Family First!");
            }

            else if (Family_DGV.SelectedRows.Count > 0)
            {
                Family_Form.selectedFamily = Family_DGV.SelectedRows[0].Cells[0].Value.ToString();
                MemberList2 ml2 = new MemberList2();
                ml2.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(Fmember_DGV.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select Family Member First!");
            }
            else if (Fmember_DGV.SelectedRows.Count > 0)
            {
                string sql = "update member set member_family = '"+1+"' where member_id = '"+Fmember_DGV.SelectedRows[0].Cells[0].Value+"' ";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                displayFamilyMembers(Convert.ToInt32(Family_DGV.SelectedRows[0].Cells[0].Value));

                /// this.memberTableAdapter.Fill(this.churchDBDataSet.Member);
                MessageBox.Show("Successfully Removed!");
            }
        }

        private void Family_DGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (Family_DGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
            {
                e.Cancel = true;
            }
        }

        private void Fmember_DGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (Fmember_DGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
            {
                e.Cancel = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MemberList4 m4 = new MemberList4(4);
            m4.ShowDialog();

            if (selectedRep != "0")
            {
                family_repComboBox.SelectedValue = selectedRep;
            }
        }
    }
}
