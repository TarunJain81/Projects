using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

//11-11-2016 patty: this page is for HR admin to review the benefits request from employees
namespace Applications.Applications.HR.HrBenefit.HRAdmin
{
    public partial class HRAdmin_Manage_Request : HAWK_Template_2
    {
        protected DataTable _documentValues;
        public HRAdmin_Manage_Request()
        {
            InitializeComponent();
        }
        public HRAdmin_Manage_Request(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }


        //label1.Text = "select e1.DocNum,e1.EmpID,e2.reqID from EmployeeBenefits as e1 left outer join EmployeeBenefits_Details as e2 on e1.DocNum = e2.DocNum" ;

            //display all request
        private void button_show_req_Click(object sender, EventArgs e)
        {

            String query = "select e1.DocNum,e1.DocType,e2.docRef,e1.EmpID,e2.reqID, e2.reqStatus from EmployeeBenefits as e1 left outer join EmployeeBenefits_Details as e2 "
                + "on e1.DocNum = e2.DocNum where e2.reqstatus = 1";
            try
            {
                string cmdStr2 = String.Format(query);
                _documentValues = Utilities.DataBaseUtility.GetTable(cmdStr2);
                dataGridView1.DataSource = _documentValues;



            }
            catch (Exception ex)
            {
                MessageBox.Show("  error in reading GenDocs " + ex.Message);
            }
        }

        // click record can choose either approve or reject the particular request
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string docNumStr = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string docTypeStr = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string docRefStr = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string empIdStr = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string reqIdStr = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            string reqStatusStr = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            DialogResult diaRes = MessageBox.Show("Employee ID = " + empIdStr + ", Request ID = " + reqIdStr 
                + " \n Would you like to approve this request?", "Manage Request", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (diaRes == DialogResult.Yes) //approve request
            {
                try
                {
                    String percentGive = "";
                    percentGive = Interaction.InputBox("How many percent you would like to give? ");

                    //update EmployeeBenefits_Details
                    String uEmpBenD = "update EmployeeBenefits_Details set reqStatus = 2, approverEmpID = " + label_UserID.Text +
                        ", approvedPercent = " + percentGive + ", Comment = 'Benefit " + docRefStr + " with the approved request status'"
                        + " where DocNum = " + docNumStr + " and reqID = " + reqIdStr;                    
                    DataTable dTable = Utilities.DataBaseUtility.GetTable(uEmpBenD);

                    //update EmployeeBenefits
                    String uEmpBen = "update EmployeeBenefits set approvedCount = approvedCount + 1, totalBenPercent = totalBenPercent + " + percentGive +
                        " where DocNum = " + docNumStr + " and EmpID = " + empIdStr;                  
                    DataTable dTable2 = Utilities.DataBaseUtility.GetTable(uEmpBen);

                    //update Benefits, for Benefit Type 1 or 2
                    String uBen = "update Benefits set benefitCount = benefitCount + 1, comment = benefitCount + 1 & 'employees are using mandatory benefit " + docRefStr +
                     "' where DocNum = " + docRefStr + " and benefitType = 2";
                    String uBen2 = "update Benefits set benefitCount = benefitCount + 1, comment = benefitCount + 1 & 'employees are using optional benefit " + docRefStr +
                     "' where DocNum = " + docRefStr + " and benefitType = 1";                           
                    DataTable dTable3 = Utilities.DataBaseUtility.GetTable(uBen);  //for Benefit type 2
                    DataTable dTable4 = Utilities.DataBaseUtility.GetTable(uBen2); //for Benefit type 1

                    MessageBox.Show("The request from empID " + empIdStr + " has been approved! \n Request ID = " + reqIdStr);
                    return;

                }
                catch(Exception ex)
                {
                    MessageBox.Show("  error in reading GenDocs " + ex.Message);
                }
                



            }
            else if (diaRes == DialogResult.No)  //reject request
            {

                try
                {
                   

                    String dEmpBenD = "delete from EmployeeBenefits_Details  where DocNum = " + docNumStr + " and reqID = " + reqIdStr + " and reqStatus = 1";

                    DataTable dTable = Utilities.DataBaseUtility.GetTable(dEmpBenD);

                    String uEmpBen = "update EmployeeBenefits set benCount = benCount - 1 where DocNum = " + docNumStr + " and EmpID = " + empIdStr;

                    DataTable dTable2 = Utilities.DataBaseUtility.GetTable(uEmpBen);

                    MessageBox.Show("The request from empID " + empIdStr + " has been rejected! \n Request ID = " + reqIdStr);
                    return;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("  error in reading GenDocs " + ex.Message);
                }


            }




        }
    }
}
