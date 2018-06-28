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
    public partial class EmployeeRegistration : MetroFramework.Forms.MetroForm
    {

        EmployeeMaster employeeMaster = new EmployeeMaster();

        public EmployeeRegistration()
        {
            InitializeComponent();
        }
       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            employeeMaster.Name = txtEmpName.Text;
            employeeMaster.MobileNo = txtEmpMobile.Text;
            employeeMaster.Address = txtEmpAddress.Text;
            employeeMaster.Salary = Convert.ToDouble(txtEmpSalary.Text);

            BunifuFlatButton btn = (BunifuFlatButton)sender;
            employeeMaster.cmd = btn.Text;
            string msgText = employeeMaster.insertEmployee(employeeMaster);
            MessageBox.Show(msgText, "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtEmpSalary_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEmpMobile_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeRegistration_Load(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
