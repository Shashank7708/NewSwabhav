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

        public static void Insert(Contact x)
        {
        //    ContactService service = new ContactService();
      //     List<Contact> li = service.getContacts();
    //        foreach (var i in li)
  //          {
                db.contacts.Add(x);

//            }
            

            db.SaveChanges();
        }

        public List<Contact> GetContact()
        {
            List<Contact> list = new List<Contact>();
            foreach(var i in db.contacts)
            {
                list.Add(i);
            }

            return list;
            
        }

        public void delete(Contact c)
        {
            var contact = db.contacts.SingleOrDefault(x => x.fname.Equals(c.fname));
            db.contacts.Remove(contact);
            db.SaveChanges();
        }

        public void update(Contact c)
        {
            var contact = db.contacts.SingleOrDefault(x => x.fname.Equals(c.fname));
            if (contact != null)
            {
                contact.lname = c.lname;
                contact.address = c.address;
                contact.phoneno = c.phoneno;

                db.SaveChanges();
            }

        }


       
    }
}