using backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace backend.Repository
{
    public class DBInstance
    {
        private static GymMeSQLDatabaseEntities1 instance;

        public static GymMeSQLDatabaseEntities1 getInstance()
        {
            if (instance == null)
            {
                instance = new GymMeSQLDatabaseEntities1();
            }
            return instance;
        }
    }
}