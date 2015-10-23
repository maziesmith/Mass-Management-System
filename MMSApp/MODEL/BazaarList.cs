using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MMSApp.MODEL
{
    public class BazaarList
    {
        public int Id { get; set; }
        public int MemberId  { get; set; }
        public string BazaarDate { get; set; }
        public int SerialNo { get; set; }
        public string MemberName { get; set; }
        public string MemberEmail { get; set; }
    }
}