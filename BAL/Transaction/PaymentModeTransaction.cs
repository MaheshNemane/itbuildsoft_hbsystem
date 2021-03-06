﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Transaction
{
    public class PaymentModeTransaction
    {
        public Int32 PaymentId { get; set; }
        public string PaymentCategoryName { get; set; }
        public string Status { get; set; }
        public string cmd { get; set; }

        public string insertPaymentCategory(PaymentModeTransaction paymentMode)
        {
            return Common.putData(paymentMode, "sp_PaymentModeCategory");
        }


        public string updatePaymentCategory(PaymentModeTransaction paymentMode)
        {
            return Common.putData(paymentMode, "sp_PaymentModeCategory");
        }

        public string deletePaymentCategory(PaymentModeTransaction paymentMode)
        {
            return Common.putData(paymentMode, "sp_PaymentModeCategory");
        }

        public DataSet getPaymentCategory(Int32 PaymentId)
        {
            this.PaymentId = PaymentId;
            this.cmd = "getPaymentCategory";
            return Common.getData(this, "sp_PaymentModeCategory");
        }


        public DataSet getAllPaymentCategory()
        {
            this.cmd = "getAllPaymentCategory";
            return Common.getData(this, "sp_PaymentModeCategory");
        }

        public DataSet getAllPaymentCategoryCmb()
        {
            this.cmd = "getAllPaymentCategoryCmb";
            return Common.getData(this, spname: "sp_PaymentModeCategory");
        }
    }
}
