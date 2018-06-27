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
    public partial class CustomerMaster : Form
    {

        BAL.Master.CustomerMaster CustomerMst = new BAL.Master.CustomerMaster();
        public CustomerMaster()
        {
            InitializeComponent();
            onPageLoad();
        }

        private void onPageLoad()
        {
            try
            {
                gridCustomerMaster.DataSource = CustomerMst.getAllCustomer().Tables[0];
                gridCustomerMaster.Columns[0].HeaderText = "ग्राहक क्रमांक";
                gridCustomerMaster.Columns[1].HeaderText = "ग्राहक नाव";
                gridCustomerMaster.Columns[2].HeaderText = "पत्ता";
                gridCustomerMaster.Columns[3].HeaderText = "मोबाईल क्रमांक";
                gridCustomerMaster.Columns[4].HeaderText = "क्रेडिट मर्यादा";
            }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
        }
        
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                Master.CustomerRegistation objForm = new Master.CustomerRegistation();
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
