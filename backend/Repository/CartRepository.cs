using backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace backend.Repository
{
    public class CartRepository
    {
        public static void AddCart(MsCart newCart)
        {
            GymMeSQLDatabaseEntitiesX db = DBInstance.getInstance();
            db.MsCarts.Add(newCart);
            db.SaveChanges();
        }
        public static List<MsCart> getCartList(int userId)
        {
            GymMeSQLDatabaseEntitiesX db = DBInstance.getInstance();
            return db.MsCarts.Where(cart => cart.UserId == userId).ToList();
        }

        public static void deleteCart(int id)
        {
            GymMeSQLDatabaseEntitiesX db = DBInstance.getInstance();
            List<MsCart> userCart = db.MsCarts.Where(cart => cart.UserId == id).ToList();
            db.MsCarts.RemoveRange(userCart);
            db.SaveChanges();
        }
    }
}