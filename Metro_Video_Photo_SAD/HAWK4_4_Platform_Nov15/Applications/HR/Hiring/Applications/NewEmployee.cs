using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.Hiring.Applications
{
    public partial class NewEmployee : HAWK_Template_2
    {
        public NewEmployee()
        {
            InitializeComponent();
        }
        public NewEmployee(IdentityObject ident, string appID)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            //txtDocNum.Text = docNum;
            txtAppID.Text = appID;
        }
        List<string> dataStringsList = new List<string>();
        //int nextEmpID;

         DataTable _applicantsValues;

        List<string> id;
        
        private void button_Validate_Click_1(object sender, EventArgs e)
        {
            id = Utilities.DataBaseUtility.GetList("select DocNum from Employees");
            string currentID = id[id.Count - 1];
            int nextEmpID = Convert.ToInt32(currentID) + 1;
            _applicantsValues = Utilities.DataBaseUtility.GetTable("select * from Applicant where DocNum = " + txtAppID.Text);
            string fname = _applicantsValues.Rows[0][2].ToString();
            string lname = _applicantsValues.Rows[0][3].ToString();
            string add = _applicantsValues.Rows[0][4].ToString();
            string add2 = _applicantsValues.Rows[0][5].ToString();
            string city = _applicantsValues.Rows[0][6].ToString();
            string state = _applicantsValues.Rows[0][7].ToString();
            string zip = _applicantsValues.Rows[0][8].ToString();
            string country = _applicantsValues.Rows[0][9].ToString();
            string phone = _applicantsValues.Rows[0][10].ToString();
            string phone2 = _applicantsValues.Rows[0][11].ToString();
            string email = _applicantsValues.Rows[0][12].ToString();
            string dep_id = null;
            string role = null;
            string ad_level = null;
            string cmt = null;
            //String com = "'"+nextEmpID.ToString() +"', '3', '" + fname + "','" + lname + "','" + add + "','" + add2 + "','" + city + "','" + state + "','" +
            //    zip + "','" + country + "','" + phone + "','" + phone2 + "','" + email + "','" + dep_id + "','" + role + "','" +
            //    ad_level + "','" + cmt + "'";

            //dataStringsList.Add(com);
            txtDocNum.Text = nextEmpID.ToString();
            txtDocType.Text = "3";
            textBox2.Text = fname;
            textBox3.Text = lname;
            textBox4.Text = add;
            textBox5.Text = add2;
            textBox6.Text = city;
            textBox7.Text = state;
            textBox8.Text = zip;
            textBox9.Text = country;
            textBox10.Text = phone;
            textBox11.Text = phone2;
            textBox12.Text = email;
            textBox_13.Text = dep_id;
            textBox14.Text = role;
            textBox15.Text = ad_level;
            textBox_Comment.Text = cmt;

            StringBuilder dataString1 = new StringBuilder();
            //dataString1.Append( "'");
            dataString1.Append(txtDocNum.Text + " , ");   // entity number
            dataString1.Append(txtDocType.Text + " , '");
            dataString1.Append(textBox2.Text + "' , '");    // first name
            dataString1.Append(textBox3.Text + "' , '");
            dataString1.Append(textBox4.Text + "' , '");
            dataString1.Append(textBox5.Text + "' , '");
            dataString1.Append(textBox6.Text + "' , '");
            dataString1.Append(textBox7.Text + "' , '");
            dataString1.Append(textBox8.Text + "' , '");
            dataString1.Append(textBox9.Text + "' , '");
            dataString1.Append(textBox10.Text + "' , '");
            dataString1.Append(textBox11.Text + "' , '");
            dataString1.Append(textBox12.Text + "' , '");
            dataString1.Append(textBox_13.Text + "' , '");
            dataString1.Append(textBox14.Text + "' , '");
            dataString1.Append(textBox15.Text + "' , '");
            dataString1.Append(textBox_Comment.Text + "'");
            dataStringsList.Add(dataString1.ToString());

            textBox_DataItems.Text = "INSERT INTO [Employees] VALUES (" + dataString1.ToString() + ")";
        }

        private void button_Save_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("are you sure that you want to save ?", "Verify Operation",
                               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                MessageBox.Show(" Operation Cancelled by user ");
                return;
            }
            string cmdString = String.Format("insert into {0} Values ({1})", "Employees", dataStringsList[0]);
            string retMessage = Utilities.DataBaseUtility.Execute(cmdString, ident);

            MessageBox.Show("Insert new Applicant successfully");
            this.Close();
        }
    }
}
