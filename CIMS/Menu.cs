using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CIMS
{
    public partial class Menu : Form
    {
        public static string currentUser = "";
        public Menu()
        {
            InitializeComponent();
            currentUser = "";
            this.Text = "CIMS Menu                                                                                                                                       User: " + Login.currentUser;
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterMember r = new RegisterMember();
            r.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HomeTeamForm ht = new HomeTeamForm();
            ht.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Expense_Form ef = new Expense_Form();
            ef.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IncomeForm inc = new IncomeForm();
            inc.Show(); 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Department d = new Department();
            d.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Family_Form F = new Family_Form();
            F.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fin_report fr = new Fin_report();
            fr.Show();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemberReport mr = new MemberReport();
            mr.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            UserManagement um = new UserManagement();
            um.Show();

        }
    }
}
