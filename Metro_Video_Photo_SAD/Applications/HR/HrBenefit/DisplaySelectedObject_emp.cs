using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.HrBenefit
{
    public partial class DisplaySelectedObject_emp : Utilities.Documents.DisplaySelectedObject
    {
        public DisplaySelectedObject_emp()
        {
            InitializeComponent();
        }
        public DisplaySelectedObject_emp(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);

            //String userid = ident.UserID;
            //String inp = textBox_DocNum.Text;

            //string qty = "select ed.docRef from EmployeeBenefits_Details as ed, EmployeeBenefits as e where e.EmpID = '" + userid + "' and e.DocNum=ed.DocNum and ed.docRef = '" + inp + "' and ed.reqStatus = '2'";
            //int quant = Utilities.DataBaseUtility.Execute(ident, qty);
            //MessageBox.Show(quant.ToString());

            //if (quant != 1)
            //{
            //    //delete active
            //    //add inactive
            //    btn_add_benefit.Visible = false;
            //    btn_delete_benefit.Visible = true;
            //}
            //else
            //{
            //    //delete inactive
            //    //add active
            //    btn_add_benefit.Visible = true;
            //    btn_delete_benefit.Visible = false;
            //}

        }

        public DisplaySelectedObject_emp(IdentityObject ident, string tableName, string docType, string docNum)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            textBox_DocNum.Text = docNum;
            textBox_DocType.Text = docType;
            textBox_TableName.Text = tableName;

            button_ResetCommand_Click(this, null);
            String userid = ident.UserID;
            String inp = textBox_DocNum.Text;

            //string qty = "select ed.docRef from EmployeeBenefits_Details as ed, EmployeeBenefits as e where e.EmpID = '" + userid + "' and e.DocNum=ed.DocNum and ed.docRef = '" + inp + "' and ed.reqStatus = '2'";
            //string qty = "select * from EmployeeBenefits_Details";
            //String query = "select e1.DocNum,e1.DocType,e2.docRef,e1.EmpID,e2.reqID, e2.reqStatus from EmployeeBenefits as e1 left outer join EmployeeBenefits_Details as e2 "
            //    + "on e1.DocNum = e2.DocNum where e2.reqstatus = 1";

            //MessageBox.Show(inp);

            //String qty = "select ed.docRef from EmployeeBenefits_Details as ed left outer join EmployeeBenefits as e "
            //    + "on ed.DocNum = e.DocNum where ed.reqstatus = 2";

            String qty = "select ed.docRef from EmployeeBenefits_Details as ed,EmployeeBenefits as e, Benefits as b where ed.DocNum = e.DocNum and ed.docref=b.docnum and ed.reqstatus = 2 and b.docnum =" + inp + " and e.empid =" + userid;

            //+ inp;

            //and ed.DocNum = '" + inp + "'";

            //String qty = "select ed.docRef from EmployeeBenefits_Details where e2.reqstatus = + '" + 2 + "'";

            //String query = "select e1.DocNum,e1.DocType,e2.docRef,e1.EmpID,e2.reqID, e2.reqStatus from EmployeeBenefits as e1 left outer join EmployeeBenefits_Details as e2 "
            //    + "on e1.DocNum = e2.DocNum where e2.reqstatus = 1";

            //where e2.reqstatus = 2 and ed.docRef = 601"; 

            //'" + inp + "'";

            /*
            int quant = Utilities.DataBaseUtility.Execute(ident, qty);
            //MessageBox.Show(quant.ToString());

            if (quant == 0)
            {
                //delete active
                //add inactive
                btn_add_benefit.Visible = false;
                btn_delete_benefit.Visible = true;
            }
            else if (quant == 1)
            {
                //delete inactive
                //add active
                btn_add_benefit.Visible = true;
                btn_delete_benefit.Visible = false;
            }*/

        }

        //[Nidhi] Added for adding/updating benefit
        private void btn_add_benefit_Click(object sender, EventArgs e)
        {
            /*
            String userid = ident.UserID;

            //condition to checkif employee already has his record in employee benefits table

            string q = "select DocNum from EmployeeBenefits where EmpID = '"+userid+"'";
            int a = Utilities.DataBaseUtility.Execute(ident, q);
            //MessageBox.Show(a.ToString());

            if (a != 1)

            {
                
                //Updating Employee_Benefits table

                String update_query_1 = "update EmployeeBenefits set benCount = benCount+ " + 1 + " where EmpID = '" + userid + "'";
                DataTable dTable = Utilities.DataBaseUtility.GetTable(update_query_1);
            }
            else
            {
                //int nextNum = Utilities.DataBaseUtility.GetNextNumber()
                //string q1 = "select DocNum from EmployeeBenefits";
                //int a1 = Utilities.DataBaseUtility.GetLastNumber(ident, q1);
                //String insert_query_0 = "insert into EmployeeBenefits values('" + doc_num_emp_ben
                //+ "','65','" + doc_num_ben + "','0','1','0','0','new open request for adding benefit')";
                //DataTable dTable0 = Utilities.DataBaseUtility.GetTable(insert_query_0);



            }
            //Adding new record in Employee_Benefits_details table

            String doc_num_ben = textBox_DocNum.Text;

            // public static int Execute( IdentityObject ident,string _sqlCommand)

            //List<string> list1 = Utilities.DataBaseUtility.GetList("select DocNum from EmployeeBenefits where EmpID = '" + userid+"'");
            //String doc_num_emp_ben = list1[0];
            //MessageBox.Show(doc_num_emp_ben);

            //string q = "select DocNum from EmployeeBenefits where EmpID = '101'";
            //int a = Utilities.DataBaseUtility.Execute(ident, q);
            //MessageBox.Show(a.ToString());

            //insert record to benefits_details table
            int doc_num_emp_ben = 1; //need to change this ---> ("select DocNum from EmployeeBenefits where EmpID = '" + userid+"'")
            String insert_query_1 = "insert into EmployeeBenefits_Details values('" + doc_num_emp_ben
                + "','65','" + doc_num_ben + "','0','1','0','0','new open request for adding benefit')";
            DataTable dTable2 = Utilities.DataBaseUtility.GetTable(insert_query_1);

            MessageBox.Show("Your request for adding the benefit has been sent to the Admin. Please wait for the approval");

            this.Close();
            */
        }

        private void btn_delete_benefit_Click(object sender, EventArgs e)
        {
            /*
            String userid = ident.UserID;

            //reduce ben count on delete request

            String update_query_2 = "update EmployeeBenefits set benCount = benCount- " + 1 + "where EmpID = '" + userid + "'";
            DataTable dTable = Utilities.DataBaseUtility.GetTable(update_query_2);

            String doc_num_ben = textBox_DocNum.Text;

            String update_query_3 = "update EmployeeBenefits_Details set reqID = '0', req_Status = '1', comment = 'new open request for deleting benefit' where docRef = '" + doc_num_ben + "'";
            DataTable dTable2 = Utilities.DataBaseUtility.GetTable(update_query_3);
            */

        }
    }
}
