using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MMSApp.BLL;
using MMSApp.MODEL;

namespace MMSApp.UI
{
    public partial class Login : System.Web.UI.Page
    {
        UserManager aUserManager = new UserManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Role> loginRoleList = aUserManager.GetAllRoleByDropDownList();

                loginRoleDropDownList.DataSource = loginRoleList;
                loginRoleDropDownList.DataValueField = "Id";
                loginRoleDropDownList.DataTextField = "RoleName";
                loginRoleDropDownList.DataBind();
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string userName = Request.Form["loginUserNameTextBox"];
            string password = Request.Form["loginPasswordTextBox"];
            int role = int.Parse(loginRoleDropDownList.SelectedValue);
            User aUser = aUserManager.GetLoginUsers(userName, password, role);
            if (userName == aUser.UserName || password == aUser.Password)
            {
                if (role == 1)
                {
                    message.Text = "Login Successfully";
                    Session["UserInfo"] = aUser.UserName;
                    Response.Redirect("Admin/Index.aspx");
                }
                else
                {
                    Response.Redirect("Index.aspx");
                }  
            }
            else
            {
                message.Text = "Login Failed!";
            }
        }
    }
}