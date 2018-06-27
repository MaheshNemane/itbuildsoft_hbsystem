using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Master
{
     public class LabourExpenseTypeMaster
    {
        public int LEId { get; set; }
        public string LabourExpenseName { get; set; }
        public string cmd { get; set; }

        public string insertLabourExpenseType(LabourExpenseTypeMaster labourExpenseTypeMaster)
        {
            return Common.putData(labourExpenseTypeMaster, "sp_LabourExpenseType");
        }
        public string deleteLabourExpenseType(LabourExpenseTypeMaster labourExpenseTypeMaster)
        {
            return Common.putData(labourExpenseTypeMaster, "sp_LabourExpenseType");
        }
        public string updateLabourExpenseType(LabourExpenseTypeMaster labourExpenseTypeMaster)
        {
            return Common.putData(labourExpenseTypeMaster, "sp_LabourExpenseType");
        }
        public DataSet getLabourExpenseType(Int32 LEId)
        {
            this.LEId = LEId;
            this.cmd = "getLabourExpenseType";
            return Common.getData(this, "sp_LabourExpenseType");
        }
        public DataSet getAllLabourExpenseType()
        {
            this.cmd = "getAllLabourExpenseType";
            return Common.getData(this, "sp_LabourExpenseType");
        }
        public DataSet getAllLabourExpenseTypeCmb()
        {
            this.cmd = "getAllLabourExpenseTypeCmb";
            return Common.getData(this, "sp_LabourExpenseType");
        }
    }
}
