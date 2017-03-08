using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applications.Applications.Payroll
{
    public partial class UpdateTime : HAWK_Template_2
    {
        public UpdateTime()
        {
            InitializeComponent();
        }

        public void UpdateDetails(int EMP_ID,int week)
        {
            label1.Text = EMP_ID.ToString();
            label2.Text = week.ToString();

            string res = "select * from Timesheets where Emp_ID=" + EMP_ID + " and Week_Id=" + week;

            List<string> s = Utilities.DataBaseUtility.GetList(res, ',');

           string y = s[1].Split(',')[0];

            string res1 = "select * from TimeSheets_Details where Emp_ID=" + EMP_ID + " and DocNum=" + y;

            List<string> s1 = Utilities.DataBaseUtility.GetList(res1, ',');


            dataGridView1.ColumnCount = 2;
            dataGridView1.ReadOnly = false;
            dataGridView1.Columns[0].Name = "WeekDay";
            dataGridView1.Columns[1].Name = "Num of hours";

            string[] row = new string[] { "Monday", s1[1].Split(',')[4] };
            dataGridView1.Rows.Add(row);
            row = new string[] { "Tuesday", s1[2].Split(',')[4] };
            dataGridView1.Rows.Add(row);

            row = new string[] { "Wednesday", s1[3].Split(',')[4] };
            dataGridView1.Rows.Add(row);

            row = new string[] { "Thursday", s1[4].Split(',')[4] };
            dataGridView1.Rows.Add(row);

            row = new string[] { "Friday", s1[5].Split(',')[4] };
            dataGridView1.Rows.Add(row);

        }

       
    }
}
