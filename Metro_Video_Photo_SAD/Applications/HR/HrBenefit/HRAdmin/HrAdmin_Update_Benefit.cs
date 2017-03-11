using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//patty 11/05/2016 
namespace Applications.Applications.HR.HrBenefit.HRAdmin
{
    public partial class HrAdmin_Update_Benefit : HAWK_Template_2
    {

        String doc_Num;
        String benefit_Type;
        String percent_o;
        String level_o;
        String comment_o;
        protected DataTable _documentValues;
        public HrAdmin_Update_Benefit()
        {
            InitializeComponent();
        }
        public HrAdmin_Update_Benefit(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);


        

        }

        public HrAdmin_Update_Benefit(IdentityObject ident, String docNum, String benefitType)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);

            doc_Num = docNum;
            benefit_Type = benefitType;
            label_pickedDocNum.Text = docNum;
            label_show_Btype.Text = benefitType;
            

            List<string> _records = new List<string>();
            try
            {
                //  _documentValues = Utilities.DataBaseUtility.GetTable(cmdStr);
                _records = Utilities.DataBaseUtility.GetList("select * from Benefits_Details where docNum = " + docNum + " and benefitType = " + benefitType);
            }
            catch (Exception ex)
            {
                MessageBox.Show("  error in reading table : select * from Benefits_Details where docNum = " + docNum + " and benefitType = " + benefitType, ex.Message);
                return;
            }

            _records.RemoveAt(0);

            string[] _documentValues = _records[0].Split(',');
            level_o = _documentValues[2].ToString(); 
            percent_o = _documentValues[4].ToString();
            comment_o = _documentValues[7].ToString();
            textBox_level.Text = level_o;
            textBox_Percentage.Text = percent_o;
            textBox_desc.Text = comment_o;
        }

        //update
        private void button_execute_u_Click(object sender, EventArgs e)
        {
            String emp_level = textBox_level.Text;
            String benefit_name = textBox_desc.Text;
            String percent = textBox_Percentage.Text;

            //update benefits_details table
            String com = "update Benefits_Details set benefitTypePercent = " + percent + ", empadminlevel = "
                + emp_level + ", comment = '"
                + benefit_name+ "' where docNum = " + doc_Num +
                " and benefitType = " + benefit_Type;
            DataTable dTable = Utilities.DataBaseUtility.GetTable(com);

            //update benefits table
            String com2 = "update Benefits set percBenefits = percBenefits - " + percent_o + "+" + percent + " where docNum = "+ doc_Num ;
            DataTable dTable2 = Utilities.DataBaseUtility.GetTable(com2);

            this.Close();


        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            textBox_level.Text = level_o;
            textBox_Percentage.Text = percent_o;
            textBox_desc.Text = comment_o;
        }
    }
}
