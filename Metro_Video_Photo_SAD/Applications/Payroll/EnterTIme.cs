using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applications.Applications.Payroll
{
    public partial class EnterTIme :HAWK_Template_2
    {
        int EMP_ID = 104;
        string[] y;
        public EnterTIme()
        {
          //  EMP_ID = empid;
            InitializeComponent();
        }
        public void RetrieveDetails(int EMP_ID)
        {
            string res = "select * from Timesheets where Emp_ID=" + EMP_ID+" and week_id=(select max(week_id) from timesheets where Emp_ID="+EMP_ID+")";
            List<string> s = Utilities.DataBaseUtility.GetList(res,',');
            string[] x = s[0].Split(',');
            y = s[1].Split(',');
           // label7.Text = y[0];
            label8.Text = y[2];
            y[6]=label9.Text = DateTime.Parse(y[6].Remove(y[6].Length - 14).Trim()).AddDays(7).ToString();
           y[7]= label10.Text = DateTime.Parse(y[7].Remove(y[7].Length - 14).Trim()).AddDays(7).ToString();
           y[4]= label11.Text = (Convert.ToInt32(y[4])+1).ToString();
            label12.Text = y[3];

            dataGridView1.ColumnCount = 2;
            dataGridView1.ReadOnly = false;
            dataGridView1.Columns[0].Name = "WeekDay";
            dataGridView1.Columns[1].Name = "Num of hours";

            string[] row = new string[] { "Monday", "0" };
            dataGridView1.Rows.Add(row);
            row = new string[] { "Tuesday", "0" };
            dataGridView1.Rows.Add(row);

            row = new string[] { "Wednesday", "0" };
            dataGridView1.Rows.Add(row);

            row = new string[] { "Thursday", "0" };
            dataGridView1.Rows.Add(row);

            row = new string[] { "Friday", "0" };
            dataGridView1.Rows.Add(row);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string res = "select * from Timesheets where Emp_ID=" + EMP_ID + " and week_id=(select max(week_id) from timesheets where Emp_ID=" + EMP_ID + ")";
            List<string> s = Utilities.DataBaseUtility.GetList(res, ',');
            string[] x = s[0].Split(',');
            y = s[1].Split(',');
            //label7.Text = y[0];
            //label8.Text = y[2];
            List<Int32> hourslist = new List<int>(); 
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                hourslist.Add(Convert.ToInt32(row.Cells[1].Value));
            }



            y[6] = label9.Text = System.DateTime.Parse(y[6].Remove(y[6].Length - 14).Trim()).AddDays(7).ToString();
            y[7] = label10.Text = System.DateTime.Parse(y[7].Remove(y[7].Length - 14).Trim()).AddDays(7).ToString();
            y[4] = label11.Text = (Convert.ToInt32(y[4]) + 1).ToString();
            //label12.Text = y[3];
            List<String> hrs = new List<string>();
            var value = new IdentityObject();
            value.ActionLevel = 7;
            int totalHours = 0;

            int docnum = 412;

            string docNumLatest = "select max(docnum) from Timesheets";
            List<string> doc = Utilities.DataBaseUtility.GetList(docNumLatest, ',');

            String[] docs = doc[1].Split(',');

            docnum = Convert.ToInt32(docs[0]);

            docnum = docnum+1;

            for (int i = 0; i < hourslist.Count; i++)
            {
                totalHours = totalHours + hourslist[i];
                string detailsQuery = "INSERT INTO timesheets_details (docnum, doctype, emp_id, day_of_week,hours_worked, numvalue1, numvalue2, comments )"+
                    "Values (" + docnum + ", 41, " + label8.Text + "," + (i + 1) + ", " + hourslist[i] + ", 0, 0, 'Timesheet details for week day " + (i + 1) + "')";

                string msg = Utilities.DataBaseUtility.Execute(detailsQuery, value);
            }

            
           // string cmdString = "insert into Timesheets (DocNum,DocType, EMp_id, Max_Hours, Week_Id, Total_Hours_Worked, Start_date, End_date, Numvalue1,Numvalue2 ,Comments ) Values "
             //   + "("+label7.Text+", 41, "+ label8.Text+", 40, "+label11.Text+", "+textBox1.Text+" ,'"+ y[6]+"' ,'"+y[7]+"', 0, 0 , 'Timesheet hours for week "+ label11.Text+"')";


            string cmdString = "insert into Timesheets (DocNum,DocType, EMp_id, Max_Hours, Week_Id, Total_Hours_Worked, Start_date, End_date, Numvalue1,Numvalue2 ,Comments ) Values "
                + "(" + docnum + ", 41, " + label8.Text + ", 40, " + label11.Text + ", " + totalHours + " ,'" + y[6] + "' ,'" + y[7] + "', 0, 0 , 'Timesheet hours for week " + label11.Text + "')";


            //string cmdString = String.Format("insert into {0} Values ({1})", _tableName.Trim(), myData[0]);
            //string cmdString = String.Format("insert into {0} Values ({1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11})",Convert.ToString("Timesheets"), Convert.ToInt32(label7.Text), 41, Convert.ToInt32(label8.Text), 40, Convert.ToInt32(label11.Text), Convert.ToInt32(textBox1.Text),Convert.ToString("2/7/2016"), Convert.ToString("2/7/2016"),0.0, 0.0, Convert.ToString("aaa"));    //where DocNum = {1} and DocType = {2}", _tableName, inDocNum, inDocType);
            string retMessage = Utilities.DataBaseUtility.Execute(cmdString, value);
           // dataGridView1.DataSource = y;

            CalculateGrossPay(label11.Text, totalHours, EMP_ID, y[6], y[7]);



        }


        private void CalculateGrossPay(string weeknum, int noOfHours, int EMP_ID, string start_date, string end_date)
        {
            var empId = EMP_ID;
           
            /*var tsquery = "SELECT * FROM timesheets where docnum=409";
            var tsvalue = Utilities.DataBaseUtility.GetList(tsquery);
            var noOfHours = tsvalue[6];*/

            var gpquery = "SELECT * FROM GrossPay where Emp_ID =" + empId + "";
            var gpvalue = Utilities.DataBaseUtility.GetList(gpquery);
            String[] hp = gpvalue[1].Split(',');
            String hourlypay = hp[3]; 

            String[] otp = gpvalue[1].Split(',');
            String overtimepay = otp[4];
            var grosspay = 0;
            var overtimehours = 0;
          //  var noOfHours = 4;
            var totalRegular = 0;
            var totalovertime = 0;

            if (noOfHours <= 40)
            {
                totalRegular = noOfHours * Convert.ToInt32(hourlypay);
                grosspay = totalRegular;
            }
            else if (noOfHours > 40)
            {
                overtimehours = noOfHours - 40;
                totalRegular = 40 * Convert.ToInt32(hourlypay);
                totalovertime = overtimehours * Convert.ToInt32(overtimepay);
                grosspay = totalRegular+totalovertime;
            }
            var docNum = 0;
            docNum = Utilities.DataBaseUtility.GetLastNumber("GrossPay", 0, 0, 999);
            docNum = Convert.ToInt32(docNum);
            docNum++;

            //insert gross pay
            var insert_grosspay = "INSERT INTO GrossPay (DocNum, DocType, Emp_ID, HourlypayRate, Overtime_HourlyRate, TotalRegularpay, PayStartDate, "+
            " PayEndDate, TotalOvertimepay, GrossPay, Comments)"+
                "VALUES (" + docNum + ", 42, " + empId + ", " + hourlypay + ", " + overtimepay
                + ", " + totalRegular + ", '" + start_date + "', '" + end_date + "', " + totalovertime + ", " + grosspay + "," +
            " 'GrossPay of  Emp "+empId+" is Regular Pay + OverTime Pay for "+weeknum+" week')";
            Utilities.DataBaseUtility.Execute(insert_grosspay, ident);
            calculateNetPay(grosspay, EMP_ID, start_date, end_date);
        }

        private void calculateNetPay(int grossPay, int empID, string start_date, string end_date)
        {
            var empId = empID;
            var docNum = 0;
            int NetPay = 0;

            docNum = Utilities.DataBaseUtility.GetLastNumber("NetPay", 0, 0, 999);
            docNum = Convert.ToInt32(docNum);
            docNum++;
            

            var bfquery = "SELECT * FROM EmployeeBenefits where EmpID = " + empId + "";
            var bfvalue = Utilities.DataBaseUtility.GetList(bfquery);
            String[] benf = bfvalue[1].Split(',');
            String benefitPercent = benf[5];
            int bf_amt = Convert.ToInt32(Convert.ToInt32(benefitPercent)*grossPay);
            bf_amt = bf_amt/100;

            var npquery = "SELECT * FROM  NetPay where Emp_ID = " + empId + "";
            var npvalue = Utilities.DataBaseUtility.GetList(npquery);
            String[] deduct = npvalue[1].Split(',');
            String ded_amt = deduct[4];
           
            NetPay = grossPay - (Convert.ToInt32(ded_amt) + (Convert.ToInt32(bf_amt)));
            
            //insert net pay
            var insert_netpay = "INSERT INTO NetPay (DocNum, DocType, Emp_ID, Benefits_Amt, Deductions_Amt, Gross_Amt, PayStartDate, PayEndDate,"+
            "NetPay_Amt, NumValue1, Comments)" + 
            "values ("+docNum+", 43, "+empId+", "+bf_amt+", "+ded_amt+", "
                + grossPay + ", '" + start_date + "', '" + end_date + "', " + NetPay + ", 0,"
            +"'NetPay for Emp"+empId+"  is GrossPay - (Deductions_Amt + Benfits_Amt)')";
            Utilities.DataBaseUtility.Execute(insert_netpay, ident);
            successmsg.Visible = true;
    }

        private void label_SubName_Click(object sender, EventArgs e)
        {

        }
    }
}
