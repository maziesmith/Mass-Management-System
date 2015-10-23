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
    public partial class BazaarInformation : System.Web.UI.Page
    {
        UserManager aUserManager = new UserManager();
        BazaarManager aBazaarManager=new BazaarManager();
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

        protected void showBazaarButton_Click(object sender, EventArgs e)
        {
            int memberId = int.Parse(memberNameDropDownList.SelectedValue);
            List<Bazaar> showBazaar = aBazaarManager.GetBazaarById(memberId);
            int bazaarCount = 0;
            foreach (var bazaar in showBazaar)
            {
                bazaarCount = bazaar.BazaarAmount + bazaarCount;
            }
            message.Text = bazaarCount.ToString();
            showBazaarInformation.DataSource = showBazaar;
            showBazaarInformation.DataBind();
        }
    }
}