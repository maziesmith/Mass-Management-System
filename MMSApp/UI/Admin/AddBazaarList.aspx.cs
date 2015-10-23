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
    public partial class AddBazaarList : System.Web.UI.Page
    {
        UserManager aUserManager = new UserManager();
        BazaarListManager aBazaarListManager = new BazaarListManager();
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

        protected void AddBazaarListButton_Click(object sender, EventArgs e)
        {
            BazaarList aBazaarList = new BazaarList();
            aBazaarList.MemberId = int.Parse(memberNameDropDownList.SelectedValue);
            aBazaarList.BazaarDate = Request.Form["bazaarDateTextBox"];

            message.Text = aBazaarListManager.SaveBazaarList(aBazaarList);
        }
    }
}