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
    public partial class EmployeeMaster : Form
    {

        BAL.Master.EmployeeMaster EmpMst = new BAL.Master.EmployeeMaster();
        public EmployeeMaster()
        {
            InitializeComponent();
            onPageLoad();
        }

        private void onPageLoad()
        {
            try { 
            gridEmployeeMaster.DataSource = EmpMst.getAllEmployee().Tables[0];
            gridEmployeeMaster.Columns[0].HeaderText = "वेटर क्रमांक";
            gridEmployeeMaster.Columns[1].HeaderText = "वेटर नाव";
            gridEmployeeMaster.Columns[2].HeaderText = "पत्ता";
            gridEmployeeMaster.Columns[3].HeaderText = "मोबाईल क्रमांक";
            gridEmployeeMaster.Columns[4].HeaderText = "पगार";
        }
            catch (Exception ex)
            {
                Common.showDenger(ex.Message);
            }
}


        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                Master.EmployeeRegistration objForm = new Master.EmployeeRegistration();
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
