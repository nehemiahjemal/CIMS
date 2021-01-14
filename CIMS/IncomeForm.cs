using DGVPrinterHelper;
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
    public partial class IncomeForm : Form
    {
        SqlConnection con = null;
        public static string incomeby = "0";
        public static string recvdBy = "0";
        public static string saveFlag = "";
        public IncomeForm()
        {
            InitializeComponent();
            
            con = DBConnection.Connect();
            con.Open();
        }





        public void clearFields()
        {
            income_idTextBox.Clear();
            income_reasonComboBox.SelectedIndex = 0;
            income_byComboBox.SelectedIndex = 0;
            income_DateDateTimePicker.Value = System.DateTime.Today.Date;
            income_ofYearComboBox.SelectedIndex = 0;
            income_ofMonthComboBox.SelectedIndex = 0;
            
            income_receivedByComboBox.SelectedIndex = 0;
            income_valueNumericUpDown.Value = 0;
            income_ReceitNoTextBox.Clear();
            income_remarkTextBox.Clear();

            incomeDGV.ClearSelection();

        }


        public void displayIncome()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select   income_id, income_reason, income_by, Income_value , income_ofYear, income_ofMonth, income_receivedBy, income_Date, income_ReceitNo, income_remark, income_void   from income where income_Date = '"+incomeDatepicker.Value+"' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            noOfInc.Text = "";
            TotInc.Text = "";

            int No_of_income = 0;
            int total_income = 0;

            incomeDGV.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = incomeDGV.Rows.Add();


               // MessageBox.Show(" item 0: " + item[0] + " item 1 : " + item[1] + " item 7: " + item[7] + " item 8: "+item[8]) ;
                incomeDGV.Rows[n].Cells[0].Value = item[0];
                incomeDGV.Rows[n].Cells[1].Value = item[1];
                incomeDGV.Rows[n].Cells[2].Value = item[2];
                incomeDGV.Rows[n].Cells[3].Value = item[3];
                incomeDGV.Rows[n].Cells[4].Value = item[4];
                incomeDGV.Rows[n].Cells[5].Value = item[5];
                
                incomeDGV.Rows[n].Cells[6].Value = item[6];
                incomeDGV.Rows[n].Cells[7].Value = item[7];
                incomeDGV.Rows[n].Cells[8].Value = item[8];
                incomeDGV.Rows[n].Cells[9].Value = item[9];

                
                if(item[10].ToString()== "True")
                {
                    incomeDGV.Rows[n].DefaultCellStyle.BackColor = Color.Red;

                  
                    

                    

                   

                }

                


                

                No_of_income++;
                total_income = total_income + Convert.ToInt32(item[3]);


            }

            noOfInc.Text = "  No Of Income: "+ No_of_income;
            TotInc.Text = " Total Income: "+total_income;

        }







        private void addBtn_Click(object sender, EventArgs e)
        {
            
            if(saveFlag=="insert")
            {
                if (income_idTextBox.Text != "")
                {


                    var confirmResult = MessageBox.Show("Are you sure to Insert new income record?", "CIMS", MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        string qry = null;
                    qry = "insert into  Income ( income_id, income_reason, income_by, income_Date, income_ofYear, income_ofMonth, income_receivedBy, income_value, income_ReceitNo, income_remark, income_void ) values (  '" + income_idTextBox.Text + "'  , '" + income_reasonComboBox.SelectedValue + "' , '" + income_byComboBox.SelectedValue + "' , '" + income_DateDateTimePicker.Value + "' ,'" + income_ofYearComboBox.SelectedItem.ToString() + "' ,'" + income_ofMonthComboBox.SelectedItem.ToString() + "'   , '" + income_receivedByComboBox.SelectedValue + "' ,'" + income_valueNumericUpDown.Value + "' , '" + income_ReceitNoTextBox.Text + "' , '" + income_remarkTextBox.Text + "', 'False' )";

                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();



                    qry = "update Counts set countLast =  '" + income_idTextBox.Text + "' where countName = 'Income'";


                    cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully Saved!");
                    clearFields();

                    displayIncome();

                    saveFlag = "";


                }

                }
                else
                {

                    MessageBox.Show("Please select New button first!");

                }
            }
            else if(saveFlag=="update")
            {
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Permission where permission_uname = '" + Login.currentUser + "' and permission_name = 'IncomeEdit' and Permission_value = 'True' ", con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                if (Convert.ToInt32(dt.Rows[0][0]) > 0)
                {

                    var confirmResult = MessageBox.Show("Are you sure to save changes to this income record ?", "CIMS", MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {

                        string qry = "UPDATE income SET income_reason = '" + income_reasonComboBox.SelectedValue + "' ,income_by = '" + income_byComboBox.SelectedValue + "' ,income_date = '" + income_DateDateTimePicker.Value + "' ,income_ofYear = '" + income_ofYearComboBox.SelectedItem.ToString() + "' ,income_ofMonth = '" + income_ofMonthComboBox.SelectedItem.ToString() + "' ,income_receivedBy = '" + income_receivedByComboBox.SelectedValue + "' , income_receitNo = '" + income_ReceitNoTextBox.Text + "', income_remark = '" + income_remarkTextBox.Text + "' , income_value = '" + income_valueNumericUpDown.Value + "' WHERE income_id = '" + income_idTextBox.Text + "'";

                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();

                    displayIncome();
                    clearFields();

                    MessageBox.Show("Successfully Updated!");
                    saveFlag = "";


                }


                }
                else
                {
                    MessageBox.Show("You Have No Permission!");
                }




            }






        }

        private void IncomeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'churchDBDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.churchDBDataSet.Member);
            // TODO: This line of code loads data into the 'churchDBDataSet.IncomeSource' table. You can move, or remove it, as needed.
            this.incomeSourceTableAdapter.Fill(this.churchDBDataSet.IncomeSource);
            displayIncome();
            clearFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearFields();
            string last_code = null;
            SqlDataAdapter sda = new SqlDataAdapter("select countLast from Counts where countName = 'Income' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {

                last_code = item[0].ToString();
            }



            int x = Convert.ToInt32(last_code) + 1;
            income_idTextBox.Text = x.ToString();


            saveFlag = "insert";

            MessageBox.Show("Start Inserting new Income Record");
        }

        private void incomeDGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if ( incomeDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
            {
                e.Cancel = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IncomeReasonForm Ir = new IncomeReasonForm();
            Ir.ShowDialog();
        }

        private void income_reasonComboBox_DropDown(object sender, EventArgs e)
        {
            this.incomeSourceTableAdapter.Fill(this.churchDBDataSet.IncomeSource);
        }

        private void incomeDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //clearFields();

            income_idTextBox.Text = incomeDGV.SelectedRows[0].Cells[0].Value.ToString();
            income_reasonComboBox.SelectedValue = incomeDGV.SelectedRows[0].Cells[1].Value;
            income_byComboBox.SelectedValue = incomeDGV.SelectedRows[0].Cells[2].Value;
            income_valueNumericUpDown.Value = Convert.ToInt32(incomeDGV.SelectedRows[0].Cells[3].Value);
            income_ofYearComboBox.SelectedItem = incomeDGV.SelectedRows[0].Cells[4].Value.ToString();
            income_ofMonthComboBox.SelectedItem = incomeDGV.SelectedRows[0].Cells[5].Value.ToString();
            income_receivedByComboBox.SelectedValue = incomeDGV.SelectedRows[0].Cells[6].Value;
            income_DateDateTimePicker.Value = Convert.ToDateTime(incomeDGV.SelectedRows[0].Cells[7].Value) ;
            income_ReceitNoTextBox.Text = incomeDGV.SelectedRows[0].Cells[8].Value.ToString();
            income_remarkTextBox.Text = incomeDGV.SelectedRows[0].Cells[9].Value.ToString();




            saveFlag = "update";


        }

        private void button2_Click(object sender, EventArgs e)
        {



            







        }

        private void button4_Click(object sender, EventArgs e)
        {




            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Permission where permission_uname = '" + Login.currentUser + "' and permission_name = 'IncomeEdit' and Permission_value = 'True' ", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (Convert.ToInt32(dt.Rows[0][0]) > 0)
            {


                if (incomeDGV.SelectedRows.Count < 1 || saveFlag == "insert")
                {
                    MessageBox.Show("Please Select Income First!");
                }
                else
                {

                    var confirmResult = MessageBox.Show("Are you sure to Void this income record?", "CIMS", MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {



                        string qry = "update income set income_void = 'True' where income_id = '" + income_idTextBox.Text + "' ";

                        SqlCommand cmd = new SqlCommand(qry, con);
                        cmd.ExecuteNonQuery();

                        displayIncome();
                    clearFields();

                    MessageBox.Show("Successfully Deleted!");
                    saveFlag = "";
                }
                }
            


            }
            else
            {
                MessageBox.Show("You Have No Permission!");
            }





        



            
           
        }

        private void incomeDatepicker_ValueChanged(object sender, EventArgs e)
        {
            displayIncome();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Repi Full Gospel Belivers Local Church\n\n";
            printer.SubTitle = "\t \t    Income List " + incomeDatepicker.Value.ToString() + "";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            //printer.RowHeight =  ;
            printer.PageNumberInHeader = false;

            printer.RowHeight = DGVPrinter.RowHeightSetting.CellHeight;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Far;
            printer.Footer = "CIMS. by Anquar Technologies";
            printer.FooterSpacing = 15;
            printer.PrintPreviewDataGridView(incomeDGV);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MemberList4 m4 = new MemberList4(5);
            m4.ShowDialog();

            if (incomeby != "0") 
            {
               income_byComboBox.SelectedValue = incomeby;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {


            MemberList4 m4 = new MemberList4(6);
            m4.ShowDialog();

            if (recvdBy != "0")
            {
                income_receivedByComboBox.SelectedValue = recvdBy;
            }



        }
    }
}
