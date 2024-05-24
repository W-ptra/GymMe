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

        public static List<TransactionDetail> GetAllTransactionDetailById(int id)
        {
            GymMeSQLDatabaseEntitiesX db = DBInstance.getInstance();
            List<TransactionDetail> TDlist = db.TransactionDetails.Where(TD => TD.TransactionID == id).ToList();
            //return db.TransactionDetails.ToList();
            return TDlist;
        }
    }
}