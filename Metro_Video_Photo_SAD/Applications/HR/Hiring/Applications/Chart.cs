using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
//using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;


namespace Applications.Applications.HR.Hiring.Applications
{
    public partial class Chart : HAWK_Template_2
    {
        public Chart()
        {
            InitializeComponent();
        }
        public Chart(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                OleDbConnection c = Utilities.DataBaseUtility.GetConnectionObject();
                c.Open();
                OleDbCommand com = new OleDbCommand();
                com.Connection = c;
                com.CommandText = "Select * from Applications";
                OleDbDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    chart1.Series["Experience"].Points.AddXY(r["DocNum"].ToString(), r["Experience"].ToString());
                }
                c.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            

        }


    }
}
