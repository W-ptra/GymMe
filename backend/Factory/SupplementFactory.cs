using backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace backend.Factory
{
    public class SupplementFactory
    {
        public static MsSupplement createNewSupplement(String name,DateTime date,int price,int typeId)
        {
            return new MsSupplement
            {
                SupplementName = name,
                SupplementExpirtyDate = date,
                SupplementPrice = price,
                SupplementTypeID = typeId
            };
        }
    }
}