using ContactCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactCore.Repository
{
  public class SwabhavRepository
    {

        private static SwabahvDbContext1 db;

        public SwabhavRepository()
        {
            db = new SwabahvDbContext1();
        }


        public List<Contact> contactList()
        {
            db.SaveChanges();
            return db.contact.ToList();
            
        }
       
        public void insertcontact(Contact c)
        {
            Contact c1 = new Contact {FirstName = c.FirstName, LastName = c.LastName, contactNo = c.contactNo };

            db.contact.Add(c1);
            db.SaveChanges();
        }

        
        public void DeleteContact(int id)
        {
           
            foreach (Contact c in db.contact)
            {
                if (c.Id == id)
                {
                    db.contact.Remove(c);
                }
            }
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
            var contact = db.contact.SingleOrDefault(x => x.Id == c.Id);
            contact.FirstName = c.FirstName;
            contact.LastName = c.LastName;
            contact.contactNo = c.contactNo;
            db.SaveChanges();
            return true;
        }

      
    }
}
