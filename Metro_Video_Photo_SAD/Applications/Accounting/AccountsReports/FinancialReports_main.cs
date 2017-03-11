using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.Accounting.AccountsReports
{
    public partial class financialReports_main : Applications.Accounting.AccountsReports.AccountsReport_Template
    {
        public financialReports_main()
        {
            InitializeComponent();
        }
        public financialReports_main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void balanceSheetcrys_Click(object sender, EventArgs e)
        {
            AccountsReports.CrystalBalanceSheetReport rept = new AccountsReports.CrystalBalanceSheetReport();
            CrystalReport_Viewer CR_Form = new CrystalReport_Viewer();
            CR_Form.crystalReportViewer1.ReportSource = rept;
            CR_Form.Show();
        }

        private void crysIncomeRpt_Click(object sender, EventArgs e)
        {
            AccountsReports.CrysIncomeStatement rept = new AccountsReports.CrysIncomeStatement();
            CrystalReport_Viewer CR_Form = new CrystalReport_Viewer();
            CR_Form.crystalReportViewer1.ReportSource = rept;
            CR_Form.Show();
        }

        private void crysTrialBalrpt_Click(object sender, EventArgs e)
        {
            AccountsReports.CrystalTrialBalanceReport2 rept = new AccountsReports.CrystalTrialBalanceReport2();
            CrystalReport_Viewer CR_Form = new CrystalReport_Viewer();
            CR_Form.crystalReportViewer1.ReportSource = rept;
            CR_Form.Show();
        }

        private void crysInternalrpt_Click(object sender, EventArgs e)
        {
            AccountsReports.CrysInternalReport2 rept = new AccountsReports.CrysInternalReport2();
            CrystalReport_Viewer CR_Form = new CrystalReport_Viewer();
            CR_Form.crystalReportViewer1.ReportSource = rept;
            CR_Form.Show();
        }

        private void testReport_Click(object sender, EventArgs e)
        {
            AccountsReports.test_CrysIncomeStatement rept = new AccountsReports.test_CrysIncomeStatement();
            CrystalReport_Viewer CR_Form = new CrystalReport_Viewer();
            CR_Form.crystalReportViewer1.ReportSource = rept;
            CR_Form.Show();
        }
    }
}
