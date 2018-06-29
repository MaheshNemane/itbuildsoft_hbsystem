using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Billing_Software.Account
{
    public partial class ChangePassword : MetroFramework.Forms.MetroForm
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelMiddle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUserName_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
