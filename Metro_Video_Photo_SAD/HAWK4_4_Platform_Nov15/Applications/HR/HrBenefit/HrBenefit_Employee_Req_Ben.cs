using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applications.Applications.HR.HrBenefit
{
    public partial class HrBenefit_Employee_Req_Ben : HAWK_Template_2
    {
        protected DataTable _documentValues;

        public HrBenefit_Employee_Req_Ben(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);

            //String query = "select * from Benefits";
            //try
            //{
            //    string cmdAllBen = String.Format(query);
            //    _documentValues = Utilities.DataBaseUtility.GetTable(cmdAllBen);
            //    dataGridView_benefits.DataSource = _documentValues;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("  error in reading GenDocs " + ex.Message);
            //}
        }

        public HrBenefit_Employee_Req_Ben()
        {
            InitializeComponent();
            String query = "select * from Benefits";
            try
            {
                string cmdAllBen = String.Format(query);
                _documentValues = Utilities.DataBaseUtility.GetTable(cmdAllBen);
                dataGridView_benefits.DataSource = _documentValues;
            }
            catch (Exception ex)
            {
                MessageBox.Show("  error in reading GenDocs " + ex.Message);
            }
        }

        private void dataGridView_benefits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
