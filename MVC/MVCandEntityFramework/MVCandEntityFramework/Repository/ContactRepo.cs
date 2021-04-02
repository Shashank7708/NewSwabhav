using MVCandEntityFramework.Models;
using MVCandEntityFramework.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCandEntityFramework.Repository
{
    public class ContactRepo
    {
       static SwabhavDbContext db = new SwabhavDbContext();

        public static void Insert()
        {
            ContactService service = new ContactService();
           List<Contact> li = service.getContacts();
            foreach(var i in li)
            {
                db.contacts.Add(i);
           }
          
            

            db.SaveChanges();
        }

        public List<Contact> GetContact()
        {
          //  Insert();
            List<Contact> li = db.contacts.ToList();
            db.SaveChanges();
            return li;
        }


    }
}