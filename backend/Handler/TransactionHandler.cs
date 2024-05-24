using backend.Factory;
using backend.Model;
using backend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace backend.Handler
{
    public class TransactionHandler
    {
        public static void createNewTransaction(int userId)
        {
            TransactionHeader newTransactionHeader = TransactionHeaderFactory.createNewTransactionHeader(userId);
            TransactionHeaderRepository.createNewTransactionHeader(newTransactionHeader);

            int transactionId = newTransactionHeader.TransactionID;

            List<MsCart> cartList = CartRepository.getCartList(userId);
            List<TransactionDetail> TDlist = new List<TransactionDetail>();
            foreach (MsCart cart in cartList)
            {
                TransactionDetail newTransactionDetail = TransactionDetailFactory.createNewTransactionDetail(transactionId, cart.SupplementID, cart.Quantity);
                TDlist.Add(newTransactionDetail);
            }

            TransactionDetailRepository.addNewTransactionDetail(TDlist);

            CartRepository.deleteCart(userId);
        }

        public static List<TransactionHeader> getAllTransactionHeaderById(int id)
        {
            return TransactionHeaderRepository.getAllTransactionDetailbyId(id);
        }

        public static List<TransactionHeader> getAllTransactionHeader()
        {
            return TransactionHeaderRepository.getAllTransactionHeader();
        }

        public static List<TransactionDetail> getAllTransactionDetail(int id)
        {
            return TransactionDetailRepository.GetAllTransactionDetailById(id);
        }
    }
}