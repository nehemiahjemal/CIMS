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
    public partial class Expense_Form : Form
    {

        SqlConnection con=null;
        public Expense_Form()
        {
            InitializeComponent();
            con = DBConnection.Connect();
            con.Open();
        }

        private void Expense_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'churchDBDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.churchDBDataSet.Member);
            // TODO: This line of code loads data into the 'churchDBDataSet.ExpenseReason' table. You can move, or remove it, as needed.
            this.expenseReasonTableAdapter.Fill(this.churchDBDataSet.ExpenseReason);
            displayExpense();

            


        }


        public void clearFields()

        {




            expense_idTextBox.Clear();
            expense_reasonComboBox.SelectedIndex = 0;
            expense_detailTextBox.Clear();
            expense_issueByComboBox.SelectedIndex = 0;
            expense_issueToTextBox.Clear();
            expense_valueNumericUpDown.Value = 0;
            expense_dateDateTimePicker.Value = System.DateTime.Today.Date;
            expense_remarkTextBox.Clear();







        }

        private void expenseDGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (expenseDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearFields();
            string last_code = null;
            SqlDataAdapter sda = new SqlDataAdapter("select countLast from Counts where countName = 'Expense' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {

                last_code = item[0].ToString();
            }



            int x = Convert.ToInt32(last_code) + 1;
           expense_idTextBox.Text = x.ToString();
        }



        public void displayExpense()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select expense_id,  expense_reason,  expense_detail,  expense_issueBy,  expense_issueTo, expense_value, expense_date, expense_remark      from Expense where expense_date = '"+ExpenseDate.Value+"' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);



            int totalExpense = 0;
            int NoOfExpense = 0;


            expenseDGV.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = expenseDGV.Rows.Add();


                
                expenseDGV.Rows[n].Cells[0].Value = item[0].ToString();
                expenseDGV.Rows[n].Cells[1].Value = Convert.ToInt32(item[1].ToString());
                expenseDGV.Rows[n].Cells[2].Value = item[2].ToString();
                expenseDGV.Rows[n].Cells[3].Value = Convert.ToInt32(item[3].ToString());
                expenseDGV.Rows[n].Cells[4].Value = item[4].ToString();
                expenseDGV.Rows[n].Cells[5].Value = Convert.ToInt32(item[5]);
                expenseDGV.Rows[n].Cells[6].Value = item[6].ToString();
                expenseDGV.Rows[n].Cells[7].Value = item[7].ToString();

                NoOfExpense++;
                totalExpense = totalExpense + Convert.ToInt32(item[5]);




            }

            totExpense.Text = " Total Expense: " + totalExpense;
            expNo.Text = " No Of Expenses : " + NoOfExpense;

        }

        private void button3_Click(object sender, EventArgs e)
        {





            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Permission where permission_uname = '" + Login.currentUser + "' and permission_name = 'ExpenseAdd' and Permission_value = 'True' ", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (Convert.ToInt32(dt.Rows[0][0]) > 0)
            {


            if (expense_idTextBox.Text == "")
            {
                MessageBox.Show("Please Click New Button First!");
            }
            else
            {

                string qry = null;
                qry = "insert into  Expense ( expense_id,  expense_reason,  expense_detail,  expense_issueBy,  expense_issueTo, expense_value, expense_date, expense_remark       ) values ( '" + expense_idTextBox.Text + "' , '" + expense_reasonComboBox.SelectedValue + "' , '" + expense_detailTextBox.Text + "' , '" + expense_issueByComboBox.SelectedValue + "' , '" + expense_issueToTextBox.Text + "' , '" + expense_valueNumericUpDown.Value + "' , '" + expense_dateDateTimePicker.Value + "' , '" + expense_remarkTextBox.Text + "' )";

                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();



                qry = "update Counts set countLast =  '" + expense_idTextBox.Text + "' where countName = 'Expense'";


                cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully Saved!");
                clearFields();

                displayExpense();



            }
            

            }
            else
            {
                MessageBox.Show("You Have No Permission!");
            }







            
            
            
            
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExpenseReasonForm er = new ExpenseReasonForm();
            er.ShowDialog();
        }

        private void expense_reasonComboBox_DropDown(object sender, EventArgs e)
        {
            this.expenseReasonTableAdapter.Fill(this.churchDBDataSet.ExpenseReason);
        }

        private void expenseDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            expense_idTextBox.Text = expenseDGV.SelectedRows[0].Cells[0].Value.ToString();
            expense_reasonComboBox.SelectedValue = expenseDGV.SelectedRows[0].Cells[1].Value;
            expense_detailTextBox.Text = expenseDGV.SelectedRows[0].Cells[2].Value.ToString();
            expense_issueByComboBox.SelectedValue = expenseDGV.SelectedRows[0].Cells[3].Value;
            expense_issueToTextBox.Text = expenseDGV.SelectedRows[0].Cells[4].Value.ToString();
            expense_valueNumericUpDown.Value = Convert.ToInt32(expenseDGV.SelectedRows[0].Cells[5].Value) ;
            expense_dateDateTimePicker.Value = Convert.ToDateTime(expenseDGV.SelectedRows[0].Cells[6].Value);
            expense_remarkTextBox.Text = expenseDGV.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Permission where permission_uname = '" + Login.currentUser + "' and permission_name = 'ExpenseEdit' and Permission_value = 'True' ", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (Convert.ToInt32(dt.Rows[0][0]) > 0)
            {

                 string qry = "   UPDATE Expense SET Expense_reason = '"+expense_reasonComboBox.SelectedValue+"' ,Expense_detail = '"+expense_detailTextBox.Text+"' ,Expense_issueBy = '"+expense_issueByComboBox.SelectedValue+"' ,Expense_issueTo = '"+expense_issueToTextBox.Text+"' ,Expense_value = '"+expense_valueNumericUpDown.Value+"' ,Expense_date = '"+expense_dateDateTimePicker.Value+"' ,Expense_remark = '"+expense_remarkTextBox.Text+"' WHERE expense_id = '"+expense_idTextBox.Text+"'";
            
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();

            displayExpense();
            clearFields();
            MessageBox.Show("Successfully Updated!");


            }
            else
            {
                MessageBox.Show("You Have No Permission!");
            }





            


        }

        private void ExpenseDate_ValueChanged(object sender, EventArgs e)
        {
            displayExpense();
        }

        private void button5_Click(object sender, EventArgs e)
        {





            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Permission where permission_uname = '" + Login.currentUser + "' and permission_name = 'ExpenseEdit' and Permission_value = 'True' ", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (Convert.ToInt32(dt.Rows[0][0]) > 0)
            {


                var confirmResult = MessageBox.Show("Are you sure to delete this item ??", "CIMS", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (expenseDGV.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please Select Expense First!");
                }
                else
                {
                    string qry = "delete from expense where expense_id = '" + expense_idTextBox.Text + "'";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();

                    displayExpense();
                    clearFields();

                    MessageBox.Show("Successfully Deleted!");
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
            printer.Title = "Repi Full Gospel Belivers Local Church\n\n";
            printer.SubTitle = "\t \t    Expense List " + ExpenseDate.Value.ToString() + "\n" + expNo.Text+"\t                               " + totExpense.Text;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            //printer.RowHeight =  ;
            printer.PageNumberInHeader = false;
            printer.RowHeight= DGVPrinter.RowHeightSetting.CellHeight ;

            printer.PrintHeader = true;
            

            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Far;
            printer.Footer = "CIMS. by Anquar Technologies";
            printer.FooterSpacing = 15;
            printer.PrintPreviewDataGridView( expenseDGV);
            

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            Bitmap bm = new Bitmap(headerPicBox.Width, headerPicBox.Height);
            headerPicBox.DrawToBitmap(bm, new Rectangle(0, 0, headerPicBox.Width, headerPicBox.Height));
            e.Graphics.DrawImage(bm, 50, 25);




            e.Graphics.DrawString("Receipt Attachment", new Font("Times New Roman", 27, FontStyle.Underline), Brushes.Black, new PointF(300, headerPicBox.Height + 70));





            int x = 70 + headerPicBox.Height + 70;

           e.Graphics.DrawString("Expense No: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100 , x));

           e.Graphics.DrawString( expense_idTextBox.Text + "\n", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(260, x));





            int x2 = x + 60;
            e.Graphics.DrawString("Expense Reason: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, x2));

            e.Graphics.DrawString(expense_reasonComboBox.Text + "\n", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(260, x2));




            int x3 = x2 + 60;
            e.Graphics.DrawString("Expense Detail: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, x3));

            e.Graphics.DrawString(expense_detailTextBox.Text + "\n", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(260, x3));



            int x4 = x3 + 60;
            e.Graphics.DrawString("Expense Issue By: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, x4));

            e.Graphics.DrawString( expense_issueByComboBox.Text + "\n", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(260, x4));



            int x5 = x4 + 60;
            e.Graphics.DrawString("Expense Issue To: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, x5));

            e.Graphics.DrawString(expense_issueToTextBox.Text + "\n", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(260, x5));






            int x6 = x5 + 60;
            e.Graphics.DrawString("Expense Issued Value: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, x6));

            e.Graphics.DrawString(expense_valueNumericUpDown.Value + "\n", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(260, x6));






            int x7 = x6 + 60;
            e.Graphics.DrawString("Expense Issue Date: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, x7));

            e.Graphics.DrawString(expense_dateDateTimePicker.Value + "\n", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(260, x7));




            int x8 = x7 + 60;
            e.Graphics.DrawString("Expense Remark: ", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, x8));

            e.Graphics.DrawString(expense_remarkTextBox.Text + "\n", new Font("Times New Roman", 14, FontStyle.Underline), Brushes.Black, new PointF(260, x8));








        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }
    }
}
