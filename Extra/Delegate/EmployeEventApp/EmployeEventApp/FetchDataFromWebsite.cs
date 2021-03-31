using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace EmployeEventApp
{
    class FetchDataFromWebsite
    {
      public event  Action<string> FetchDataEvent=null;
        string text;

        public void FetchDataFromWebPage(string address)
        {
            if (FetchDataEvent != null)
            {
                var client = new WebClient();
                text = client.DownloadString(address);
                FetchDataEvent(text);
            }

        }
        public string GetText { get { return this.text; } }

    }
}
