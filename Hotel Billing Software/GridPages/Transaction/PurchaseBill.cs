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
    public partial class PurchaseMaster : Form
    {
        public PurchaseMaster()
        {
            InitializeComponent();
        }

        private void onPageLoad()
        {
        }
        private void btnNewPurchase_Click(object sender, EventArgs e)
        {
            Transaction.PurchaseMaterial objForm = new Transaction.PurchaseMaterial();
            objForm.ShowDialog();
            onPageLoad();
        }
    }
}
