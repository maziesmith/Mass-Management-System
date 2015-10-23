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
    public partial class MemberInformation : System.Web.UI.Page
    {
        UserManager aUserManager = new UserManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadAllMemberByRepeater();
        }
        public void LoadAllMemberByRepeater()
        {
            List<User> userMemberList = aUserManager.GetAllMemberByRepeater();

            showMemberInformation.DataSource = userMemberList;
            showMemberInformation.DataBind();
        }
    }
}