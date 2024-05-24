using backend.Factory;
using backend.Model;
using backend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace backend.Handler
{
    public class CartHandler
    {
        public static void addNewCart(int userId,int SupplementId,int quantity)
        {
            MsCart newCart = CartFactory.createNewCart(userId, SupplementId, quantity);
            CartRepository.AddCart(newCart);
        }

        public static List<MsCart> GetAllCarts(int id)
        {
            return CartRepository.getCartList(id);
        }

        public static void removeCart(int userId)
        {
            CartRepository.deleteCart(userId);
        }
    }
}