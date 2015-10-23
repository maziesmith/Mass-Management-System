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
    public partial class Register : System.Web.UI.Page
    {
        UserManager aUserManager = new UserManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Role> aRoleLists = aUserManager.GetAllRoleByDropDownList();

                rgRoleIdDropDownList.DataSource = aRoleLists;
                rgRoleIdDropDownList.DataValueField = "Id";
                rgRoleIdDropDownList.DataTextField = "RoleName";
                rgRoleIdDropDownList.DataBind();
            }
        }
        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            User aUser = new User();
            aUser.FullName = Request.Form["rgFullNameTextBox"];
            aUser.UserName = Request.Form["rgUserNameTextBox"];
            aUser.Password = Request.Form["rgPasswordTextBox"];
            aUser.Email = Request.Form["rgEmailTextBox"];
            aUser.PhoneNumber = Request.Form["rgPhoneNumberTextBox"];
            aUser.CreatedDate = Request.Form["rgCreatedDateTextBox"];
            aUser.PresentAddress = Request.Form["rgPresentAddressTextArea"];
            aUser.RoleId = int.Parse(rgRoleIdDropDownList.SelectedValue);

            message.Text = aUserManager.Register(aUser);
        }
    }
}