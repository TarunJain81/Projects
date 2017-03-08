using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Applications.Applications.HR.HrBenefit.HRAdmin
{
    public partial class HRAdmin_Add_Benefit : HAWK_Template_1
    {
        public HRAdmin_Add_Benefit()
        {
            InitializeComponent();
        }

        public HRAdmin_Add_Benefit(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        public HRAdmin_Add_Benefit(IdentityObject ident, string selected_docNum)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);

            label2_add_docNum.Text = selected_docNum;
        }

        //--10/23/2016 patty
        private void button_execute_adding_Click(object sender, EventArgs e)
        {
            String emp_level = textBox_add_empLevel.Text;
            String benefit_type = textBox_add_benefitType.Text;
            String benefit_name = textBox_add_benefitName.Text;
            String percent = textBox_add_percent.Text;

            //insert record to benefits_details table
            String com = "insert into Benefits_Details values('" + label2_add_docNum.Text 
                + "','61','"+ emp_level + "','" + benefit_type + "','" + percent + "','0','0','" + benefit_name +
                " allowance applicable for admin level " + emp_level + "')";
            DataTable dTable = Utilities.DataBaseUtility.GetTable(com);

            //update benefits table
            String com2 = "update Benefits set percBenefits = percBenefits +" + percent + " where docNum = " + label2_add_docNum.Text;
            DataTable dTable2 = Utilities.DataBaseUtility.GetTable(com2);


            this.Close();




        }

        private void button_reset_adding_Click(object sender, EventArgs e)
        {
           textBox_add_empLevel.Text = "";
             textBox_add_benefitType.Text = "";
             textBox_add_benefitName.Text = "";
           textBox_add_percent.Text = "";
        }
    }
}
