using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using iTextSharp;
using System.Collections.Generic;
using System.IO;
using iTextSharp.text;
using System.Windows.Forms.DataVisualization.Charting;

namespace Applications.Applications.Payroll
{



    public partial class Charts : Applications.Payroll.Chart_Template
    {

        static int emp_Id;
        List<string> reportsList = new List<string>(){
                                                       "1.Hours Worked by week",                                            
                                                       "2.NetPay-GrossPay Comparision",
                                                       "3.Regular vs Overtime Pay",
                                                       "4.Regular vs Overtime workhours"
                                                      };
        public Charts(IdentityObject ident, int emp_id) 
        {
            emp_Id = emp_id;
            InitializeComponent();
           // LoadReports();
            List<string> queryList = Utilities.DataBaseUtility.GetList("select distinct start_date,end_date from Timesheets");

            var roleQuery = "SELECT * FROM employees where docnum="+emp_id;

            var rolevalue = Utilities.DataBaseUtility.GetList(roleQuery);
            String[] rolesValue = rolevalue[1].Split(',');

            String role = rolesValue[14];
            List<Int32> employeeList = new List<Int32>();

            if (role.Equals("Supervisor  "))
            {
                //employeesAdmin.Visible = true;

                for (int i = 101; i < 111; i++)
                {
                    employeeList.Add(i);  
                }


                //employeesAdmin.DataSource = employeeList;

              //  employeesAdmin.Visible = false;
            }
            

        
            cboChartType.Visible = true;
        
            
            //listBox1.DataBindings();
        }

        public override void LoadReports()
        {
            foreach (var value in reportsList)
            {
                cbo_Reports.Items.Add(value.ToString());
            }
        }

        public override void cbx_Reports_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboChartType.Visible = true;
            chart1.Titles.Clear();
            List<string> queryList = null;
            string chartTitle = cbo_Reports.SelectedItem.ToString();
            string legendX = null;
            string legendY = null;
            string legendY1 = null;
            string legendY2 = null;
            string labelFormat = null;
            string where = "where emp_id=" + emp_Id;
            switch (cbo_Reports.SelectedItem.ToString().Substring(0, 1))
            {
                case "1":
                    queryList = Utilities.DataBaseUtility.GetList("select start_date,  max_hours,total_hours_worked from timesheets " + where);
                    legendY1 = "MaxHours";
                    legendY2 = "Hours Worked";
                    legendX = "Start Date";
                    labelFormat = "D";
                    legendY = "Num of Hours";
                    break;

                case "2":
                    queryList = Utilities.DataBaseUtility.GetList("select paystartdate,  netpay_amt, gross_amt from netpay " + where);
                    legendY1 = "NetPay";
                    legendY2 = "Gross Pay";
                    legendX = "Start Date";
                    labelFormat = "C";
                    legendY = "Pay";
                    break;

                case "3":
                    queryList = Utilities.DataBaseUtility.GetList("select paystartdate, totalregularpay, totalovertimepay from grosspay " + where);
                    legendY1 = "Regular Pay";
                    legendY2 = "Overtime Pay";
                    legendX = "Start Date";
                    labelFormat = "C";
                    legendY = "Pay";
                    break;

                case "4":
                    queryList = Utilities.DataBaseUtility.GetList("select paystartdate, ([totalregularpay]/[hourlypayrate]), ([totalovertimepay]/[overtime_hourlyrate]) from grosspay " + where);
                    legendY1 = "Regular Hours";
                    legendY2 = "Overtime Hours";
                    legendX = "Start Date";
                    labelFormat = "D";
                    legendY = "Num of Hours";
                    break;

            }

            GetChartData(queryList, chartTitle, legendX, legendY, legendY1, legendY2, labelFormat);

        }


   
       
        // public override void  GetChartData(List<string> queryList, string chartTitle, string legendX, string legendY, string labelFormat)
        //{
        //    this.chart1.Series[0].Points.Clear();
        //    this.chart1.Series[1].Points.Clear();
        //    this.chart1.Series[0].Name = legendY;
        //    this.chart1.Series[1].Name = legendY;
        //    chart1.Titles.Add(chartTitle);
        //    chart1.ChartAreas[0].AxisY.LabelStyle.Format = labelFormat;
        //    chart1.ChartAreas[0].Axes[0].Title = legendX;
        //    chart1.ChartAreas[0].Axes[1].Title = legendY;

        //    // List<string> queryList = Utilities.DataBaseUtility.GetList("select * from Service_Order WHERE numvalue1 <> 0");
        //    //List<string> queryList = Utilities.DataBaseUtility.GetList("select e.DocType, e.Current, a.Current from ProjectsActualByMonth a, ProjectsEstByMonth e WHERE e.DocNum = a.DocNum AND e.DocType = a.DocType");
        //    //List<string> queryList = Utilities.DataBaseUtility.GetList("SELECT [e.DocType], [e.Current], [a.Current] FROM [ProjectsEstByMonth] AS [e] INNER JOIN [ProjectsActualByMonth] AS [a] ON e.[DocType] = a.[DocType] AND e.[DocNum] = a.[DocNum]");
        //    queryList.RemoveAt(0);
        //    queryList.RemoveAt(0);

        //    foreach (var value in queryList)
        //    {
        //        string[] fields = value.Split(',');
        //        this.chart1.Series[0].Points.AddXY(fields[0].ToString(), fields[1].ToString());
        //        this.chart1.Series[1].Points.AddXY(fields[0].ToString(), fields[2].ToString());
        //    }
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
