using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CIMS
{
    class DBConnection
    {


        public static SqlConnection Connect()
        {


            SqlConnection con = null;
            string textFile = @"C:\Program Files (x86)\Ankuar Solutions\CIMS\CIMS_DB_Path.txt";
            if (File.Exists(textFile))
            {

                try
                {

                    string path = File.ReadAllText(textFile);
                    con = new SqlConnection(path);

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Errrrror:   "+ ex.Message.ToString());
                }
                

                return con;
            }
            else
            {
                MessageBox.Show("DBPath FIle Doesn't Exist!");
                return con;

            }
        }







    }



  

}
