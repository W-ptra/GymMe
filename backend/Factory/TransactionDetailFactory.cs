using backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace backend.Factory
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail createNewTransactionDetail(int transactionId,int supplementId,int quantity)
        {
            return new TransactionDetail
            {
                TransactionID = transactionId,
                SupplementID = supplementId,
                Quantity = quantity
            };
        }
    }
}