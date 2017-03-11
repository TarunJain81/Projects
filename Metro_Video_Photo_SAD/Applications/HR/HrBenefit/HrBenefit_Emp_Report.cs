using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.HrBenefit
{
    public partial class HrBenefit_Emp_Report : CrystalReport_Viewer
    {
        String emp_num;
        public HrBenefit_Emp_Report()
        {
            InitializeComponent();
        }
        public HrBenefit_Emp_Report(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);

        }

        public HrBenefit_Emp_Report(IdentityObject ident, String empDocNum)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            emp_num = empDocNum;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            HR.HrBenefit.CrystalReportHRB rept = new HR.HrBenefit.CrystalReportHRB();
            HrBenefit_Emp_Report CR_Form = new HrBenefit_Emp_Report();
            rept.SetParameterValue("DocNumPara", emp_num);
            rept.SetParameterValue("StatusPara", "2");
            CR_Form.crystalReportViewer1.ReportSource = rept;
            CR_Form.Show();




        }

    
    }
}
