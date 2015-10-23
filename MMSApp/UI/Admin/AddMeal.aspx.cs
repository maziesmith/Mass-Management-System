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
    public partial class AddMeal : System.Web.UI.Page
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

        protected void AddMealButton_Click(object sender, EventArgs e)
        {
            Meal aMeal = new Meal();
            aMeal.MemberId = int.Parse(memberNameDropDownList.SelectedValue);
            aMeal.MealDate = Request.Form["mealDateTextBox"];
            aMeal.MealNumber = float.Parse(Request.Form["mealNumberTextBox"]);

            message.Text = aMealManager.AddMeal(aMeal);
        }
    }
}