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
    }
}