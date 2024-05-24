using backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace backend.Repository
{
    public class DBInstance
    {
        private static GymMeSQLDatabaseEntitiesX instance;

        public static GymMeSQLDatabaseEntitiesX getInstance()
        {
            if (instance == null)
            {
                instance = new GymMeSQLDatabaseEntitiesX();
            }
            return instance;
        }
    }
}