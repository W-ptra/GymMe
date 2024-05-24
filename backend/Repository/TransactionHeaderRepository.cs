using backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace backend.Repository
{
    public class TransactionHeaderRepository
    {
        public static void createNewTransactionHeader(TransactionHeader newTransactionHeader)
        {
            GymMeSQLDatabaseEntitiesX db = DBInstance.getInstance();
            db.TransactionHeaders.Add(newTransactionHeader);
            db.SaveChanges();
        }

        public static void updateStatus(int id,String status)
        {
            GymMeSQLDatabaseEntitiesX db = DBInstance.getInstance();
            TransactionHeader currentTransacrionHeader = db.TransactionHeaders.Where(TH => TH.TransactionID == id).FirstOrDefault();
            currentTransacrionHeader.Status = status;
            db.SaveChanges();
        }
    }
}