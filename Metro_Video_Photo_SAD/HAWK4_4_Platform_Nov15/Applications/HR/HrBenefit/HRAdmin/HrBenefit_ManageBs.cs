using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

//patty 11/05/2016 HR admin can choose add/update/delete record from benefits_details table
namespace Applications.Applications.HR.HrBenefit.HRAdmin
{
    public partial class HrBenefit_ManageBs : HAWK_Template_2
    {
        String docNum;
        protected DataTable _documentValues;
        String benefit_type;

        public HrBenefit_ManageBs()
        {
            InitializeComponent();
        }
        public HrBenefit_ManageBs(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        public HrBenefit_ManageBs(IdentityObject ident,String selected_docNum)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);

            docNum = selected_docNum;

            label1.Text = "select * from Benefits_Details where docNum =" + docNum;

           
        }


        private void button_Get_B_Ds_Click(object sender, EventArgs e)
        {
            try
            {
                string cmdStr2 = String.Format("select * from Benefits_Details where docNum = {0}", docNum);
                _documentValues = Utilities.DataBaseUtility.GetTable(cmdStr2);
                dataGridView1.DataSource = _documentValues;
                
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("  error in reading GenDocs " + ex.Message);
            }
        }

        private void button_AddB_Click(object sender, EventArgs e)
        {
            new Applications.HR.HrBenefit.HRAdmin.HRAdmin_Add_Benefit(base.ident, docNum).Show();

        }

        private void button_updateB_Click(object sender, EventArgs e)
        {
          
            benefit_type = Interaction.InputBox("You are going to UPDATE Benefit No." + docNum +
                ". \n Please enter what type of the benefit you would like to update:");

            new Applications.HR.HrBenefit.HRAdmin.HrAdmin_Update_Benefit(base.ident, docNum, benefit_type).Show();


        }

        private void button_deleteB_Click(object sender, EventArgs e)
        {

            String benefit_type_d = "";
            benefit_type_d = Interaction.InputBox("You are going to DELETE Benefit No." + docNum +
                ". \n Please enter what type of the benefit you would like to delete:");



            List<string> _records = new List<string>();
            try
            {
                _records = Utilities.DataBaseUtility.GetList("select benefitTypePercent from Benefits_Details where docNum = " + docNum + " and benefitType = " + benefit_type_d);
                _records.RemoveAt(0);

                string[] _documentValues = _records[0].Split(',');
                String percent_o = _documentValues[0].ToString();

                //delete record on Benefits_Details table
                String com = "delete from Benefits_Details where docNum = " + docNum + " and benefitType = " + benefit_type_d;
                DataTable dTable = Utilities.DataBaseUtility.GetTable(com);




                //update benefits table
                String com2 = "update Benefits set percBenefits = percBenefits -" + percent_o + " where docNum = " + docNum;
                DataTable dTable2 = Utilities.DataBaseUtility.GetTable(com2);

                if (benefit_type_d != "")
                {
                    MessageBox.Show("You have deleted Benefit Type " + benefit_type_d + " for docNum: " + docNum + " in Benefits_Details table!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("  error in reading table : select benefitTypePercent from Benefits_Details where docNum = 101" + docNum + " and benefitType = " + benefit_type_d, ex.Message);
                return;
            }

           
        }
    }
}
