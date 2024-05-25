using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using backend.Model;

namespace backend.Repository
{
    public class SupplementRepository
    {
        public static MsSupplement getSupplement(int id)
        {
            GymMeSQLDatabaseEntitiesX db = DBInstance.getInstance();
            MsSupplement supplement = db.MsSupplements.Where(supp => supp.SupplementID == id).FirstOrDefault();
            return supplement;
        }
        public static List<MsSupplement> getMsSupplementList()
        {
            GymMeSQLDatabaseEntitiesX db = DBInstance.getInstance();
            return db.MsSupplements.ToList();
        }

        public static void insertNewSupplement(MsSupplement supplement)
        {
            GymMeSQLDatabaseEntitiesX db = DBInstance.getInstance();
            db.MsSupplements.Add(supplement);
            db.SaveChanges();
        }

        public static void updateSupplement(int supplementId,String name,DateTime date,int price,int typeId)
        {
            GymMeSQLDatabaseEntitiesX db = DBInstance.getInstance();
            MsSupplement supplement = getSupplement(supplementId);
            supplement.SupplementName = name;
            supplement.SupplementExpirtyDate = date;
            supplement.SupplementPrice = price;
            supplement.SupplementTypeID = typeId;
            db.SaveChanges();
        }

        public static void deleteSupplement(int id)
        {
            GymMeSQLDatabaseEntitiesX db = DBInstance.getInstance();
            MsSupplement supplement = getSupplement(id);
            db.MsSupplements.Remove(supplement);
            db.SaveChanges();
        }
    }
}