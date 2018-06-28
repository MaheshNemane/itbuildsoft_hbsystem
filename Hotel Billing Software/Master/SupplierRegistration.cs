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
    public partial class SupplierRegistration : MetroFramework.Forms.MetroForm
    {
        SupplierMaster supplierMaster = new SupplierMaster();
        public SupplierRegistration()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            supplierMaster.Name = txtName.Text;
            supplierMaster.MobileNo = txtMobile.Text;
            supplierMaster.Address = txtAddress.Text;
            supplierMaster.ShopName = txtShopName.Text;

            BunifuFlatButton btn = (BunifuFlatButton)sender;
            supplierMaster.cmd = btn.Text;
            string msgText = supplierMaster.insertSupplier(supplierMaster);
            MessageBox.Show(msgText, "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
