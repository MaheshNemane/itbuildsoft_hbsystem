using BAL.Master;
using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Billing_Software.Master
{
    public partial class MenuCategory : MetroFramework.Forms.MetroForm
    {
        MenuCategoryMaster menuCategory = new MenuCategoryMaster();

        public MenuCategory()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            menuCategory.CategoryName = txtCategory.Text;

            BunifuFlatButton btnsave = (BunifuFlatButton)sender;
            menuCategory.cmd = btnsave.Text;
            string msgText = menuCategory.insertMenuCategory(menuCategory);
            MessageBox.Show(msgText, "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
