using backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace backend.Factory
{
    public class CartFactory
    {
        public static MsCart createNewCart(int userId,int supplementId,int quantity)
        {
            return new MsCart
            {
                UserId = userId,
                SupplementID = supplementId,
                Quantity = quantity
            };
        }
    }
}