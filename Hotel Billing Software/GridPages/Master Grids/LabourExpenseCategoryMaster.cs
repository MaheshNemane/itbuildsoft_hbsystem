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
    public partial class LabourExpenseCategoryMaster : Form
    {
        BAL.Master.LabourExpenseTypeMaster labourExpenseType = new BAL.Master.LabourExpenseTypeMaster();

        public LabourExpenseCategoryMaster()
        {
            InitializeComponent();
            onPageLoad();
        }

        private void onPageLoad()
        {
            try
            {
                gridLabourExpenseCategoryMaster.DataSource = labourExpenseType.getAllLabourExpenseType().Tables[0];
                gridLabourExpenseCategoryMaster.Columns[0].HeaderText = "Sub Category Id";
                gridLabourExpenseCategoryMaster.Columns[0].HeaderText = "Category Id";
                gridLabourExpenseCategoryMaster.Columns[1].HeaderText = "Sub Category Name";
                gridLabourExpenseCategoryMaster.Columns[2].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }

        private void btnNewLabourExpenseCategory_Click(object sender, EventArgs e)
        {
            try
            {
                LabourExpenseCategoryMaster objForm = new LabourExpenseCategoryMaster();
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
