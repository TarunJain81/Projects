using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.Hiring.Applications
{
    public partial class NewApplication : HAWK_Template_2
    {
        public NewApplication()
        {
            InitializeComponent();
        }
        public NewApplication(IdentityObject ident, string docNum)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            textBox_DocNum.Text = docNum;
        }
        List<string> dataStringsList = new List<string>();
        private void button_ValidateData_Click(object sender, EventArgs e)
        {
            List<string> datastrings = new List<string>();
            StringBuilder dataString1 = new StringBuilder();
            dataString1.Append(textBox_DocNum.Text + " , ");
            dataString1.Append(textBox_DocType.Text + " , ");
            dataString1.Append(textBox_JobID.Text + " , ");
            dataString1.Append(textBox_ApplicantID.Text + " , ");
            dataString1.Append(textBox_Experience.Text + " , ");
            dataString1.Append("0 , '");
            dataString1.Append(textBox_Education1.Text + "' , '");
            dataString1.Append(textBox_Education2.Text + "' , ");
            dataString1.Append("0 , ");
            dataString1.Append(textBox_ApplicationScore.Text + " , '");
            dataString1.Append(textBox_Comment.Text + "'");
            datastrings.Add(dataString1.ToString());
            dataStringsList.Add(dataString1.ToString());
            textBox_DataItems.Text = "INSERT INTO [Applications] VALUES (" + dataString1.ToString() + ")";
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

            GenDoc myDoc = new GenDoc(dataStringsList);
            int retcode = myDoc.SaveDocument(base.ident, "Applications", textBox_DocNum.Text, textBox_DocType.Text, dataStringsList);

            MessageBox.Show("Add new Applications successfully");
            this.Close();
        }
    }
}
