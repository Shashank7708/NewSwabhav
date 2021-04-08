using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginAndLogoutInEntityFramework.ViewModel
{
    public class EditAndDeleteContact
    {
        public int id { get; set; }
        public string fname { get; set; }

        public string lname { get; set; }
        public int phoneno { get; set; }
        public string address { get; set; }
    }
}