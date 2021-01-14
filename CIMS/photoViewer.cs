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
    public partial class phv : Form
    {
        public static string path = "";
        public phv()
        {
            InitializeComponent();
          
            
        }

        private void phv_Load(object sender, EventArgs e)
        {
            try
            {
               
                pBox1.Image = Image.FromFile(Shared.path);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
