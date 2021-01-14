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
    public partial class HomeTeamForm : Form
    {
        SqlConnection con=null;

        public static string selectedHomeTeam = "";

        public static string selectedHead = "0";
        public static string selectedWriter = "0";

        public string state = "new";
        public HomeTeamForm()
        {
            InitializeComponent();
            con = DBConnection.Connect();
            con.Open();
            state = "new";
        }

        private void HomeTeamForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'churchDBDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.churchDBDataSet.Member);
            displayHomeTeam();
            
        }






        public void displayHomeTeam()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select  homeTeam_id, homeTeam_head, homeTeam_Writer, homeTeam_title   from HomeTeam   ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);



            HomeTeamDGV.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = HomeTeamDGV.Rows.Add();



                HomeTeamDGV.Rows[n].Cells[0].Value = item[0].ToString();
                HomeTeamDGV.Rows[n].Cells[1].Value = Convert.ToInt32(item[1].ToString());
                HomeTeamDGV.Rows[n].Cells[2].Value = Convert.ToInt32(item[2].ToString());
                HomeTeamDGV.Rows[n].Cells[3].Value = item[3].ToString();
             
         


            }

        }






        public void displayHomeMembers( int id)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select member_id,  member_Name, member_phone1  from member where member_hometeam = '"+id+"'  ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);



            member_dgv.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = member_dgv.Rows.Add();



                member_dgv.Rows[n].Cells[0].Value = item[0].ToString();
                member_dgv.Rows[n].Cells[1].Value = item[1].ToString();
                member_dgv.Rows[n].Cells[2].Value = item[2].ToString();





            }

        }













        private void HomeTeamDGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (HomeTeamDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           










            if ( homeTeam_titleTextBox.Text != "")
            {



                if (state == "new")
                {

                    var confirmResult = MessageBox.Show("Are you sure to Add New Home Team?", "CIMS", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {


                        string qry = null;
                        qry = "insert into  HomeTeam ( homeTeam_head, homeTeam_Writer, homeTeam_title   ) values ( '" + homeTeam_headComboBox.SelectedValue + "' , '" + homeTeam_WriterComboBox.SelectedValue + "' , '" + homeTeam_titleTextBox.Text + "' )";

                        SqlCommand cmd = new SqlCommand(qry, con);
                        cmd.ExecuteNonQuery();

                        displayHomeTeam();
                        MessageBox.Show("Home Team Successfully Added!");
                        state = "new";

                    }


                }
                else if (state == "update")
                {

                    var confirmResult = MessageBox.Show("Are you sure to Update Existing Home Team?", "CIMS", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        string qry = "update HomeTeam set HomeTeam_head = '" + homeTeam_headComboBox.SelectedValue + "' , HomeTeam_writer = '" + homeTeam_WriterComboBox.SelectedValue + "' , HomeTeam_title = '" + homeTeam_titleTextBox.Text + "' where HomeTeam_id = '" + HomeTeamDGV.SelectedRows[0].Cells[0].Value + "'";

                        SqlCommand cmd = new SqlCommand(qry, con);
                        cmd.ExecuteNonQuery();
                        displayHomeTeam();
                        clearFields();
                        MessageBox.Show("Successfully Edited!");

                        state = "new";


                    }




                }




            }

            else
            {
                MessageBox.Show("Home Team Title is Empty!");
            }





























        }

        private void HomeTeamDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            homeTeam_headComboBox.SelectedValue = HomeTeamDGV.SelectedRows[0].Cells[1].Value;
            homeTeam_WriterComboBox.SelectedValue = HomeTeamDGV.SelectedRows[0].Cells[2].Value;
            homeTeam_titleTextBox.Text = HomeTeamDGV.SelectedRows[0].Cells[3].Value.ToString();


            displayHomeMembers(Convert.ToInt32(HomeTeamDGV.SelectedRows[0].Cells[0].Value));

            state = "update";




        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(HomeTeamDGV.SelectedRows.Count<1)
            {
                MessageBox.Show("Please Select Home Team First!");
            }

            else if(HomeTeamDGV.SelectedRows.Count > 0)
            {
                HomeTeamForm.selectedHomeTeam = HomeTeamDGV.SelectedRows[0].Cells[0].Value.ToString();
                MemberList ml = new MemberList();
                ml.ShowDialog();
                displayHomeMembers(Convert.ToInt32(HomeTeamDGV.SelectedRows[0].Cells[0].Value));
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure Removing "+ member_dgv.SelectedRows[0].Cells[1].Value.ToString() +" From "+ HomeTeamDGV.SelectedRows[0].Cells[3].Value.ToString() +" ? ", "CIMS", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {

                if (member_dgv.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select Member To Remove!"); 
            }
            else if (member_dgv.SelectedRows.Count > 0)
            {
                string qry = " update Member set member_homeTeam = '" + 1 + "'  where member_id ='" + member_dgv.SelectedRows[0].Cells[0].Value.ToString() + "'  ";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();


                MessageBox.Show("Successfully Removed!");
            }

        } 
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


        public void clearFields()
        {
            homeTeam_headComboBox.SelectedIndex = 0;
            homeTeam_WriterComboBox.SelectedIndex = 0;
            homeTeam_titleTextBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearFields();
            HomeTeamDGV.ClearSelection();
            member_dgv.Rows.Clear();
            state = "new";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void member_dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (member_dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
            {
                e.Cancel = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MemberList4 m4 = new MemberList4(2);
            m4.ShowDialog();

            if (selectedHead != "0")
            {
                 homeTeam_headComboBox.SelectedValue = selectedHead;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            MemberList4 m4 = new MemberList4(3);
            m4.ShowDialog();

            if (selectedWriter != "0")
            {
                homeTeam_WriterComboBox.SelectedValue = selectedWriter;
            }



        }
    }
}
