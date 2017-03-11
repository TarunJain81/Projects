using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
namespace Applications.Applications.Payroll
{
    public partial class Crystal : HAWK_Template_2
    {
        public Crystal()
        {
            InitializeComponent();
            
        }

        private void btnTimesheet_Click(object sender, EventArgs e)
        {
            Applications.Payroll.Timesheet c = new Applications.Payroll.Timesheet();
         
            CrystalReport_Viewer cr = new CrystalReport_Viewer();
            cr.crystalReportViewer1.ReportSource = c;
          
            cr.Show();
        }

        private void btnGrossPay_Click(object sender, EventArgs e)
        {
            Applications.Payroll.GrossPay c = new Applications.Payroll.GrossPay();

           CrystalReport_Viewer cr = new CrystalReport_Viewer();
            cr.crystalReportViewer1.ReportSource = c;

            cr.Show();

        }

        private void btnNetPay_Click(object sender, EventArgs e)
        {

            Applications.Payroll.NetPay c = new Applications.Payroll.NetPay();

            CrystalReport_Viewer cr = new CrystalReport_Viewer();
            cr.crystalReportViewer1.ReportSource = c;

            cr.Show();
        }
    }
}
