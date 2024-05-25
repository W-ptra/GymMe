using backend.Factory;
using backend.Model;
using backend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace backend.Handler
{
    public class SupplementHandler
    {
        public static List<MsSupplement> getSupplement()
        {
            return SupplementRepository.getMsSupplementList();
        }

        public static void insertNewSupplement(String name,DateTime date,int price,int typeId)
        {
            MsSupplement newSupplement = SupplementFactory.createNewSupplement(name,date,price,typeId);
            SupplementRepository.insertNewSupplement(newSupplement);
        }

        public static void updateSupplement(int id,String name,DateTime date,int price,int typeId)
        {
            SupplementRepository.updateSupplement(id,name,date,price,typeId);
        }

        public static void deleteSupplement(int id)
        {
            SupplementRepository.deleteSupplement(id);
        }
    }
}