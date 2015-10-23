using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MMSApp.DAL;
using MMSApp.MODEL;

namespace MMSApp.BLL
{
    public class UserManager
    {
        UserGateway aUserGateway = new UserGateway();
        public List<Role> GetAllRoleByDropDownList()
        {
            return aUserGateway.GetAllRoleByDropDownList();
        }

        public string Register(User aUser)
        {
            if (aUserGateway.Register(aUser) > 0)
            {
                return "Added Successfully";
            }
            else
            {
                return "Could Not Added!";
            }
        }

        public User GetLoginUsers(string userName, string password, int role)
        {
            return aUserGateway.GetLoginUsers(userName, password, role);
        }

        public List<User> GetAllUsersByDropDownList()
        {
            return aUserGateway.GetAllUsersByDropDownList();
        }

        public string SaveMember(User aUser)
        {
            if (aUserGateway.SaveMember(aUser) > 0)
            {
                return "Added Successfully";
            }
            else
            {
                return "Could Not Added!";
            }
        }

        public List<User> GetAllMemberByRepeater()
        {
            return aUserGateway.GetAllMemberByRepeater();
        }

        public List<User> GetAllMemberByDropDownList()
        {
            return aUserGateway.GetAllMemberByDropDownList();
        }
    }
}