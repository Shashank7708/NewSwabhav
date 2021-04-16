using ContactCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactCore.Repository
{
    class ContactRepository
    {
        private static SwabahvDbContext db;

        public ContactRepository()
        {
            db = new SwabahvDbContext();
        }


        public List<Contact> contactList()
        {
           
            return db.contacts.ToList();

        }

        public void insertcontact(Contact c)
        {
            Contact c1 = new Contact { FirstName = c.FirstName, LastName = c.LastName, contactNo = c.contactNo };

            db.contacts.Add(c1);
            db.SaveChanges();
        }


        public void DeleteContact(int id)
        {
            Contact c2 = db.contacts.SingleOrDefault(x => x.Id == id);
            db.contacts.Remove(c2);
            db.SaveChanges();

        }


        /*  public List<Contact> search(string name)
          {
              List<Contact> contactist = new List<Contact>();
              int id = 0;
              foreach (var i in db.contact)
              {
                  if (i.FirstName.ToLower().Equals(name.ToLower()))
                  {
                      contactist.Add(i);

                  }
              }
              return contactist;
          }
        */


        public bool EditContact(Contact c)
        {
            var contact = db.contacts.SingleOrDefault(x => x.Id == c.Id);
            contact.FirstName = c.FirstName;
            contact.LastName = c.LastName;
            contact.contactNo = c.contactNo;
            db.SaveChanges();
            return true;
        }

    }
}
