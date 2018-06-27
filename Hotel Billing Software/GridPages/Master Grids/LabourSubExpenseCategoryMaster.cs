using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Billing_Software.GridPages.Master_Grids
{
    public partial class LabourSubExpenseCategoryMaster : Form
    {
        BAL.Master.LabourSubExpensesTypeMaster labourSubExpensesType = new BAL.Master.LabourSubExpensesTypeMaster();
        public LabourSubExpenseCategoryMaster()
        {
            InitializeComponent();
            onPageLoad();
        }

        private void onPageLoad()
        {
            try { 
            gridLabourSubExpenseCategoryMaster.DataSource = labourSubExpensesType.getAllLabourSubExpenseType().Tables[0];
            gridLabourSubExpenseCategoryMaster.Columns[0].HeaderText = "Category Id";
            gridLabourSubExpenseCategoryMaster.Columns[1].HeaderText = "Category Name";
            gridLabourSubExpenseCategoryMaster.Columns[2].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void btnNewLabourSubExpenseCategory_Click(object sender, EventArgs e)
        {
            try { 
            LabourSubExpenseCategoryMaster objForm = new LabourSubExpenseCategoryMaster();
            objForm.ShowDialog();
            onPageLoad();
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }
    }
}
