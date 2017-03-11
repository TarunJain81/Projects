using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.Hiring.Jobs
{
    public partial class AddNewJob : HAWK_Template_2
    {
        public AddNewJob()
        {
            InitializeComponent();
        }
        public AddNewJob(IdentityObject ident, string docNum)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            txtDocNum.Text = docNum;

        }
        public AddNewJob(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        
        List<string> dataStringsList = new List<string>();
        private void button_Validate_Click(object sender, EventArgs e)
        {
            StringBuilder dataString1 = new StringBuilder();

            dataString1.Append(txtDocNum.Text.Trim() + ", ");   // entity number
            dataString1.Append(txtDocType.Text + ", '");
            dataString1.Append(textBox2.Text + "' , '");    // first name
            dataString1.Append(textBox3.Text + "' , '");
            dataString1.Append(textBox4.Text + "' , '");
            dataString1.Append(textBox6.Text + "' , '");
            dataString1.Append(textBox8.Text + "' , '");
            dataString1.Append(textBox_Comment.Text + "'");
            dataStringsList.Add(dataString1.ToString());
            textBox_DataItems.Text = "INSERT INTO [JobDescription] VALUES (" + dataString1.ToString() + ")";
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("are you sure that you want to save ?", "Verify Operation",
                              MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                MessageBox.Show(" Operation Cancelled by user ");
                return;
            }
            string cmdString = String.Format("insert into {0} Values ({1})", "JobDescription", dataStringsList[0]);
            string retMessage = Utilities.DataBaseUtility.Execute(cmdString, ident);
            DataTable dTable = Utilities.DataBaseUtility.GetTable(cmdString);
            MessageBox.Show("Insert new Job successfully");
            this.Close();
        }

    }
}
