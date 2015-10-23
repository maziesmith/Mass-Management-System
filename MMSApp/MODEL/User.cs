using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MMSApp.MODEL
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CreatedDate { get; set; }
        public string PresentAddress { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public int SerialNo { get; set; }
        public int UserId { get; set; }
    }
}