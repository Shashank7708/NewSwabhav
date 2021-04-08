using MVCandEntityFramework.Models;
using MVCandEntityFramework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCandEntityFramework.Service
{
    public static class ContactService
    {
      static  List<Contact> contactlist = new List<Contact>();
        static ContactRepo db = new ContactRepo();
        public static List<Contact> getContacts()
        {
            // var contact = new Contact { fname = "Romy", lname = "Rajan", phoneno = 123456, address = "Vasai" };
            // var contact1 = new Contact { fname = "Sharon", lname = "George", phoneno = 56789, address = "Mumbai" };
            //  var contact2 = new Contact { fname = "shehan", lname = "Shetty", phoneno = 34567, address = "Mumbai" };
            // contactlist.Add(contact);
            // contactlist.Add(contact1);
            // contactlist.Add(contact2);
            return db.GetContact();

        }

        public static void insert(Contact c)
        {
            ContactRepo.Insert(c);
        }

        public static void delete(Contact c)
        {
            db.delete(c);
        }


        public static void update(Contact c)
        {
            db.update(c);
        }

       
    }
}