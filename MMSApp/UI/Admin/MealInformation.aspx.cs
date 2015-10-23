using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MMSApp.BLL;
using MMSApp.MODEL;

namespace MMSApp.UI.Admin
{
    public partial class MealInformation : System.Web.UI.Page
    {
        UserManager aUserManager = new UserManager();
        MealManager aMealManager = new MealManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<User> userMemberList = aUserManager.GetAllMemberByDropDownList();

                memberNameDropDownList.DataSource = userMemberList;
                memberNameDropDownList.DataValueField = "Id";
                memberNameDropDownList.DataTextField = "UserName";
                memberNameDropDownList.DataBind();
            }
        }

        public float CountSingleMeal { get; set; }
        protected void showMealButton_Click(object sender, EventArgs e)
        {
            int memberId = int.Parse(memberNameDropDownList.SelectedValue);
            List<Meal> showMeal = aMealManager.GetMealById(memberId);
            float mealCount = 0;
            foreach(var meal in showMeal)
            {
                mealCount = meal.MealNumber + mealCount;
            }
            message.Text = mealCount.ToString();
            showMealInformation.DataSource = showMeal;
            showMealInformation.DataBind();
        }
    }
}