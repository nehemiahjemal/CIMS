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
    public partial class Fin_report : Form
    {
        SqlConnection con=null;
        public Fin_report()
        {
            InitializeComponent();
            con = DBConnection.Connect();
            con.Open();
            expenseReasonCombo.Enabled = false;
            incomeReasonCombo.Enabled = false;
        }



        public void LoadExpense()
        {
            if(expenseFilter.Checked)
            {


                string qry = "select Expense_id, Expense_reason, Expense_value, Expense_issueby, Expense_issueTo, Expense_detail , Expense_date, Expense_remark from expense where expense_date between '" + date1.Value + "' and '" + date2.Value + "' and expense_reason = '"+expenseReasonCombo.SelectedValue+"' ";
                SqlDataAdapter sda = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int value = 0;


                expenseDGV.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = expenseDGV.Rows.Add();



                    expenseDGV.Rows[n].Cells[0].Value = item[0].ToString();
                    expenseDGV.Rows[n].Cells[1].Value = item[1];
                    expenseDGV.Rows[n].Cells[2].Value = item[2];
                    expenseDGV.Rows[n].Cells[3].Value = item[3];
                    expenseDGV.Rows[n].Cells[4].Value = item[4];
                    expenseDGV.Rows[n].Cells[5].Value = item[5];
                    expenseDGV.Rows[n].Cells[6].Value = item[6];
                    expenseDGV.Rows[n].Cells[7].Value = item[7];

                    value = value + Convert.ToInt32(item[2]);




                }

                tot_expenseBox.Text = value.ToString();


            }
            else if (!expenseFilter.Checked)
            {


                string qry = "select Expense_id, Expense_reason, Expense_value, Expense_issueby, Expense_issueTo, Expense_detail , Expense_date, Expense_remark from expense where expense_date between '" + date1.Value + "' and '" + date2.Value + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int value = 0;

                expenseDGV.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = expenseDGV.Rows.Add();



                    expenseDGV.Rows[n].Cells[0].Value = item[0].ToString();
                    expenseDGV.Rows[n].Cells[1].Value = item[1];
                    expenseDGV.Rows[n].Cells[2].Value = item[2];
                    expenseDGV.Rows[n].Cells[3].Value = item[3];
                    expenseDGV.Rows[n].Cells[4].Value = item[4];
                    expenseDGV.Rows[n].Cells[5].Value = item[5];
                    expenseDGV.Rows[n].Cells[6].Value = item[6];
                    expenseDGV.Rows[n].Cells[7].Value = item[7];


                    value = value + Convert.ToInt32(item[2]);


                }

                tot_expenseBox.Text = value.ToString();


            }


            
          





        }


        public void LoadIncome()
        {

            if (incomeFilter.Checked)
            {


                string qry = "select income_id, income_reason, income_value, income_by, income_date, income_ofYear , income_ofMonth, income_receivedBy from income where income_date between '" + date1.Value + "' and '" + date2.Value + "' and income_reason = '" + incomeReasonCombo.SelectedValue + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int value = 0;


                incomeDGV.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = incomeDGV.Rows.Add();



                    incomeDGV.Rows[n].Cells[0].Value = item[0];
                    incomeDGV.Rows[n].Cells[1].Value = item[1];
                    incomeDGV.Rows[n].Cells[2].Value = item[2];
                    incomeDGV.Rows[n].Cells[3].Value = item[3];
                    incomeDGV.Rows[n].Cells[4].Value = item[4];
                    incomeDGV.Rows[n].Cells[5].Value = item[5];
                    incomeDGV.Rows[n].Cells[6].Value = item[6];
                    incomeDGV.Rows[n].Cells[7].Value = item[7];
                  
                 

                    value = value + Convert.ToInt32(item[2]);




                }

                tot_incomeBox.Text = value.ToString();


            }
            else if (!incomeFilter.Checked)
            {


                string qry = "select income_id, income_reason, income_value, income_by, income_date, income_ofYear , income_ofMonth, income_receivedBy from income where income_date between '" + date1.Value + "' and '" + date2.Value + "'  ";
                SqlDataAdapter sda = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int value = 0;


                incomeDGV.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = incomeDGV.Rows.Add();



                    incomeDGV.Rows[n].Cells[0].Value = item[0];
                    incomeDGV.Rows[n].Cells[1].Value = item[1];
                    incomeDGV.Rows[n].Cells[2].Value = item[2];
                    incomeDGV.Rows[n].Cells[3].Value = item[3];
                    incomeDGV.Rows[n].Cells[4].Value = item[4];
                    incomeDGV.Rows[n].Cells[5].Value = item[5];
                    incomeDGV.Rows[n].Cells[6].Value = item[6];
                    incomeDGV.Rows[n].Cells[7].Value = item[7];
              
                    

                    value = value + Convert.ToInt32(item[2]);




                }

                tot_incomeBox.Text = value.ToString();


            }









        }


        public void LoadTotal()
        {

        }



        public void LoadExpenseSummary()
        {

            string qry = "SELECT  Expense_reason,   sum(Expense_value) as value FROM Expense where expense_date between '" + date1.Value + "' and '" + date2.Value + "'  GROUP BY Expense_reason;";
            SqlDataAdapter sda = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            int value = 0;


            dgvExpense.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {


                int n = dgvExpense.Rows.Add();

                dgvExpense.Rows[n].Cells[0].Value = item[0];
                dgvExpense.Rows[n].Cells[1].Value = item[1];

                value = value + Convert.ToInt32(item[1]);





            }


            totExpField.Text = value.ToString();




        }

        public void loadIncomeSummary()
        {

            string qry = "SELECT  Income_reason,   sum(Income_value) as value FROM Income  where income_date between '" + date1.Value + "' and '" + date2.Value + "'  GROUP BY Income_reason;";
            SqlDataAdapter sda = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            int value = 0;


            dgvIncome.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {


                int n = dgvIncome.Rows.Add();

                dgvIncome.Rows[n].Cells[0].Value = item[0];
                dgvIncome.Rows[n].Cells[1].Value = item[1];

                value = value + Convert.ToInt32(item[1]);



            }

            totIncField.Text = value.ToString();



        }
        





        private void button1_Click(object sender, EventArgs e)
        {
            LoadExpense();
            LoadIncome();
            LoadExpenseSummary();
            loadIncomeSummary();



            totBalField.Text = "" + (Convert.ToInt32(totIncField.Text) - Convert.ToInt32( totExpField.Text));


            balance_box.Text = ""+ ( Convert.ToInt32(tot_incomeBox.Text) - Convert.ToInt32(tot_expenseBox.Text) );
        }

        private void Fin_report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'churchDBDataSet.IncomeSource' table. You can move, or remove it, as needed.
            this.incomeSourceTableAdapter.Fill(this.churchDBDataSet.IncomeSource);
            // TODO: This line of code loads data into the 'churchDBDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.churchDBDataSet.Member);
            // TODO: This line of code loads data into the 'churchDBDataSet.ExpenseReason' table. You can move, or remove it, as needed.
            this.expenseReasonTableAdapter.Fill(this.churchDBDataSet.ExpenseReason);

        }

        private void expenseDGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (expenseDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
            {
                e.Cancel = true;
            }
        }

        private void incomeDGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (incomeDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
            {
                e.Cancel = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void expenseFilter_CheckedChanged(object sender, EventArgs e)
        {
            if(expenseFilter.Checked)
            {
                expenseReasonCombo.Enabled = true;
                expenseReasonCombo.SelectedIndex = 0;
            }
            else
            {
                expenseReasonCombo.Enabled = false;
                expenseReasonCombo.SelectedIndex = 0;
            }
        }

        private void incomeFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (incomeFilter.Checked)
            {
                incomeReasonCombo.Enabled = true;
                incomeReasonCombo.SelectedIndex = 0;
            }
            else
            {
                incomeReasonCombo.Enabled = false;
                incomeReasonCombo.SelectedIndex = 0;
            }
        }

        private void dgvExpense_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {


            if (dgvExpense.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
            {
                e.Cancel = true;
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadExpense();
            LoadIncome();
            LoadExpenseSummary();
            loadIncomeSummary();



            totBalField.Text = "" + (Convert.ToInt32(totIncField.Text) - Convert.ToInt32(totExpField.Text));


            balance_box.Text = "" + (Convert.ToInt32(tot_incomeBox.Text) - Convert.ToInt32(tot_expenseBox.Text));
        }
    }
}
