using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MMSApp.DAL;
using MMSApp.MODEL;

namespace MMSApp.BLL
{
    public class BazaarManager
    {
        BazaarGateway aBazaarGateway = new BazaarGateway();

        public string AddBazaar(Bazaar aBazaar)
        {
            if (aBazaarGateway.AddBazaar(aBazaar)>0)
            {
                return "Added Successfully";
            }
            else
            {
                return "Could Not Added!";
            }
        }

        public List<Bazaar> GetBazaarById(int memberId)
        {
            return aBazaarGateway.GetBazaarById(memberId);
        }
    }
}