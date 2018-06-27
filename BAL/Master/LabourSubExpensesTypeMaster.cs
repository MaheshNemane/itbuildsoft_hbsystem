using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Master
{
   public class LabourSubExpensesTypeMaster
    {
        public int LSEId { get; set; }
        public int LEId { get; set; }
        public string SubExpName { get; set; }
        public string cmd { get; set; }


        public string insertLabourSubExpenseType(LabourSubExpensesTypeMaster labourSubExpenseTypeMaster)
        {
            return Common.putData(labourSubExpenseTypeMaster, "sp_LabourSubExpense");
        }


        public string deleteLabourSubExpenseType(LabourSubExpensesTypeMaster labourSubExpenseTypeMaster)
        {
            return Common.putData(labourSubExpenseTypeMaster, "sp_LabourSubExpense");
        }


        public string updateLaboursubExpenseType(LabourSubExpensesTypeMaster labourSubExpenseTypeMaster)
        {
            return Common.putData(labourSubExpenseTypeMaster, "sp_LabourSubExpense");
        }


        public DataSet getLabourSubExpenseType(Int32 LSEId)
        {
            this.LSEId = LSEId;
            this.cmd = "getLaboursubExpenseType";
            return Common.getData(this, "sp_LabourSubExpense");
        }


        public DataSet getAllLabourSubExpenseType()
        {
            this.cmd = "getAllLabourSubExpenseType";
            return Common.getData(this, "sp_LabourSubExpense");
        }


        public DataSet getAllLabourSubExpenseTypeCmb(LabourSubExpensesTypeMaster labourSubExpenseTypeMaster)
        {
            this.cmd = "getAllLabourSubExpenseTypeCmb";
            return Common.getData(this, "sp_LabourSubExpense");
        }

    }
}
