using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Billing_Software.GridPages
{
    public partial class MenuCategoryMaster : Form
    {
        BAL.Master.MenuCategoryMaster menuCategory = new BAL.Master.MenuCategoryMaster();

        public MenuCategoryMaster()
        {
            InitializeComponent();
            onPageLoad();
        }

        private void onPageLoad()
        {
            try { 
            gridMenuCategoryMaster.DataSource = menuCategory.getAllMenuCategory().Tables[0];
            gridMenuCategoryMaster.Columns[1].HeaderText = "प्रकार नाव";
            gridMenuCategoryMaster.Columns[2].HeaderText = "स्थिती";
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }


        private void btnNewMenuCategory_Click(object sender, EventArgs e)
        {
            try { 
            Master.MenuCategory objForm = new Master.MenuCategory();
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
