using MVCandEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCandEntityFramework.Service
{
    public class ContactService
    {
      static  List<Contact> contactlist = new List<Contact>();

        public List<Contact> getContacts()
        {
            var contact = new Contact { fname = "Romy", lname = "Rajan", phoneno = 123456, address = "Vasai" };
            var contact1 = new Contact { fname = "Sharon", lname = "George", phoneno = 56789, address = "Mumbai" };
            var contact2 = new Contact { fname = "shehan", lname = "Shetty", phoneno = 34567, address = "Mumbai" };
            contactlist.Add(contact);
            contactlist.Add(contact1);
            contactlist.Add(contact2);
            return contactlist;

        }

    }
}