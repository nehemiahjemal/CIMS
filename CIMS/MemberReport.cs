using DGVPrinterHelper;
using Syncfusion.XlsIO;
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
    public partial class MemberReport : Form
    {
        SqlConnection con = null;

        public string filter = "";
        public int  countMale = 0, countFemale = 0, countStud = 0, countWorker = 0, countStudandWorker = 0, countOther = 0, countUnknown=0;
        public MemberReport()
        {
            InitializeComponent();
            con = DBConnection.Connect();
            con.Open();
            DisableFields();
        }



        public void DisableFields()
        {
            gender_combo.Enabled = false;
            marital_combo.Enabled = false;
            age_num1.Enabled = false;
            age_num2.Enabled = false;
            dept_combo.Enabled = false;
            living_combo.Enabled = false;
            jobtype_combo.Enabled = false;
            bad_date1.Enabled = false;
            bad_date2.Enabled = false;
            bpd_date1.Enabled = false;
            bpd_date2.Enabled = false;
            educl_combo.Enabled = false;
            jes_combo.Enabled = false;
            death_date1.Enabled = false;
            death_date2.Enabled = false;
            backed_date1.Enabled = false;
            backed_date2.Enabled = false;
            leave_date1.Enabled = false;
            leave_date2.Enabled = false;
            transfer_date1.Enabled = false;
            transfer_date2.Enabled = false;
            childCombo.Enabled = false;
        }



     
        private void MemberReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'churchDBDataSet.EducField' table. You can move, or remove it, as needed.
            this.educFieldTableAdapter.Fill(this.churchDBDataSet.EducField);
            // TODO: This line of code loads data into the 'churchDBDataSet.sefer' table. You can move, or remove it, as needed.
            this.seferTableAdapter.Fill(this.churchDBDataSet.sefer);
            // TODO: This line of code loads data into the 'churchDBDataSet.Dept' table. You can move, or remove it, as needed.
            this.deptTableAdapter.Fill(this.churchDBDataSet.Dept);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            filter = "";


            int x = 0;
            string sql = "SELECT Member_id, Member_name, Member_sex, Member_phone1, Member_dob, member_educLevel, member_jobAndEducStatus, member_noOfChild, Member_maritalStatus, Member_EducField1, Member_EducField2 FROM dbo.Member  ";

            
            

            if (gender_chbx.Checked)
            {
               
                    x++;

                    sql=sql+"where member_sex = '"+gender_combo.SelectedItem.ToString()+"'  ";

                filter = filter + "   ||  Gender: "+ gender_combo.Text;
                   
                
                


            
            }
            if (marital_chbx.Checked)
            {
                if (x != 0)
                {
                    sql = sql + "and member_maritalStatus = '" + marital_combo.SelectedItem.ToString() + "'  ";
                    filter = filter + "  ||   Marital Status: " + marital_combo.Text;
                }
                else if (x == 0)
                {
                    x++;

                    sql = sql + "where member_maritalStatus = '" + marital_combo.SelectedItem.ToString() + "'   ";
                    filter = filter + "  ||   Marital Status: " + marital_combo.Text;

                }
            }
            if (age_chbx.Checked)
            {


                System.DateTime high = System.DateTime.Today.Date.AddYears(-Convert.ToInt32(age_num1.Value));
                System.DateTime low = System.DateTime.Today.Date.AddYears(-Convert.ToInt32(age_num2.Value) );

                //MessageBox.Show("high: "+ high+ "  low: "+low);

                low = low.AddMonths(-(low.Month -1) );
                low = low.AddDays(-(low.Day - 1));



                high = high.AddMonths((12 - high.Month ));
                high = high.AddDays( (31 - high.Day ));






                DateTime date1 = low;
                DateTime date2 = high;

                if (x != 0)
                {
                    sql = sql + "and     member_dob between '" + date1 + "' and '"+ date2 + "'  ";
                    filter = filter + "  ||   Age Group:  from " + age_num1.Value + " to " + age_num2.Value;

                }
                else if (x == 0)
                {
                    x++;

                    sql = sql + "where  member_dob between '" + date1 + "' and '" + date2 + "'  ";
                    filter = filter + "  ||   Age Group:  from " + age_num1.Value + " to " + age_num2.Value;


                }





            } 
            if (dept_chbx.Checked)
            {



                int c = Convert.ToInt32(dept_combo.SelectedValue);




                if (x != 0)
                {
                    sql = sql + "and member_id in (select MemberDept_member from MemberDept where MemberDept_dept = '"+c+"' and memberDept_Active = 'True')  ";
                    filter = filter + "  ||   Department: " + dept_combo.Text;

                }
                else if (x == 0)
                {
                    x++;

                    sql = sql + "where  member_id in (select MemberDept_member from MemberDept where MemberDept_dept = '" + c + "' and memberDept_Active = 'True'  ) ";

                    filter = filter + "   ||  Department: " + dept_combo.Text;
                }





            }
            if (living_chbx.Checked)
            {
                int c = Convert.ToInt32( living_combo.SelectedValue);




                if (x != 0)
                {
                    sql = sql + "and member_sefer = '" + c + "'  ";
                    filter = filter + "   ||  Living Area: " + living_combo.Text;

                }
                else if (x == 0)
                {
                    x++;

                    sql = sql + "where  member_sefer = '" + c + "'  ";
                    filter = filter + "  ||   Living Area: " + living_combo.Text;


                }









            }

            if(haveChild.Checked)
            {










              
                if(childCombo.Text == "Yes")
                {

                    if (x != 0)
                    {
                        sql = sql + "and member_sefer > 0 ";
                        filter = filter + "   ||  Having Childrens: " + childCombo.Text;

                    }
                    else if (x == 0)
                    {
                        x++;

                        sql = sql + "where  member_noOfChild > 0 ";
                        filter = filter + "  ||   Having Childrens: " + childCombo.Text;


                    }


                }
                else if(childCombo.Text == "No")
                {

                    if (x != 0)
                    {
                        sql = sql + "and member_sefer = 0 ";
                        filter = filter + "   ||  Having Childrens: " + childCombo.Text;

                    }
                    else if (x == 0)
                    {
                        x++;

                        sql = sql + "where  member_noOfChild = 0 ";
                        filter = filter + "  ||   Having Childrens: " + childCombo.Text;


                    }

                }



               






















            }



            if (jobtype_chbx.Checked)
            {


                if (x != 0)
                {
                    sql = sql + "and member_jobtype = '" + jobtype_combo.SelectedItem.ToString() + "'  ";
                    filter = filter + "   ||  Job Type: " + jobtype_combo.Text;

                }
                else if (x == 0)
                {
                    x++;

                    sql = sql + "where  member_jobtype = '" + jobtype_combo.SelectedItem.ToString() + "'   ";
                    filter = filter + "  ||   Job Type: " + jobtype_combo.Text;


                }







            }
            if (bad_chbx.Checked)
            {

               // MessageBox.Show("Test1");

                if (x != 0)
                {
                    sql = sql + "and member_BornAgainDate between '" + bad_date1.Value + "' and '"+bad_date2.Value+"'  ";
                    filter = filter + "  ||   Born Again:  from " + bad_date1.Value + " to " + bad_date2.Value;
                    //MessageBox.Show("Test2");

                }
                else if (x == 0)
                {
                    x++;

                    sql = sql + "where  member_BornAgainDate between '" + bad_date1.Value + "' and '" + bad_date2.Value + "' ";
                    filter = filter + "  ||   Born Again:  from " + bad_date1.Value + " to " + bad_date2.Value;
                    // MessageBox.Show("Test3");


                }




            }
            if (bpd_chbx.Checked)
            {

                if (x != 0)
                {
                    sql = sql + "and member_BaptismDate between '" + bpd_date1.Value + "' and '" + bpd_date2.Value + "'  ";
                    // MessageBox.Show("Test4");
                    filter = filter + "   ||  Baptism:  from " + bpd_date1.Value.Date  + " to " + bpd_date2.Value.Date;

                }
                else if (x == 0)
                {
                    x++;

                    sql = sql + "where  member_BaptismDate between '" + bpd_date1.Value + "' and '" + bpd_date2.Value + "'";
                    filter = filter + "  ||   Baptism:  from " + bpd_date1.Value + " to " + bpd_date2.Value;
                    // MessageBox.Show("Test5 "+ bpd_date1.Value);


                }

            }
            if (educl_chbx.Checked)
            {
                if (x != 0)
                {
                    sql = sql + "and member_educLevel = '" + educl_combo.SelectedItem.ToString() + "'  ";
                    filter = filter + "   ||  Educ Level: " + educl_combo.Text;

                }
                else if (x == 0)
                {
                    x++;

                    sql = sql + "where  member_educLevel = '" + educl_combo.SelectedItem.ToString() + "'  ";
                    filter = filter + "   ||  Educ Level: " + educl_combo.Text;


                }

            }
            if (jes_chbx.Checked)
            {

                if (x != 0)
                {
                    sql = sql + "and Member_JobAndEducStatus = '" + jes_combo.SelectedItem.ToString() + "'  ";
                    filter = filter + "  ||   Job & Educ Status: " + jes_combo.Text;

                }
                else if (x == 0)
                {
                    x++;

                    sql = sql + "where  Member_JobAndEducStatus = '" + jes_combo.SelectedItem.ToString() + "'   ";
                    filter = filter + "  ||   Job & Educ Status: " + jes_combo.Text;


                }

            }
            if (death_chbx.Checked)
            {


                if (x != 0)
                {
                    sql = sql + "and Member_deathFlag = 'True' and Member_deathDate between  '"+death_date1.Value+"' and '"+death_date2.Value+"'";
                    filter = filter + "  ||   Death:  from " + death_date1.Value + " to " + death_date2.Value;

                }
                else if (x == 0)
                {
                    x++;

                    sql = sql + "where  Member_deathFlag = 'True' and Member_deathDate between  '" + death_date1.Value + "' and '" + death_date2.Value + "' ";
                    filter = filter + "  ||   Death:  from " + death_date1.Value + " to " + death_date2.Value;

                }









            }
            if (backed_chbx.Checked)
            {


                if (x != 0)
                {
                    sql = sql + "and Member_backFlag = 'True' and Member_backedDate between  '" + backed_date1.Value + "' and '" + backed_date2.Value + "'";
                    filter = filter + "   ||  Backed:  from " + backed_date1.Value + " to " + backed_date2.Value;

                }
                else if (x == 0)
                {
                    x++;

                    sql = sql + "where  Member_backFlag = 'True' and Member_backedDate between  '" + backed_date1.Value + "' and '" + backed_date2.Value + "'";
                    filter = filter + "  ||   Backed:  from " + backed_date1.Value + " to " + backed_date2.Value;

                }


            }
            if (leave_chbx.Checked)
            {


                if (x != 0)
                {
                    sql = sql + "and Member_leaveFlag = 'True' and Member_leaveDate between  '" + leave_date1.Value + "' and '" + leave_date2.Value + "'";
                    filter = filter + "  ||  Leave:  from " + leave_date1.Value + " to " + leave_date2.Value;

                }
                else if (x == 0)
                {
                    x++;

                    sql = sql + "where  Member_leaveFlag = 'True' and Member_leaveDate between  '" + leave_date1.Value + "' and '" + leave_date2.Value + "'";
                    filter = filter + "  ||   Leave:  from " + leave_date1.Value + " to " + leave_date2.Value;

                }




            }
            if (transfer_chbx.Checked)
            {
                if (x != 0)
                {
                    sql = sql + "and Member_transFlag = 'True' and Member_DateFromOtherChurch between  '" + transfer_date1.Value + "' and '" + transfer_date2.Value + "'";
                    filter = filter + "  ||   Transfer:  from " + transfer_date1.Value + " to " + transfer_date2.Value;
                }
                else if (x == 0)
                {
                    x++;

                    sql = sql + "where  Member_transFlag = 'True' and Member_DateFromOtherChurch between  '" + transfer_date1.Value + "' and '" + transfer_date2.Value + "'";
                    filter = filter + "  ||   Transfer:  from " + transfer_date1.Value + " to " + transfer_date2.Value;

                }
            }




            if(x!=0)
            {
                sql = sql + " and member_id !='1'     and  member_dFlag = 'False' and Member_deathFlag = 'False' and Member_LeaveFlag= 'False' and Member_backFlag= 'False'              ";
            }else if(x==0)
            {
                sql = sql + " where member_id !='1'     and   member_dFlag = 'False' and Member_deathFlag = 'False' and Member_LeaveFlag= 'False' and Member_backFlag= 'False' ";
            }




            //MessageBox.Show(sql);
           SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);



            int count=0;
            ListDGV.Rows.Clear();
            countFemale = 0; countMale = 0; countStud = 0; countWorker = 0; countStudandWorker = 0; countOther = 0; countUnknown = 0;
            foreach (DataRow item in dt.Rows)
            {
                int n = ListDGV.Rows.Add();

                ListDGV.Rows[n].Cells[0].Value = item[0].ToString();
                ListDGV.Rows[n].Cells[1].Value = item[1].ToString();
                ListDGV.Rows[n].Cells[2].Value = item[2].ToString();
                ListDGV.Rows[n].Cells[3].Value = item[3].ToString();
                DateTime dtt = Convert.ToDateTime(item[4]);

                int age = DateTime.Today.Date.Year - dtt.Year;

                if(age>0&&age<200)
                ListDGV.Rows[n].Cells[4].Value = age;
                ListDGV.Rows[n].Cells[5].Value = item[5].ToString();
                ListDGV.Rows[n].Cells[6].Value = item[6].ToString();
                ListDGV.Rows[n].Cells[7].Value = item[7].ToString();
                ListDGV.Rows[n].Cells[8].Value = item[8].ToString();
                ListDGV.Rows[n].Cells[9].Value = item[9];
                ListDGV.Rows[n].Cells[10].Value = item[10];

                count++;





                if (item[2].ToString() == "Male")
                    countMale++;
                if (item[2].ToString() == "Female")
                    countFemale++;
                if (item[6].ToString() == "Unknown")
                    countUnknown++;
                if (item[6].ToString() == "Student Only")
                    countStud++;
                if (item[6].ToString() == "Worker")
                    countWorker++;
                if (item[6].ToString() == "Student and Worker")
                    countStudandWorker++;
                if (item[6].ToString() == "Other")
                    countOther++;





            }

            countLabel.Text = "" + count;

            //MessageBox.Show(filter);



        }

        private void ListDGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (ListDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Repi Full Gospel Belivers Local Church\n\n";

            string repo = "Female = "+ countFemale+"   Male = "+ countMale +"\n"+ "Student = "+ countStud+ "    Worker = "+ countWorker+ "   Sudent & Worker = "+countStudandWorker+"    "+"Other = "+ countOther + "   Unknown = "+countUnknown;

            if(filter!="")
            {
                printer.SubTitle = "Members List by "+ filter + "\n"+ repo +"\n Total = "+ ListDGV.Rows.Count;
            }
            else
            {
                printer.SubTitle = "Members List  " + "\n"+repo+ "\n Total = " + ListDGV.Rows.Count;
            }


          //  printer.SubTitle = "Members List Having Childrens.  Total = "+ ListDGV.Rows.Count;


            
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            //printer.RowHeight =  ;
            printer.PageNumberInHeader = false;
            printer.ShowTotalPageNumber = true;
            printer.PorportionalColumns = true;
            printer.RowHeight = DGVPrinter.RowHeightSetting.CellHeight;
            printer.HeaderCellAlignment = StringAlignment.Far;
            printer.Footer = "CIMS. by Anquar Technologies";
            printer.FooterSpacing = 15;
            Font f = new Font("Times New Roman", 10, FontStyle.Underline);
            printer.SubTitleColor = Color.Red;
            printer.TitleColor = Color.SteelBlue;
            printer.SubTitleFont = f;
            printer.PrintPreviewDataGridView(ListDGV);


            //***********************************************************************************

        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {



        }

        private void gender_chbx_CheckedChanged(object sender, EventArgs e)
        {
            if(gender_chbx.Checked)
            {
                gender_combo.Enabled = true;
                gender_chbx.ForeColor = Color.Black;
            }
            else
            {
                gender_combo.Enabled = false;
                gender_chbx.ForeColor = Color.White;
            }
        }

        private void marital_chbx_CheckedChanged(object sender, EventArgs e)
        {
            if(marital_chbx.Checked)
            {
                marital_chbx.ForeColor = Color.Black;
                marital_combo.Enabled = true;
            }
            else
            {
                marital_chbx.ForeColor = Color.White;
                marital_combo.Enabled = false;

            }
        }

        private void age_chbx_CheckedChanged(object sender, EventArgs e)
        {
            if(age_chbx.Checked)
            {
                age_chbx.ForeColor = Color.Black;
                age_num1.Enabled = true;
                age_num2.Enabled = true;
            }
            else
            {
                age_chbx.ForeColor = Color.White;
                age_num1.Enabled = false;
                age_num2.Enabled = false;
            }
        }

        private void dept_chbx_CheckedChanged(object sender, EventArgs e)
        {
            if(dept_chbx.Checked)
            {
                dept_chbx.ForeColor = Color.Black;
                dept_combo.Enabled = true;
            }
            else
            {
                dept_chbx.ForeColor = Color.White;
                dept_combo.Enabled = false;

            }
        }

        private void living_chbx_CheckedChanged(object sender, EventArgs e)
        {
            if(living_chbx.Checked)
            {
                living_chbx.ForeColor = Color.Black;
                living_combo.Enabled = true;
            }
            else
            {
                living_chbx.ForeColor = Color.White;
                living_combo.Enabled = false;
            }
        }

        private void jobtype_chbx_CheckedChanged(object sender, EventArgs e)
        {
            if(jobtype_chbx.Checked)
            {
                jobtype_combo.Enabled = true;
                jobtype_chbx.ForeColor = Color.Black;
            }
            else
            {
                jobtype_chbx.ForeColor = Color.White;
                jobtype_combo.Enabled = false;

            }
        }

        private void bad_chbx_CheckedChanged(object sender, EventArgs e)
        {
            if(bad_chbx.Checked)
            {
                bad_chbx.ForeColor = Color.Black;
                bad_date1.Enabled = true;
                bad_date2.Enabled = true;
            }
            else
            {
                bad_chbx.ForeColor = Color.White;
                bad_date1.Enabled = false;
                bad_date2.Enabled = false;
            }
        }

        private void bpd_chbx_CheckedChanged(object sender, EventArgs e)
        {
            if(bpd_chbx.Checked)
            {
                bpd_chbx.ForeColor = Color.Black;
                bpd_date1.Enabled = true;
                bpd_date2.Enabled = true;
            }
            else
            {
                bpd_chbx.ForeColor = Color.White;
                bpd_date1.Enabled = false;
                bpd_date2.Enabled = false;

            }
        }

        private void educl_chbx_CheckedChanged(object sender, EventArgs e)
        {
            if(educl_chbx.Checked)
            {
                educl_combo.Enabled = true;
                educl_chbx.ForeColor = Color.Black;
            }
            else
            {
                educl_chbx.ForeColor = Color.White;
                educl_combo.Enabled = false;
            }
        }

        private void haveChild_CheckedChanged(object sender, EventArgs e)
        {
            if (haveChild.Checked)
            {
                haveChild.ForeColor = Color.Black;
                childCombo.Enabled = true;
            }
            else
            {
                dept_chbx.ForeColor = Color.White;
                dept_combo.Enabled = false;


                haveChild.ForeColor = Color.White;
                childCombo.Enabled = false;


            }
        }

        private void jes_chbx_CheckedChanged(object sender, EventArgs e)
        {
            if(jes_chbx.Checked)
            {
                jes_chbx.ForeColor = Color.Black;
                jes_combo.Enabled = true;
            }
            else
            {
                jes_chbx.ForeColor = Color.White;
                jes_combo.Enabled = false;
            }
        }

        private void death_chbx_CheckedChanged(object sender, EventArgs e)
        {
            if(death_chbx.Checked)
            {
                death_chbx.ForeColor = Color.Black;
                death_date1.Enabled = true;
                death_date2.Enabled = true;
            }
            else
            {
                death_chbx.ForeColor = Color.White;
                death_date1.Enabled = false;
                death_date2.Enabled = false;
            }
        }

        private void backed_chbx_CheckedChanged(object sender, EventArgs e)
        {
            if(backed_chbx.Checked)
            {
                backed_chbx.ForeColor = Color.Black;
                backed_date1.Enabled = true;
                backed_date2.Enabled = true;
            }
            else
            {
                backed_chbx.ForeColor = Color.White;
                backed_date1.Enabled = false;
                backed_date2.Enabled = false;



            }
        }

        private void leave_chbx_CheckedChanged(object sender, EventArgs e)
        {
            if (leave_chbx.Checked)
            {
                leave_chbx.ForeColor = Color.Black;
                leave_date1.Enabled = true;
                leave_date2.Enabled = true;
            }
            else
            {
                leave_chbx.ForeColor = Color.White;
                leave_date1.Enabled = false;
                leave_date2.Enabled = false;



            }
        }

        private void transfer_chbx_CheckedChanged(object sender, EventArgs e)
        {
            if (transfer_chbx.Checked)
            {
                transfer_chbx.ForeColor = Color.Black;
                transfer_date1.Enabled = true;
                transfer_date2.Enabled = true;
            }
            else
            {
                transfer_chbx.ForeColor = Color.White;
                transfer_date1.Enabled = false;
                transfer_date2.Enabled = false;



            }
        }

        private void jes_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
