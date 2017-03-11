using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Applications.Applications.Payroll
{
    public partial class TimeSheet : Utilities.Documents.ListObjects
    {
        public TimeSheet(int emp_id)
        {
            textBox_TableName.Text = "Timesheets";
            textBox_CMD.Text = "select * from timesheets where emp_id=" + emp_id;
            InitializeComponent();
            //button_Reset.Visible = false;
        }


        protected override void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string docNumStr = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            string docTypeStr = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            new Applications.Payroll.DisplaySelectedObject(base.ident, textBox_TableName.Text, docTypeStr, docNumStr).Show();

            //this.pictureBox2.Visible = false;
            // new DisplaySelectedObject(base.ident, textBox_TableName.Text, docTypeStr, docNumStr).Show();
        }

        private void comboBox_DocType_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button_Display_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var s = new Payroll.EnterTIme();
            s.RetrieveDetails(104);
            s.Show();
        }

        private void button_Reset_Click_1(object sender, EventArgs e)
        {
            var s = new Payroll.UpdateTime();
            int lastRow = dataGridView1.RowCount - 2;
            int id = Convert.ToInt32(dataGridView1[2,lastRow].Value);
            int weekId = Convert.ToInt32(dataGridView1[4, lastRow].Value);
            s.UpdateDetails(id,weekId);
            s.Show();
        }
    }
}
