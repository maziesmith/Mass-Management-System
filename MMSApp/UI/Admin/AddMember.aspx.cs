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
    public partial class AddMember : System.Web.UI.Page
    {
        UserManager aUserManager = new UserManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<User> userMemberList = aUserManager.GetAllUsersByDropDownList();

                userMemberDropDownList.DataSource = userMemberList;
                userMemberDropDownList.DataValueField = "Id";
                userMemberDropDownList.DataTextField = "UserName";
                userMemberDropDownList.DataBind();
            }
        }

        protected void AddMemberButton_Click(object sender, EventArgs e)
        {
            User aUser = new User();
            aUser.UserId = int.Parse(userMemberDropDownList.SelectedValue);

            message.Text = aUserManager.SaveMember(aUser);
        }
    }
}