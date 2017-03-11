using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.HrBenefit
{
    //patty 11/05/2016 
    public partial class HrBenefit_Employee : HAWK_Template_2
    {

        String emp_num;
        String emp_doc_num;
        public HrBenefit_Employee()
        {
            InitializeComponent();
        }

        public HrBenefit_Employee(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);

            if (label_UserID.Text != "000")
            {
                emp_num = label_UserID.Text;


                List<string> _records = new List<string>();
                try
                {
                    //  _documentValues = Utilities.DataBaseUtility.GetTable(cmdStr);
                    _records = Utilities.DataBaseUtility.GetList("select docNum from EmployeeBenefits where EmpID = " + emp_num);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("  error in reading table : select docNum from EmployeeBenefits where EmpID = 101", ex.Message);
                    return;
                }

                _records.RemoveAt(0);

                string[] _documentValues = _records[0].Split(',');

                emp_doc_num = _documentValues[0].ToString();


            }


        }

        

        private void button_view_my_own_Click(object sender, EventArgs e)
        {
            Applications.HR.HrBenefit.HrBenefit_Emp_Report emp_rept = new Applications.HR.HrBenefit.HrBenefit_Emp_Report(base.ident, emp_doc_num);
            emp_rept.Show();
        }

        private void btn_view_my_benefits_Click(object sender, EventArgs e)
        {
            Applications.HR.HrBenefit.ListObjects List_Emp_Benefits = new Applications.HR.HrBenefit.ListObjects(base.ident, "EmployeeBenefits", "65", ident.UserID, "emp");
            //var uid = ident.UserID;
            //MessageBox.Show(uid);
            List_Emp_Benefits.Show();
        }

        
        private void btn_request_benefits_Click(object sender, EventArgs e)
        {
            //Applications.HR.HrBenefit.HrBenefit_Employee_Req_Ben emp_req_ben = new Applications.HR.HrBenefit.HrBenefit_Employee_Req_Ben(base.ident);
            //emp_req_ben.Show();

            Applications.HR.HrBenefit.ListObjects List_Benefits = new Applications.HR.HrBenefit.ListObjects(base.ident, "Benefits", "61", "emp");
            List_Benefits.Show();
        }
    }
}
