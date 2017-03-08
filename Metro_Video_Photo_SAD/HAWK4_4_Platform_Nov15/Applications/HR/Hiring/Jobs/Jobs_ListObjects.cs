using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.Hiring.Jobs
{
    public partial class Jobs_ListObjects : Utilities.Documents.ListObjects
    {
        private IdentityObject identityObject;
        private string p;
        public Jobs_ListObjects()
        {
            InitializeComponent();
        }
        public Jobs_ListObjects(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            loadTable();
        }
        public Jobs_ListObjects(IdentityObject identityObject, string p)
        {
            // TODO: Complete member initialization
            this.identityObject = identityObject;
            this.p = p;
        }

        private void button_Display_Click_1(object sender, EventArgs e)
        {
            DataTable dTable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
            dataGridView1.DataSource = dTable;
        }
        protected override void dataGridView1_CellContentClick(object sender,
    DataGridViewCellEventArgs e)
        {
            string docNumStr = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string docTypeStr = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            new Jobs_DisplaySelectedObject(base.ident, textBox_TableName.Text, docTypeStr,
                docNumStr).Show();
        }
        private void loadTable()
        {
            comboBox_TableName.Items.Clear();
            comboBox_TableName.Items.Add("JobDescription");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new AddNewJob(ident, getJobDocNum()).Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hiring.Jobs.JobReport
                         rept = new Hiring.Jobs.JobReport();
            CrystalReport_Viewer CR_Form = new CrystalReport_Viewer();

            CR_Form.crystalReportViewer1.ReportSource = rept;

            CR_Form.Show();
        }

        private void btnShowJobForm_Click(object sender, EventArgs e)
        {
            new NewJobDescription(ident, getNextDocNum()).Show();
        }
        private string getNextDocNum()
        {
            return (int.Parse(dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value.ToString()) + 1).ToString();
        }
    }
}
