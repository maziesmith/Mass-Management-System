using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MMSApp.MODEL
{
    public class Bazaar
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public string BazaarDate { get; set; }
        public int BazaarAmount { get; set; }
        public int SerialNo { get; set; }
    }
}