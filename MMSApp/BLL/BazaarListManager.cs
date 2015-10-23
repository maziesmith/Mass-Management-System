using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MMSApp.DAL;
using MMSApp.MODEL;

namespace MMSApp.BLL
{
    public class BazaarListManager
    {
        BazaarListGateway aBazaarListGateway = new BazaarListGateway();
        public string SaveBazaarList(BazaarList aBazaarList)
        {
            if (aBazaarListGateway.SaveBazaarList(aBazaarList) > 0)
            {
                return "Added Successfully";
            }
            else
            {
                return "Could Not Added!";
            }
        }
        public List<BazaarList> GetBazaarListById(int memberId)
        {
            return aBazaarListGateway.GetBazaarListById(memberId);
        }
    }
}