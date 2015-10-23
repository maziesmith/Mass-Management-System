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
    public partial class BazaarListInformation : System.Web.UI.Page
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

        protected void showBazaarListButton_Click(object sender, EventArgs e)
        {
            //string memberId = Request.QueryString["member_id"];
            int memberId = int.Parse(memberNameDropDownList.SelectedValue);
            List<BazaarList> showBazaarList = aBazaarListManager.GetBazaarListById(memberId);

            showBazaarListInformation.DataSource = showBazaarList;
            showBazaarListInformation.DataBind();
        }
    }
}