using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MMSApp.DAL;
using MMSApp.MODEL;

namespace MMSApp.BLL
{
    public class MealManager
    {
        MealGateway aMealGateway = new MealGateway();
        public string AddMeal(Meal aMeal)
        {
            if (aMealGateway.AddMeal(aMeal) > 0)
            {
                return "Added Successfully";
            }
            else
            {
                return "Could Not Added!";
            }
        }

        public List<Meal> GetMealById(int memberId)
        {
            return aMealGateway.GetMealById(memberId);
        }
    }
}