using backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace backend.Repository
{
    public class TransactionDetailRepository
    {
        public static void addNewTransactionDetail(List<TransactionDetail> newTransactionDetail)
        {
            GymMeSQLDatabaseEntitiesX db = DBInstance.getInstance();
            db.TransactionDetails.AddRange(newTransactionDetail);
            db.SaveChanges();
        }
    }
}