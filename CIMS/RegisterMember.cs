using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace CIMS
{
    public partial class RegisterMember : Form
    {
        int state = 0;
        SqlConnection con = null;

        public static int initial = 0;
        public static int deathId = 0;
        public static int leaveId = 0;
        public static int backId = 0;
        public RegisterMember()
        {
            InitializeComponent();
            con = DBConnection.Connect();
            con.Open();
            byName_rdb.Checked = true;
            this.Text = "Member Registrar |  User: " + Login.currentUser;


        }

        private void RegisterMember_Load(object sender, EventArgs e)
        {





            // TODO: This line of code loads data into the 'churchDBDataSet.EducField' table. You can move, or remove it, as needed.
            this.educFieldTableAdapter.Fill(this.churchDBDataSet.EducField);
            // TODO: This line of code loads data into the 'churchDBDataSet.sefer' table. You can move, or remove it, as needed.
            this.seferTableAdapter.Fill(this.churchDBDataSet.sefer);
            // TODO: This line of code loads data into the 'churchDBDataSet.Family' table. You can move, or remove it, as needed.
            this.familyTableAdapter.Fill(this.churchDBDataSet.Family);
            // TODO: This line of code loads data into the 'churchDBDataSet.HomeTeam' table. You can move, or remove it, as needed.
            this.homeTeamTableAdapter.Fill(this.churchDBDataSet.HomeTeam);
            // TODO: This line of code loads data into the 'churchDBDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.churchDBDataSet.Member);



         //   clearFields();
            fillMembersDgv();




        }


        public void fillMembersDgv()
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT Member_id, Member_name, Member_motherName, Member_maritalStatus, Member_noOfChild, Member_DOB, Member_DOM, Member_sex, Member_subcity, Member_wereda, Member_sefer, Member_houseNo, Member_phone1, Member_email, Member_emgContactName, Member_emgContactPhone, Member_photo, Member_specialSkill, Member_EducLevel, Member_EducField1, Member_EducField2, Member_JobAndEducStatus, Member_jobType, Member_officePhone, Member_officeAdress, Member_BornAgainDate, Member_BaptismDate, Member_ServiceGift, Member_previousChurch, Member_transferReason, Member_additionalInfo, Member_Confirmer, Member_approvalLeader, Member_transFlag, Member_baptisedChurch, Member_deathFlag, Member_deathDate, Member_LeaveFlag, Member_leaveDate, Member_leaveReason, Member_backFlag, Member_backedDate, Member_bornAgain, Member_ofOtherCurch, Member_dFlag, Member_family, Member_homeTeam, Member_FamRole, Member_transDate , Member_oldid  FROM dbo.Member where member_dFlag = 'False' and Member_deathFlag = 'False' and Member_LeaveFlag= 'False' and Member_backFlag= 'False' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);



            memberListDGV.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = memberListDGV.Rows.Add();


                memberListDGV.Rows[n].Cells[50].Value = item[49].ToString();
                memberListDGV.Rows[n].Cells[0].Value = item[0].ToString();
                memberListDGV.Rows[n].Cells[1].Value = item[1].ToString();
                memberListDGV.Rows[n].Cells[2].Value = item[2].ToString();
                memberListDGV.Rows[n].Cells[3].Value = item[3].ToString();
                memberListDGV.Rows[n].Cells[4].Value = item[4].ToString();

                memberListDGV.Rows[n].Cells[5].Value = Convert.ToDateTime(item[5]).Date;



                DateTime DOB = Convert.ToDateTime(item[5]);

                DateTime today = System.DateTime.Today.Date;

                int age = today.Year - DOB.Year;

                memberListDGV.Rows[n].Cells[48].Value = age;





                memberListDGV.Rows[n].Cells[6].Value = item[6].ToString();
                memberListDGV.Rows[n].Cells[7].Value = item[7].ToString();
                memberListDGV.Rows[n].Cells[8].Value = item[8].ToString();
                memberListDGV.Rows[n].Cells[9].Value = item[9].ToString();
                memberListDGV.Rows[n].Cells[10].Value = (item[10]);
                memberListDGV.Rows[n].Cells[11].Value = item[11].ToString();
                memberListDGV.Rows[n].Cells[12].Value = item[12].ToString();
                memberListDGV.Rows[n].Cells[13].Value = item[13].ToString();
                memberListDGV.Rows[n].Cells[14].Value = item[14].ToString();
                memberListDGV.Rows[n].Cells[15].Value = item[15].ToString();
                memberListDGV.Rows[n].Cells[16].Value = item[16].ToString();
                memberListDGV.Rows[n].Cells[17].Value = item[17].ToString();
                memberListDGV.Rows[n].Cells[18].Value = item[18].ToString();
                memberListDGV.Rows[n].Cells[19].Value = item[19].ToString();
                memberListDGV.Rows[n].Cells[20].Value = item[20].ToString();
                memberListDGV.Rows[n].Cells[21].Value = item[21].ToString();
                memberListDGV.Rows[n].Cells[22].Value = item[22].ToString();
                memberListDGV.Rows[n].Cells[23].Value = item[23].ToString();
                memberListDGV.Rows[n].Cells[24].Value = item[24].ToString();
                memberListDGV.Rows[n].Cells[25].Value = item[25].ToString();
                memberListDGV.Rows[n].Cells[26].Value = item[26].ToString();
                memberListDGV.Rows[n].Cells[27].Value = item[27].ToString();
                memberListDGV.Rows[n].Cells[28].Value = item[28].ToString();
                memberListDGV.Rows[n].Cells[29].Value = item[29].ToString();
                memberListDGV.Rows[n].Cells[30].Value = item[30].ToString();
                memberListDGV.Rows[n].Cells[31].Value = item[31].ToString();
                memberListDGV.Rows[n].Cells[32].Value = item[32].ToString();
                memberListDGV.Rows[n].Cells[33].Value = item[33];

                memberListDGV.Rows[n].Cells[34].Value = item[34].ToString();
                memberListDGV.Rows[n].Cells[35].Value = item[35];
                memberListDGV.Rows[n].Cells[36].Value = item[36].ToString();
                memberListDGV.Rows[n].Cells[37].Value = item[37];
                memberListDGV.Rows[n].Cells[38].Value = item[38].ToString();


                memberListDGV.Rows[n].Cells[39].Value = item[39].ToString();
                memberListDGV.Rows[n].Cells[40].Value = item[40];
                memberListDGV.Rows[n].Cells[41].Value = item[41].ToString();
                memberListDGV.Rows[n].Cells[42].Value = item[42];

                memberListDGV.Rows[n].Cells[43].Value = item[43];
                memberListDGV.Rows[n].Cells[44].Value = item[44];
                memberListDGV.Rows[n].Cells[45].Value = item[45].ToString();

                memberListDGV.Rows[n].Cells[46].Value = item[46].ToString();
                memberListDGV.Rows[n].Cells[47].Value = item[47].ToString();
                memberListDGV.Rows[n].Cells[48].Value = item[48].ToString();







            }


            countBox.Text = Convert.ToString(memberListDGV.Rows.Count);

        }




        private void clearFields()
        {
            DateTime dt = new DateTime(8888, 08, 08);

            
            oldid_box.Clear();
            checkBox1.Checked = false;
            unkDOT.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            memberPicLocation.Clear();
            member_idTextBox.Clear();
            member_nameTextBox.Clear();
            member_motherNameTextBox.Clear();
            member_maritalStatusComboBox.SelectedIndex = 0;
            member_noOfChildNumericUpDown.Value = 0;
            member_DOBDateTimePicker.Value = dt;
            member_DOMDateTimePicker.Value = dt;
            member_sexComboBox.SelectedIndex = 0;
            member_familyComboBox.SelectedIndex = 0;
            member_additionalInfoTextBox.Clear();
            member_subcityComboBox.SelectedIndex = 0;
            member_weredaNumericUpDown.Value = 0;
            member_seferComboBox.SelectedIndex = 0;
            member_houseNoTextBox.Clear();
            member_phone1TextBox.Clear();
            member_emailTextBox.Clear();
            member_emgContactNameTextBox.Clear();
            member_emgContactPhoneTextBox.Clear();
            member_transFlagCheckBox.Checked = false;
            member_transferReasonTextBox.Clear();
            member_baptisedChurchTextBox.Clear();
            dt = new DateTime(8888, 08, 08);
            member_BornAgainDateDateTimePicker.Value = dt;
            member_BaptismDateDateTimePicker.Value = dt;
            member_ConfirmerComboBox.SelectedIndex = 0;
            member_approvalLeaderComboBox.SelectedIndex = 0;
            member_homeTeamComboBox.SelectedIndex = 0;
            member_ServiceGiftTextBox.Clear();
            member_specialSkillTextBox.Clear();
            member_EducLevelComboBox.SelectedIndex = 0;
            member_EducField1ComboBox.SelectedIndex = 0;
            member_EducField2ComboBox.SelectedIndex = 0;
            member_JobAndEducStatusComboBox.SelectedIndex = 0;
            member_jobTypeComboBox.SelectedIndex = 0;
            member_officePhoneTextBox.Clear();
            member_officeAdressTextBox.Clear();
            AgeTbox.Clear();
            numericUpDown1.Value = 0;
            memberPicBox.Image = null;
            member_DOMDateTimePicker.Enabled = true;
            Member_famRolCombo.SelectedIndex = 4;
            transDate.Value = dt;
            this.memberPicBox.Image = global::CIMS.Properties.Resources.person_1824144_1280;




            AgeTbox.Clear();

        }


        private void newBtn_Click(object sender, EventArgs e)

        {


            clearFields();
            string last_code = null;
            SqlDataAdapter sda = new SqlDataAdapter("select countLast from Counts where countName = 'Members' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {

                last_code = item[0].ToString();
            }

            int x = Convert.ToInt32(last_code) + 1;
            member_idTextBox.Text = x.ToString();

            MessageBox.Show("Start Registering New Member.");

            state = 1;
            member_nameTextBox.Focus();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (member_idTextBox.Text != "")
            {

                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "*.JPEG*|*.jpg*|*.png*|", ValidateNames = true })
                {

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {

                        string pathName = "C:\\CIMS\\Photo\\" + member_idTextBox.Text + "_" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + DateTime.Now.Millisecond + "_" + System.IO.Path.GetExtension(ofd.FileName.ToString());
                        // MessageBox.Show(pathName);
                        System.IO.File.Copy(ofd.FileName.ToString(), pathName, true);

                        memberPicBox.Image = Image.FromFile(ofd.FileName);

                        memberPicLocation.Text = pathName;
                    }



                }

            }

            else
            {
                MessageBox.Show("There is No Selected Member!");
            }

        }

        public void display(int n)
        {
            int mId = n;

            clearFields();



            //   memberListDGV.SelectedRows[0].Cells[0].Value.ToString()

            oldid_box.Text = memberListDGV.SelectedRows[0].Cells[50].Value.ToString();
            member_idTextBox.Text = memberListDGV.SelectedRows[0].Cells[0].Value.ToString();
            memberPicLocation.Text = memberListDGV.SelectedRows[0].Cells[16].Value.ToString();
            member_nameTextBox.Text = memberListDGV.SelectedRows[0].Cells[1].Value.ToString();
            member_motherNameTextBox.Text = memberListDGV.SelectedRows[0].Cells[2].Value.ToString();
            member_maritalStatusComboBox.SelectedItem = memberListDGV.SelectedRows[0].Cells[3].Value;
            member_noOfChildNumericUpDown.Value = Convert.ToInt32(memberListDGV.SelectedRows[0].Cells[4].Value);
            member_DOBDateTimePicker.Value = Convert.ToDateTime(memberListDGV.SelectedRows[0].Cells[5].Value);
            member_DOMDateTimePicker.Value = Convert.ToDateTime(memberListDGV.SelectedRows[0].Cells[6].Value);
            member_sexComboBox.SelectedItem = memberListDGV.SelectedRows[0].Cells[7].Value;
            member_familyComboBox.SelectedValue = memberListDGV.SelectedRows[0].Cells[45].Value;


            member_additionalInfoTextBox.Text = memberListDGV.SelectedRows[0].Cells[30].Value.ToString();

            try
            {
                member_weredaNumericUpDown.Value = Convert.ToInt32(memberListDGV.SelectedRows[0].Cells[9].Value);
            }
            catch (Exception)
            {


            }
            member_subcityComboBox.SelectedItem = memberListDGV.SelectedRows[0].Cells[8].Value;
            member_seferComboBox.SelectedValue = memberListDGV.SelectedRows[0].Cells[10].Value;
            member_houseNoTextBox.Text = memberListDGV.SelectedRows[0].Cells[11].Value.ToString();
            member_phone1TextBox.Text = memberListDGV.SelectedRows[0].Cells[12].Value.ToString();
            member_emailTextBox.Text = memberListDGV.SelectedRows[0].Cells[13].Value.ToString();
            member_emgContactNameTextBox.Text = memberListDGV.SelectedRows[0].Cells[14].Value.ToString();
            member_emgContactPhoneTextBox.Text = memberListDGV.SelectedRows[0].Cells[15].Value.ToString();



            try
            {
                member_transFlagCheckBox.Checked = Convert.ToBoolean(memberListDGV.SelectedRows[0].Cells[33].Value);
            }
            catch (Exception)
            {


            }

            member_transferReasonTextBox.Text = memberListDGV.SelectedRows[0].Cells[29].Value.ToString();
            member_baptisedChurchTextBox.Text = memberListDGV.SelectedRows[0].Cells[34].Value.ToString();


            try
            {
                member_BornAgainDateDateTimePicker.Value = Convert.ToDateTime(memberListDGV.SelectedRows[0].Cells[25].Value);
            }
            catch (Exception)
            {


            }











            try
            {
                member_BaptismDateDateTimePicker.Value = Convert.ToDateTime(memberListDGV.SelectedRows[0].Cells[26].Value);
            }
            catch (Exception)
            {


            }


            member_ConfirmerComboBox.SelectedValue = memberListDGV.SelectedRows[0].Cells[31].Value;
            member_approvalLeaderComboBox.SelectedValue = memberListDGV.SelectedRows[0].Cells[32].Value;
            member_homeTeamComboBox.SelectedValue = memberListDGV.SelectedRows[0].Cells[46].Value;
            member_ServiceGiftTextBox.Text = memberListDGV.SelectedRows[0].Cells[27].Value.ToString();
            member_specialSkillTextBox.Text = memberListDGV.SelectedRows[0].Cells[17].Value.ToString();
            member_EducLevelComboBox.SelectedItem = memberListDGV.SelectedRows[0].Cells[18].Value;
            member_EducField1ComboBox.SelectedValue = memberListDGV.SelectedRows[0].Cells[19].Value;
            member_EducField2ComboBox.SelectedValue = memberListDGV.SelectedRows[0].Cells[20].Value;
            member_JobAndEducStatusComboBox.SelectedItem = memberListDGV.SelectedRows[0].Cells[21].Value;
            member_jobTypeComboBox.Text = memberListDGV.SelectedRows[0].Cells[22].Value.ToString();
            member_officePhoneTextBox.Text = memberListDGV.SelectedRows[0].Cells[23].Value.ToString();





            Member_famRolCombo.SelectedItem = memberListDGV.SelectedRows[0].Cells[47].Value;

            transDate.Value = Convert.ToDateTime(memberListDGV.SelectedRows[0].Cells[48].Value);

            member_officeAdressTextBox.Text = memberListDGV.SelectedRows[0].Cells[24].Value.ToString();


            if (memberPicLocation.Text != "")
            {
                try
                {
                    memberPicBox.Image = Image.FromFile(memberPicLocation.Text);

                }
                catch (Exception)
                {
                    this.memberPicBox.Image = global::CIMS.Properties.Resources.person_1824144_1280;
                    
                }



            }
            else
            {
                this.memberPicBox.Image = global::CIMS.Properties.Resources.person_1824144_1280;
            }



            if (member_maritalStatusComboBox.SelectedItem.ToString() == "Single")
            {
                member_DOMDateTimePicker.Enabled = false;
            }


            if (!member_transFlagCheckBox.Checked)
            {
                member_transferReasonTextBox.Enabled = false;
                member_baptisedChurchTextBox.Enabled = false;
                transDate.Enabled = false;
            }

            if (member_transFlagCheckBox.Checked)
            {
                member_transferReasonTextBox.Enabled = true;
                member_baptisedChurchTextBox.Enabled = true;
                transDate.Enabled = true;
            }




            if (member_DOMDateTimePicker.Value.Year == 8888)
            {

                member_DOMDateTimePicker.Enabled = false;
                checkBox1.Checked = true;
            }
            else if (member_DOMDateTimePicker.Value.Year != 8888)
            {

                member_DOMDateTimePicker.Enabled = true;
                checkBox1.Checked = false;
            }






            if (member_DOMDateTimePicker.Value.Year == 8888)
            {
                member_DOMDateTimePicker.Enabled = false;
            }


            if(member_DOBDateTimePicker.Value.Year == 8888)
            {
                AgeTbox.Clear(); 
            }

            else
            {
                int age = System.DateTime.Today.Year - member_DOBDateTimePicker.Value.Year;


                AgeTbox.Text = age.ToString(); 
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            initial = 1;
            display(Convert.ToInt32(memberListDGV.SelectedRows[0].Cells[0].Value));
            oldid_box.Focus();
           
            state = 2;
            //MessageBox.Show(memberListDGV.SelectedRows[0].Cells[2].Value.ToString() );

        }

        /*     private void editBtn_Click(object sender, EventArgs e)
             {
                 var x = memberListDGV.SelectedRows[0];


                 string qry = "update member set member_photo = '"+ memberPicLocation .Text+ "'   ,member_name='"+ member_nameTextBox .Text+ "' , member_motherName = '"+ member_motherNameTextBox.Text + "'  ,member_maritalStatus= '"+ member_maritalStatusComboBox.SelectedItem.ToString() + "' ,member_noOfChild = '"+ member_noOfChildNumericUpDown.Value + "' ,member_DOB= '"+ member_DOBDateTimePicker.Value + "' ,member_DOM = '"+ member_DOMDateTimePicker.Value + "' ,member_sex='"+ member_sexComboBox.SelectedItem.ToString() + "' ,member_family='"+ member_familyComboBox.SelectedValue + "' ,member_additionalInfo='"+ member_additionalInfoTextBox.Text + "' ,member_subcity='"+ member_subcityComboBox.SelectedItem.ToString() + "' ,member_wereda='"+ member_weredaNumericUpDown.Value + "' ,member_sefer='"+ member_seferComboBox.SelectedValue + "' ,member_houseNo='"+ member_houseNoTextBox.Text + "' ,member_phone1='"+ member_phone1TextBox.Text + "' ,member_email='"+ member_emailTextBox.Text + "' ,member_emgContactName='"+ member_emgContactNameTextBox.Text + "' ,member_emgContactPhone='"+ member_emgContactPhoneTextBox.Text + "' ,member_transFlag='"+ member_transFlagCheckBox.Checked + "' ,member_transferReason='"+ member_transferReasonTextBox.Text + "' ,member_baptisedChurch='"+ member_baptisedChurchTextBox.Text + "' ,member_BornAgainDate='"+ member_BornAgainDateDateTimePicker.Value + "' ,member_BaptismDate='"+ member_BaptismDateDateTimePicker.Value + "' ,member_Confirmer='"+ member_ConfirmerComboBox.SelectedValue + "' ,member_approvalLeader='"+ member_approvalLeaderComboBox.SelectedValue + "' ,member_homeTeam='"+ member_homeTeamComboBox.SelectedValue + "',member_ServiceGift='"+ member_ServiceGiftTextBox.Text + "' ,member_specialSkill='"+ member_specialSkillTextBox.Text + "' ,member_EducLevel='"+ member_EducLevelComboBox.SelectedItem.ToString() + "' ,member_EducField1='"+ member_EducField1ComboBox.SelectedValue + "' ,member_EducField2='"+ member_EducField2ComboBox.SelectedValue + "' ,member_JobAndEducStatus='"+ member_JobAndEducStatusComboBox.SelectedItem.ToString() + "' ,member_jobType='"+ member_jobTypeComboBox.Text + "' ,member_officePhone='"+ member_officePhoneTextBox.Text + "' ,member_officeAdress='"+ member_officeAdressTextBox.Text + "' where member_id = '"+member_idTextBox.Text +"' ;";

                 try
                 {
                     SqlCommand cmd = new SqlCommand(qry, con);
                     cmd.ExecuteNonQuery();
                     fillMembersDgv();
                    /// this.memberTableAdapter.Fill(this.churchDBDataSet.Member);
                     MessageBox.Show("Successfully Edited!");
                     clearFields();
                 }
                 catch (Exception)
                 {


                 }


             }  */

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.memberTableAdapter.FillBy(this.churchDBDataSet.Member);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.memberTableAdapter.Fill(this.churchDBDataSet.Member);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void member_maritalStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (member_maritalStatusComboBox.SelectedItem.ToString() == "Single")
            {
                DateTime dt = new DateTime(8888, 08, 08);
                member_DOMDateTimePicker.Value = dt;
                member_DOMDateTimePicker.Enabled = false;

            }
            else
            {
                DateTime dt = new DateTime(8888, 08, 08);
                member_DOMDateTimePicker.Value = dt;
                member_DOMDateTimePicker.Enabled = true;
            }
        }

        private void valueTbox_TextChanged(object sender, EventArgs e)
        {

            if (byName_rdb.Checked == true)
            {



                SqlDataAdapter sda = new SqlDataAdapter("SELECT Member_id, Member_name, Member_motherName, Member_maritalStatus, Member_noOfChild, Member_DOB, Member_DOM, Member_sex, Member_subcity, Member_wereda, Member_sefer, Member_houseNo, Member_phone1, Member_email, Member_emgContactName, Member_emgContactPhone, Member_photo, Member_specialSkill, Member_EducLevel, Member_EducField1, Member_EducField2, Member_JobAndEducStatus, Member_jobType, Member_officePhone, Member_officeAdress, Member_BornAgainDate, Member_BaptismDate, Member_ServiceGift, Member_previousChurch, Member_transferReason, Member_additionalInfo, Member_Confirmer, Member_approvalLeader, Member_transFlag, Member_baptisedChurch, Member_deathFlag, Member_deathDate, Member_LeaveFlag, Member_leaveDate, Member_leaveReason, Member_backFlag, Member_backedDate, Member_bornAgain, Member_ofOtherCurch, Member_dFlag, Member_family, Member_homeTeam, Member_FamRole, Member_transDate, Member_oldid  FROM dbo.Member where member_dFlag = 'False' and Member_deathFlag = 'False' and Member_LeaveFlag= 'False' and Member_backFlag= 'False' and member_name like '%" + valueTbox.Text + "%'  ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);



                memberListDGV.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = memberListDGV.Rows.Add();

                    memberListDGV.Rows[n].Cells[50].Value = item[49].ToString();
                    memberListDGV.Rows[n].Cells[0].Value = item[0].ToString();
                    memberListDGV.Rows[n].Cells[1].Value = item[1].ToString();
                    memberListDGV.Rows[n].Cells[2].Value = item[2].ToString();
                    memberListDGV.Rows[n].Cells[3].Value = item[3].ToString();
                    memberListDGV.Rows[n].Cells[4].Value = item[4].ToString();
                    memberListDGV.Rows[n].Cells[5].Value = Convert.ToDateTime(item[5]).Date;

                    DateTime DOB = Convert.ToDateTime(item[5]);

                    DateTime today = System.DateTime.Today.Date;

                    int age = today.Year - DOB.Year;

                    memberListDGV.Rows[n].Cells[48].Value = age;

                    memberListDGV.Rows[n].Cells[6].Value = item[6].ToString();
                    memberListDGV.Rows[n].Cells[7].Value = item[7].ToString();
                    memberListDGV.Rows[n].Cells[8].Value = item[8].ToString();
                    memberListDGV.Rows[n].Cells[9].Value = item[9].ToString();
                    memberListDGV.Rows[n].Cells[10].Value = Convert.ToInt32(item[10]);
                    memberListDGV.Rows[n].Cells[11].Value = item[11].ToString();
                    memberListDGV.Rows[n].Cells[12].Value = item[12].ToString();
                    memberListDGV.Rows[n].Cells[13].Value = item[13].ToString();
                    memberListDGV.Rows[n].Cells[14].Value = item[14].ToString();
                    memberListDGV.Rows[n].Cells[15].Value = item[15].ToString();
                    memberListDGV.Rows[n].Cells[16].Value = item[16].ToString();
                    memberListDGV.Rows[n].Cells[17].Value = item[17].ToString();
                    memberListDGV.Rows[n].Cells[18].Value = item[18].ToString();
                    memberListDGV.Rows[n].Cells[19].Value = item[19].ToString();
                    memberListDGV.Rows[n].Cells[20].Value = item[20].ToString();
                    memberListDGV.Rows[n].Cells[21].Value = item[21].ToString();
                    memberListDGV.Rows[n].Cells[22].Value = item[22].ToString();
                    memberListDGV.Rows[n].Cells[23].Value = item[23].ToString();
                    memberListDGV.Rows[n].Cells[24].Value = item[24].ToString();
                    memberListDGV.Rows[n].Cells[25].Value = item[25].ToString();
                    memberListDGV.Rows[n].Cells[26].Value = item[26].ToString();
                    memberListDGV.Rows[n].Cells[27].Value = item[27].ToString();
                    memberListDGV.Rows[n].Cells[28].Value = item[28].ToString();
                    memberListDGV.Rows[n].Cells[29].Value = item[29].ToString();
                    memberListDGV.Rows[n].Cells[30].Value = item[30].ToString();
                    memberListDGV.Rows[n].Cells[31].Value = item[31].ToString();
                    memberListDGV.Rows[n].Cells[32].Value = item[32].ToString();
                    memberListDGV.Rows[n].Cells[33].Value = item[33].ToString();
                    memberListDGV.Rows[n].Cells[34].Value = item[34].ToString();
                    memberListDGV.Rows[n].Cells[35].Value = item[35].ToString();
                    memberListDGV.Rows[n].Cells[36].Value = item[36].ToString();
                    memberListDGV.Rows[n].Cells[37].Value = item[37].ToString();
                    memberListDGV.Rows[n].Cells[38].Value = item[38].ToString();
                    memberListDGV.Rows[n].Cells[39].Value = item[39].ToString();
                    memberListDGV.Rows[n].Cells[40].Value = item[40].ToString();
                    memberListDGV.Rows[n].Cells[41].Value = item[41].ToString();
                    memberListDGV.Rows[n].Cells[42].Value = item[42].ToString();
                    memberListDGV.Rows[n].Cells[43].Value = item[43].ToString();
                    memberListDGV.Rows[n].Cells[44].Value = item[44].ToString();
                    memberListDGV.Rows[n].Cells[45].Value = item[45].ToString();
                    memberListDGV.Rows[n].Cells[46].Value = item[46].ToString();
                    memberListDGV.Rows[n].Cells[47].Value = item[47].ToString();
                    memberListDGV.Rows[n].Cells[48].Value = item[48].ToString();





                }

                countBox.Text = Convert.ToString(memberListDGV.Rows.Count);
            }

            else if (byPhone_rdb.Checked == true)
            {






                SqlDataAdapter sda = new SqlDataAdapter("SELECT Member_id, Member_name, Member_motherName, Member_maritalStatus, Member_noOfChild, Member_DOB, Member_DOM, Member_sex, Member_subcity, Member_wereda, Member_sefer, Member_houseNo, Member_phone1, Member_email, Member_emgContactName, Member_emgContactPhone, Member_photo, Member_specialSkill, Member_EducLevel, Member_EducField1, Member_EducField2, Member_JobAndEducStatus, Member_jobType, Member_officePhone, Member_officeAdress, Member_BornAgainDate, Member_BaptismDate, Member_ServiceGift, Member_previousChurch, Member_transferReason, Member_additionalInfo, Member_Confirmer, Member_approvalLeader, Member_transFlag, Member_baptisedChurch, Member_deathFlag, Member_deathDate, Member_LeaveFlag, Member_leaveDate, Member_leaveReason, Member_backFlag, Member_backedDate, Member_bornAgain, Member_ofOtherCurch, Member_dFlag, Member_family, Member_homeTeam, Member_FamRole, Member_transDate , Member_oldid  FROM dbo.Member where member_dFlag = 'False' and Member_deathFlag = 'False' and Member_LeaveFlag= 'False' and Member_backFlag= 'False' and member_phone1 like '%" + valueTbox.Text + "%'    ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);



                memberListDGV.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = memberListDGV.Rows.Add();


                    memberListDGV.Rows[n].Cells[50].Value = item[49].ToString();
                    memberListDGV.Rows[n].Cells[0].Value = item[0].ToString();
                    memberListDGV.Rows[n].Cells[1].Value = item[1].ToString();
                    memberListDGV.Rows[n].Cells[2].Value = item[2].ToString();
                    memberListDGV.Rows[n].Cells[3].Value = item[3].ToString();
                    memberListDGV.Rows[n].Cells[4].Value = item[4].ToString();
                    memberListDGV.Rows[n].Cells[5].Value = Convert.ToDateTime(item[5]).Date;

                    DateTime DOB = Convert.ToDateTime(item[5]);

                    DateTime today = System.DateTime.Today.Date;

                    int age = today.Year - DOB.Year;

                    memberListDGV.Rows[n].Cells[48].Value = age;
                    memberListDGV.Rows[n].Cells[6].Value = item[6].ToString();
                    memberListDGV.Rows[n].Cells[7].Value = item[7].ToString();
                    memberListDGV.Rows[n].Cells[8].Value = item[8].ToString();
                    memberListDGV.Rows[n].Cells[9].Value = item[9].ToString();
                    memberListDGV.Rows[n].Cells[10].Value = Convert.ToInt32(item[10]);
                    memberListDGV.Rows[n].Cells[11].Value = item[11].ToString();
                    memberListDGV.Rows[n].Cells[12].Value = item[12].ToString();
                    memberListDGV.Rows[n].Cells[13].Value = item[13].ToString();
                    memberListDGV.Rows[n].Cells[14].Value = item[14].ToString();
                    memberListDGV.Rows[n].Cells[15].Value = item[15].ToString();
                    memberListDGV.Rows[n].Cells[16].Value = item[16].ToString();
                    memberListDGV.Rows[n].Cells[17].Value = item[17].ToString();
                    memberListDGV.Rows[n].Cells[18].Value = item[18].ToString();
                    memberListDGV.Rows[n].Cells[19].Value = item[19].ToString();
                    memberListDGV.Rows[n].Cells[20].Value = item[20].ToString();
                    memberListDGV.Rows[n].Cells[21].Value = item[21].ToString();
                    memberListDGV.Rows[n].Cells[22].Value = item[22].ToString();
                    memberListDGV.Rows[n].Cells[23].Value = item[23].ToString();
                    memberListDGV.Rows[n].Cells[24].Value = item[24].ToString();
                    memberListDGV.Rows[n].Cells[25].Value = item[25].ToString();
                    memberListDGV.Rows[n].Cells[26].Value = item[26].ToString();
                    memberListDGV.Rows[n].Cells[27].Value = item[27].ToString();
                    memberListDGV.Rows[n].Cells[28].Value = item[28].ToString();
                    memberListDGV.Rows[n].Cells[29].Value = item[29].ToString();
                    memberListDGV.Rows[n].Cells[30].Value = item[30].ToString();
                    memberListDGV.Rows[n].Cells[31].Value = item[31].ToString();
                    memberListDGV.Rows[n].Cells[32].Value = item[32].ToString();
                    memberListDGV.Rows[n].Cells[33].Value = item[33].ToString();
                    memberListDGV.Rows[n].Cells[34].Value = item[34].ToString();
                    memberListDGV.Rows[n].Cells[35].Value = item[35].ToString();
                    memberListDGV.Rows[n].Cells[36].Value = item[36].ToString();
                    memberListDGV.Rows[n].Cells[37].Value = item[37].ToString();
                    memberListDGV.Rows[n].Cells[38].Value = item[38].ToString();
                    memberListDGV.Rows[n].Cells[39].Value = item[39].ToString();
                    memberListDGV.Rows[n].Cells[40].Value = item[40].ToString();
                    memberListDGV.Rows[n].Cells[41].Value = item[41].ToString();
                    memberListDGV.Rows[n].Cells[42].Value = item[42].ToString();
                    memberListDGV.Rows[n].Cells[43].Value = item[43].ToString();
                    memberListDGV.Rows[n].Cells[44].Value = item[44].ToString();
                    memberListDGV.Rows[n].Cells[45].Value = item[45].ToString();
                    memberListDGV.Rows[n].Cells[46].Value = item[46].ToString();
                    memberListDGV.Rows[n].Cells[47].Value = item[47].ToString();
                    memberListDGV.Rows[n].Cells[48].Value = item[48].ToString();






                }



                countBox.Text = Convert.ToString(memberListDGV.Rows.Count);




            }
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.memberTableAdapter.Fill(this.churchDBDataSet.Member);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                System.Diagnostics.Process.Start("c:\\EthioCalendar.exe");
            }
            catch (Exception)
            {


            }


        }

        private void button3_Click(object sender, EventArgs e)
        {



            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Permission where permission_uname = '" + Login.currentUser + "' and permission_name = 'Death' and Permission_value = 'True' ", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (Convert.ToInt32(dt.Rows[0][0]) > 0)
            {


                var confirmResult = MessageBox.Show("Are you sure Making a Death Record?", "CIMS", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {

                    if (memberListDGV.SelectedRows.Count < 1)
                    {
                        MessageBox.Show("Please Select Member First!");
                    }

                    else
                    {
                        RegisterMember.deathId = Convert.ToInt32(memberListDGV.SelectedRows[0].Cells[0].Value);
                        DeathForm df = new DeathForm();
                        df.ShowDialog();
                        fillMembersDgv();
                    }

                }
                else
                {

                }



            }
            else
            {

                MessageBox.Show("You Have No Permission!");

            }



        }

        private void button4_Click(object sender, EventArgs e)
        {



            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Permission where permission_uname = '" + Login.currentUser + "' and permission_name = 'Leave' and Permission_value = 'True' ", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (Convert.ToInt32(dt.Rows[0][0]) > 0)
            {

                var confirmResult = MessageBox.Show("Are you sure to Make a Leave Record?", "CIMS", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {

                    if (memberListDGV.SelectedRows.Count < 1)
                    {
                        MessageBox.Show("Please Select Member First!");
                    }

                    else
                    {
                        RegisterMember.leaveId = Convert.ToInt32(memberListDGV.SelectedRows[0].Cells[0].Value);
                        LeaveForm lf = new LeaveForm();
                        lf.ShowDialog();
                        fillMembersDgv();
                    }



                }



            }
            else
            {
                MessageBox.Show("You Have No Permission!");
            }




        }

        private void button5_Click(object sender, EventArgs e)
        {



            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Permission where permission_uname = '" + Login.currentUser + "' and permission_name = 'Back' and Permission_value = 'True' ", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (Convert.ToInt32(dt.Rows[0][0]) > 0)
            {

                var confirmResult = MessageBox.Show("Are you sure to Make a Back Record?", "CIMS", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    if (memberListDGV.SelectedRows.Count < 1)
                    {
                        MessageBox.Show("Please Select Member First!");
                    }

                    else
                    {
                        RegisterMember.backId = Convert.ToInt32(memberListDGV.SelectedRows[0].Cells[0].Value);
                        backForm bf = new backForm();
                        bf.ShowDialog();
                        fillMembersDgv();
                    }
                }


            }
            else
            {
                MessageBox.Show("You Have No Permission!");
            }





        }

        private void button6_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            int count = memberListDGV.Rows.Count;
            printer.Title = "Repi Full Gospel Belivers Local Church\n\n";
            printer.SubTitle = "\t \t    Members List at " + string.Format("Date: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy")) + "             Total = " + count ;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            //printer.RowHeight =  ;
            printer.PageNumberInHeader = false;

            
           // printer.TitleBackground =  Color.Red;

            printer.ShowTotalPageNumber = true;

            printer.RowHeight = DGVPrinter.RowHeightSetting.CellHeight;

            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Far;
            printer.Footer = "CIMS. by Anquar Technologies";
            printer.FooterSpacing = 15;
            printer.PrintPreviewDataGridView(memberListDGV);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LivingArea la = new LivingArea();
            la.ShowDialog();
        }

        private void member_seferComboBox_DropDown(object sender, EventArgs e)
        {
            this.seferTableAdapter.Fill(this.churchDBDataSet.sefer);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EducField ef = new EducField();
            ef.ShowDialog();

        }

        private void member_EducField1ComboBox_DropDown(object sender, EventArgs e)
        {
            int x = member_EducField2ComboBox.SelectedIndex;
            this.educFieldTableAdapter.Fill(this.churchDBDataSet.EducField);
            member_EducField2ComboBox.SelectedIndex = x;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void checkBox1_Click(object sender, EventArgs e)
        {




        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                int year = System.DateTime.Today.Date.Year;
                int dob = year - Convert.ToInt32(numericUpDown1.Value);


                DateTime dt = new DateTime(dob, 01, 01);

                member_DOBDateTimePicker.Value = dt;


                checkBox2.Focus();

                AgeTbox.Text = numericUpDown1.Value.ToString();
            }
        }

        private void member_DOBDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (member_DOBDateTimePicker.Value.Year != 8888)
            {

                int age = DateTime.Today.Date.Year - member_DOBDateTimePicker.Value.Year;
                AgeTbox.Text = age.ToString();
                numericUpDown1.Value = age;

            }


        }


        public void save()
        {
            int i = 0;
            string s = member_idTextBox.Text;
            bool result = int.TryParse(s, out i);

            if (result == true)
            {


                if (member_idTextBox.Text != "" && member_idTextBox.Text != "0")
                {


                    var confirmResult = MessageBox.Show("Are you sure to Save?", "CIMS", MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {

                        if (state == 1)  // add new
                        {


                            string last_code = null;
                            SqlDataAdapter sda = new SqlDataAdapter("select countLast from Counts where countName = 'Members' ", con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            foreach (DataRow item in dt.Rows)
                            {

                                last_code = item[0].ToString();
                            }

                            int last = Convert.ToInt32(last_code);


                            int cur = Convert.ToInt32(member_idTextBox.Text);

                            //    MessageBox.Show("Last is:  " + last + "    cur is: "+cur);

                            if (cur > last)
                            {





                                string qry = null;
                                qry = "insert into  member ( member_id, member_photo, member_name, member_motherName, member_maritalStatus, member_noOfChild, member_DOB, member_DOM, member_sex, member_family,   Member_FamRole , member_additionalInfo, member_subcity, member_wereda, member_sefer, member_houseNo, member_phone1, member_email, member_emgContactName, member_emgContactPhone, member_transFlag, member_transferReason, member_baptisedChurch, member_BornAgainDate, member_BaptismDate, member_Confirmer, member_approvalLeader, member_homeTeam, member_ServiceGift, member_specialSkill, member_EducLevel, member_EducField1, member_EducField2, member_JobAndEducStatus, member_jobType, member_officePhone, member_officeAdress, Member_deathFlag, Member_LeaveFlag, Member_backFlag, Member_dFlag, Member_transDate, Member_OldID ) values ('" + member_idTextBox.Text + "', '" + memberPicLocation.Text + "'   , '" + member_nameTextBox.Text + "' , '" + member_motherNameTextBox.Text + "' , '" + member_maritalStatusComboBox.SelectedItem.ToString() + "' , '" + member_noOfChildNumericUpDown.Value + "' , '" + member_DOBDateTimePicker.Value + "'  , '" + member_DOMDateTimePicker.Value + "' , '" + member_sexComboBox.SelectedItem.ToString() + "' , '" + member_familyComboBox.SelectedValue + "' , '" + Member_famRolCombo.SelectedItem.ToString() + "'  ,   '" + member_additionalInfoTextBox.Text + "' , '" + member_subcityComboBox.SelectedItem.ToString() + "' , '" + member_weredaNumericUpDown.Value + "' , '" + member_seferComboBox.SelectedValue + "' , '" + member_houseNoTextBox.Text + "' , '" + member_phone1TextBox.Text + "' , '" + member_emailTextBox.Text + "' , '" + member_emgContactNameTextBox.Text + "' , '" + member_emgContactPhoneTextBox.Text + "' , '" + member_transFlagCheckBox.Checked + "' , '" + member_transferReasonTextBox.Text + "' , '" + member_baptisedChurchTextBox.Text + "' , '" + member_BornAgainDateDateTimePicker.Value + "' , '" + member_BaptismDateDateTimePicker.Value + "' , '" + member_ConfirmerComboBox.SelectedValue + "' , '" + member_approvalLeaderComboBox.SelectedValue + "' , '" + member_homeTeamComboBox.SelectedValue + "' , '" + member_ServiceGiftTextBox.Text + "' , '" + member_specialSkillTextBox.Text + "' , '" + member_EducLevelComboBox.SelectedItem.ToString() + "' , '" + member_EducField1ComboBox.SelectedValue + "' , '" + member_EducField2ComboBox.SelectedValue + "' , '" + member_JobAndEducStatusComboBox.SelectedItem.ToString() + "' , '" + member_jobTypeComboBox.Text + "' , '" + member_officePhoneTextBox.Text + "' , '" + member_officeAdressTextBox.Text + "', 'False', 'False', 'False', 'False', '" + transDate.Value + "', '"+oldid_box.Text+"'  )";
                                // MessageBox.Show(qry);
                                SqlCommand cmd = new SqlCommand(qry, con);
                                cmd.ExecuteNonQuery();



                                qry = "update Counts set countLast =  '" + member_idTextBox.Text + "' where countName = 'members'";


                                cmd = new SqlCommand(qry, con);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Successfully Saved!");
                                clearFields();

                                fillMembersDgv();
                                tabControl1.SelectedIndex = 0;
                            }

                        }
                        else if (state == 2)  // edit
                        {

                            var x = memberListDGV.SelectedRows[0];


                            string qry = "update member set member_photo = '" + memberPicLocation.Text + "'   ,member_name='" + member_nameTextBox.Text + "' , member_motherName = '" + member_motherNameTextBox.Text + "'  ,member_maritalStatus= '" + member_maritalStatusComboBox.SelectedItem.ToString() + "' ,member_noOfChild = '" + member_noOfChildNumericUpDown.Value + "' ,member_DOB= '" + member_DOBDateTimePicker.Value + "' ,member_DOM = '" + member_DOMDateTimePicker.Value + "' ,member_sex='" + member_sexComboBox.SelectedItem.ToString() + "' ,member_family='" + member_familyComboBox.SelectedValue + "' ,member_additionalInfo='" + member_additionalInfoTextBox.Text + "' ,member_subcity='" + member_subcityComboBox.SelectedItem.ToString() + "' ,member_wereda='" + member_weredaNumericUpDown.Value + "' ,member_sefer='" + member_seferComboBox.SelectedValue + "' ,member_houseNo='" + member_houseNoTextBox.Text + "' ,member_phone1='" + member_phone1TextBox.Text + "' ,member_email='" + member_emailTextBox.Text + "' ,member_emgContactName='" + member_emgContactNameTextBox.Text + "' ,member_emgContactPhone='" + member_emgContactPhoneTextBox.Text + "' ,member_transFlag='" + member_transFlagCheckBox.Checked + "' ,member_transferReason='" + member_transferReasonTextBox.Text + "' ,member_baptisedChurch='" + member_baptisedChurchTextBox.Text + "' ,member_BornAgainDate='" + member_BornAgainDateDateTimePicker.Value + "' ,member_BaptismDate='" + member_BaptismDateDateTimePicker.Value + "' ,member_Confirmer='" + member_ConfirmerComboBox.SelectedValue + "' ,member_approvalLeader='" + member_approvalLeaderComboBox.SelectedValue + "' ,member_homeTeam='" + member_homeTeamComboBox.SelectedValue + "',member_ServiceGift='" + member_ServiceGiftTextBox.Text + "' ,member_specialSkill='" + member_specialSkillTextBox.Text + "' ,member_EducLevel='" + member_EducLevelComboBox.SelectedItem.ToString() + "' ,member_EducField1='" + member_EducField1ComboBox.SelectedValue + "' ,member_EducField2='" + member_EducField2ComboBox.SelectedValue + "' ,member_JobAndEducStatus='" + member_JobAndEducStatusComboBox.SelectedItem.ToString() + "' ,member_jobType='" + member_jobTypeComboBox.Text + "' ,member_officePhone='" + member_officePhoneTextBox.Text + "' ,member_officeAdress='" + member_officeAdressTextBox.Text + "', Member_transDate = '" + transDate.Value + "', Member_oldid = '"+oldid_box.Text+ "'  where member_id = '" + member_idTextBox.Text + "' ;";

                            try
                            {
                                SqlCommand cmd = new SqlCommand(qry, con);
                                cmd.ExecuteNonQuery();
                                fillMembersDgv();
                                /// this.memberTableAdapter.Fill(this.churchDBDataSet.Member);
                                MessageBox.Show("Successfully Saved!");
                                clearFields();
                                fillMembersDgv();
                                tabControl1.SelectedIndex = 0;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error on Saving Your Data!   "+ ex.Message.ToString());


                            }



                        }

                    }

                }
              



            }
            else
            {
                MessageBox.Show("You Must Click New Button Before Saving Data.");
            }
        }




        private void button9_Click(object sender, EventArgs e)
        {

            save();

        }

        private void member_transFlagCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (member_transFlagCheckBox.Checked)
            {
                member_transferReasonTextBox.Enabled = true;
                member_baptisedChurchTextBox.Enabled = true;
                transDate.Enabled = true;
            }

            if (!member_transFlagCheckBox.Checked)
            {
                member_transferReasonTextBox.Enabled = false;
                member_baptisedChurchTextBox.Enabled = false;
                transDate.Enabled = false;
            }


        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                DateTime dt = new DateTime(8888, 08, 08);
                member_DOMDateTimePicker.Value = dt;
                member_DOMDateTimePicker.Enabled = false;
            }
            else
            {

                member_DOMDateTimePicker.Value = System.DateTime.Today.Date;
                member_DOMDateTimePicker.Enabled = true;
            }





        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (unkDOT.Checked)
            {


                DateTime dt = new DateTime(8888, 08, 08);
                transDate.Value = dt;
                transDate.Enabled = false;

            }
            else
            {


                transDate.Value = System.DateTime.Today.Date;
                transDate.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                DateTime dt = new DateTime(8888, 08, 08);
                member_BornAgainDateDateTimePicker.Value = dt;
                member_BornAgainDateDateTimePicker.Enabled = false;
            }
            else
            {

                member_BornAgainDateDateTimePicker.Value = System.DateTime.Today.Date;
                member_BornAgainDateDateTimePicker.Enabled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {


            if (checkBox4.Checked)
            {
                DateTime dt = new DateTime(8888, 08, 08);
                member_BaptismDateDateTimePicker.Value = dt;
                member_BaptismDateDateTimePicker.Enabled = false;
            }
            else
            {

                member_BaptismDateDateTimePicker.Value = System.DateTime.Today.Date;
                member_BaptismDateDateTimePicker.Enabled = true;
            }


        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {


            if (checkBox2.Checked)
            {
                DateTime dt = new DateTime(8888, 08, 08);
                member_DOBDateTimePicker.Value = dt;
                member_DOBDateTimePicker.Enabled = false;
                numericUpDown1.Value = 0;
                AgeTbox.Clear();
            }
            else
            {

                member_DOBDateTimePicker.Value = System.DateTime.Today.Date;
                member_DOBDateTimePicker.Enabled = true;
            }


        }

        private void member_EducField2ComboBox_DropDown(object sender, EventArgs e)
        {
            int x = member_EducField1ComboBox.SelectedIndex;
            this.educFieldTableAdapter.Fill(this.churchDBDataSet.EducField);
            member_EducField1ComboBox.SelectedIndex = x;



        }

        private void memberListDGV_SelectionChanged(object sender, EventArgs e)
        {
            //clearFields();

              
            
            
        }

        private void memberListDGV_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void memberListDGV_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void memberListDGV_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                clearFields();
                display(Convert.ToInt32(memberListDGV.SelectedRows[0].Cells[0].Value));
                
                state = 2;

            }
        }

        private void member_nameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_DOBDateTimePicker.Focus();

            }
        }

        private void member_sexComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_motherNameTextBox.Focus();

            }
        }

        private void member_motherNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_maritalStatusComboBox.Focus();

            }
        }

        private void member_maritalStatusComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {



                if (member_maritalStatusComboBox.SelectedItem.ToString() == "Single")
                {
                    member_noOfChildNumericUpDown.Focus();
                }
                else
                {
                    member_DOMDateTimePicker.Focus();
                }





            }
        }

        private void member_DOMDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                checkBox1.Focus();

            }
        }

        private void member_noOfChildNumericUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_familyComboBox.Focus();

            }
        }

        private void member_baptisedChurchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                tabControl1.SelectedIndex = 1;
                member_BornAgainDateDateTimePicker.Focus();

            }
        }

        private void member_BornAgainDateDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                checkBox3.Focus();

            }
        }

        private void checkBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_BaptismDateDateTimePicker.Focus();

            }
        }

        private void member_BaptismDateDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                checkBox4.Focus();

            }
        }

        private void checkBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_ConfirmerComboBox.Focus();

            }
        }

        private void member_ConfirmerComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_approvalLeaderComboBox.Focus();

            }
        }

        private void member_approvalLeaderComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_homeTeamComboBox.Focus();

            }
        }

        private void member_homeTeamComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_ServiceGiftTextBox.Focus();

            }
        }

        private void member_ServiceGiftTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_specialSkillTextBox.Focus();

            }
        }

        private void member_specialSkillTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_transFlagCheckBox.Focus();

            }
        }

        private void member_EducLevelComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_EducField1ComboBox.Focus();

            }
        }

        private void member_EducField1ComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_EducField2ComboBox.Focus();

            }
        }

        private void member_EducField2ComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_JobAndEducStatusComboBox.Focus();

            }
        }

        private void member_JobAndEducStatusComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_jobTypeComboBox.Focus();

            }
        }

        private void member_jobTypeComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_officePhoneTextBox.Focus();

            }
        }

        private void member_officePhoneTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_officeAdressTextBox.Focus();

            }
        }

        private void member_officeAdressTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                tabControl1.SelectedIndex = 1;
                member_BornAgainDateDateTimePicker.Focus();

            }

        }

        private void member_DOBDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                numericUpDown1.Focus();

            }
        }

        private void checkBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_sexComboBox.Focus();

            }
        }

        private void checkBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_noOfChildNumericUpDown.Focus();

            }
        }

        private void Member_famRolCombo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_subcityComboBox.Focus();

            }
        }

        private void member_subcityComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_weredaNumericUpDown.Focus();

            }
        }

        private void member_weredaNumericUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_seferComboBox.Focus();

            }
        }

        private void member_seferComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_houseNoTextBox.Focus();

            }
        }

        private void member_houseNoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_phone1TextBox.Focus();

            }
        }

        private void member_phone1TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_emailTextBox.Focus();

            }
        }

        private void member_emailTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_emgContactNameTextBox.Focus();

            }
        }

        private void member_emgContactNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_emgContactPhoneTextBox.Focus();

            }
        }

        private void member_emgContactPhoneTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_EducLevelComboBox.Focus();

            }
        }

        private void member_transFlagCheckBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (member_transFlagCheckBox.Checked == false)
                {
                    
                    member_transferReasonTextBox.Focus();
                }
                else
                {
                    member_transferReasonTextBox.Focus();
                }



            }
        }

        private void member_transferReasonTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                transDate.Focus();

            }
        }

        private void transDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                unkDOT.Focus();

            }
        }

        private void unkDOT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                member_baptisedChurchTextBox.Focus();

            }
        }

        private void member_familyComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                Member_famRolCombo.Focus();

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            memberPicLocation.Clear();
            this.memberPicBox.Image = global::CIMS.Properties.Resources.person_1824144_1280;
        }

        private void memberPicBox_Click(object sender, EventArgs e)
        {
            if (memberPicLocation.Text != "")
            {
                Shared.path = memberPicLocation.Text;
                phv p = new phv();
                p.ShowDialog();
            }



        }

        private void button11_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to Delete Member?", "CIMS", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {

                if (member_idTextBox.Text != "")
                {
                    string qry = "update member set member_dFlag = 'True' where member_id = '" + member_idTextBox.Text + "' ";

                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();
                    fillMembersDgv();
                    clearFields();
                    MessageBox.Show("Member info Deleted Successfully!");
                }
                else
                {
                    MessageBox.Show("No Member Selected!");
                }

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();










        }




        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
           

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {



            Bitmap bm = new Bitmap(memberPicBox.Width, memberPicBox.Height);
            memberPicBox.DrawToBitmap(bm, new Rectangle(0, 0, memberPicBox.Width, memberPicBox.Height));
            e.Graphics.DrawImage(bm, 100, 50);





            int y1 = memberPicBox.Height + 50;
            e.Graphics.DrawString("Full Name: " , new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100 + memberPicBox.Width + 50,  60));

            e.Graphics.DrawString( member_nameTextBox.Text + "\n", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(100 + memberPicBox.Width + 185, 60));



            int y2 = y1 + 50;
            e.Graphics.DrawString("Age : " , new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100 + memberPicBox.Width + 50, 100));

            e.Graphics.DrawString( AgeTbox.Text + "\n", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(100 + memberPicBox.Width + 185, 100));




            int y3 = y2 + 50;

            e.Graphics.DrawString("Gender:  ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100 + memberPicBox.Width + 50, 150)) ;

            e.Graphics.DrawString( member_sexComboBox.SelectedItem.ToString() + "\n", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(100 + memberPicBox.Width + 185, 150));




            int y4 = 150 + 50;

            e.Graphics.DrawString("Marital Status:  " , new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100 + memberPicBox.Width + 50, y4 ));

            e.Graphics.DrawString(member_maritalStatusComboBox.SelectedItem.ToString() + "\n", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(100 + memberPicBox.Width + 185, y4 ));




            int y5 = y4 + 30;

            e.Graphics.DrawString("Subcity: " , new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, y5 + 50));

            e.Graphics.DrawString( member_subcityComboBox.SelectedItem.ToString() + "\n", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(350, y5 + 50));



            int y6 = y5 + 50;

            e.Graphics.DrawString("Wereda: " , new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, y6 + 50));

            e.Graphics.DrawString( member_weredaNumericUpDown.Value.ToString() + "\n", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(350, y6 + 50));




            int y7 = y6 + 50;

            e.Graphics.DrawString("Living Area: " , new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, y7 + 50));

            e.Graphics.DrawString(member_seferComboBox.Text + "\n", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(350, y7 + 50));




            int y8 = y7 + 50;

            e.Graphics.DrawString("House No: " , new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, y8 + 50));

            e.Graphics.DrawString(member_houseNoTextBox.Text + "\n", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(350, y8 + 50));



            int y9 = y8 + 50;

            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(30, y9 + 50));

            int yy9 = y9 + 50;

            e.Graphics.DrawString("Phone Number: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, yy9 + 50));

            e.Graphics.DrawString( member_phone1TextBox.Text + "\n", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(350, yy9 + 50));




            int y10 = yy9 + 50;

            e.Graphics.DrawString("Emergency Contact Name: " , new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, y10 + 50));

            e.Graphics.DrawString( member_emgContactNameTextBox.Text + "\n", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(350, y10 + 50));



            int y11 = y10 + 50;

            e.Graphics.DrawString("Emergency Contact Phone: " , new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, y11 + 50));


            e.Graphics.DrawString( member_emgContactPhoneTextBox.Text + "\n", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(350, y11 + 50));
            





            int y12 = y11 + 50;

            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(30, y12 + 50));





            int y13 = y12 + 50;

            e.Graphics.DrawString("Education Level: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, y13 + 50));


            e.Graphics.DrawString(member_EducLevelComboBox.Text + "\n", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(350, y13 + 50));


            int y14 = y13 + 50;

            e.Graphics.DrawString("Education Field: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, y14 + 50));
         

     if (member_EducField1ComboBox.Text != "NONE")
      {
                e.Graphics.DrawString(member_EducField1ComboBox.Text + "\n", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(350, y14 + 50));

                if (member_EducField2ComboBox.Text != "NONE")
               {
                   e.Graphics.DrawString( ", "+member_EducField2ComboBox.Text + "\n", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(510, y14 + 50));
               }

      }
     else
       {

            if (member_EducField2ComboBox.Text != "NONE")
            {
                 e.Graphics.DrawString(member_EducField2ComboBox.Text + "\n", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(350, y14 + 50));
            }

       }


            int y15 = y14 + 50;

            e.Graphics.DrawString("Job Status: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, y15 + 50));

            e.Graphics.DrawString( member_JobAndEducStatusComboBox.Text + "\n", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(350, y15 + 50));







            Pen blackPen = new Pen(Color.Black, 3);

            // Create rectangle.
            Rectangle rect = new Rectangle(30, 30, 775, 200);

            Rectangle rect2 = new Rectangle(30, 230, 775, 800);

            // Draw rectangle to screen.
            e.Graphics.DrawRectangle(blackPen, rect);

            e.Graphics.DrawRectangle(blackPen, rect2);



            e.Graphics.DrawString("Repi Full Gospel Church.                                                 Member Information                                \t\t"+ System.DateTime.Today.Date.Year+"/"+ System.DateTime.Today.Date.Month+"/"+ System.DateTime.Today.Date.Day, new Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, new PointF(50, 1050));

           

        }

        private void member_nameTextBox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void member_nameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (member_idTextBox.Text == "")
            {
                MessageBox.Show("Please Click On New Button Before Registering new Member!");
                
            }
            
           
        }

        private void member_motherNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void member_motherNameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void member_transferReasonTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void member_baptisedChurchTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void member_additionalInfoTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void member_houseNoTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void member_phone1TextBox_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void member_emailTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void member_emgContactNameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void member_emgContactPhoneTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void byPhone_rdb_CheckedChanged(object sender, EventArgs e)
        {
            valueTbox.Clear();

        }

        private void byName_rdb_CheckedChanged(object sender, EventArgs e)
        {
            valueTbox.Clear();
        }

        private void AgeTbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString("በኢትዮጵያ ሙሉ ወንጌል አማኞች ቤተክርስቲያን", new Font("Arial", 23, FontStyle.Bold), Brushes.Black, new PointF(110, 25));
            e.Graphics.DrawString("የረጲ አጥቢያ ቤተክርስቲያን", new Font("Arial", 23, FontStyle.Bold), Brushes.Black, new PointF(217, 55));



            Pen blackPen = new Pen(Color.Black, 5);

           
           // Rectangle rect = new Rectangle(30, 30, 775, 200);

           // Rectangle rect2 = new Rectangle(30, 230, 775, 800);

          
           // e.Graphics.DrawRectangle(blackPen, rect);

           // e.Graphics.DrawRectangle(blackPen, rect2);


            //                            x1   y1    x2    y2
            e.Graphics.DrawLine(blackPen, 0, 100, 850, 100);

           








        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog2.ShowDialog() == DialogResult.OK)
                printDocument2.Print();
        }

        private void memberListDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void valueTbox_Click(object sender, EventArgs e)
        {
            valueTbox.Clear();
        }

        private void oldid_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                save();

            }
        }
    }
}
