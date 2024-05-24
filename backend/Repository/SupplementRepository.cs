using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using backend.Model;

namespace backend.Repository
{
    public class SupplementRepository
    {
        public static List<MsSupplement> getMsSupplementList()
        {
            GymMeSQLDatabaseEntitiesX db = DBInstance.getInstance();
            return db.MsSupplements.ToList();
        }
    }
}