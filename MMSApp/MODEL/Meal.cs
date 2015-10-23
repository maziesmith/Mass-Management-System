using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MMSApp.MODEL
{
    public class Meal
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public string MealDate { get; set; }
        public float MealNumber { get; set; }
        public int SerialNo { get; set; }
        public float Count { get; set; }
        public float TotalCountMeal { get; set; }
    }
}