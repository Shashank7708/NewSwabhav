using ContactAndAddressInMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactAndAddressInMvc.Repository
{
    public class SwabhavRepository
    {
        private const int FIRSTNAME = 1;
        private const int LASTNAME = 2;
        private const int PHONENO = 3;


        private static SwabhavDbContext1 db;

        public SwabhavRepository()
        {
            db = new SwabhavDbContext1();
        }

        public List<Contact> contactList()
        {
            return db.contact.ToList();
        }
        public List<Address> addressList()
        {
            return db.address.ToList();
        }

        public void insertcontact(Contact c)
        {
            db.contact.Add(c);
            db.SaveChanges();
        }

        public void insertaddress(Address a)
        {
            db.address.Add(a);
            db.SaveChanges();
        }


        public void DeleteContact(int id)
        {
            foreach (Address a in db.address)
            {
                if (a.Contact.Id == id)
                {
                    db.address.Remove(a);
                }
            }
            foreach (Contact c in db.contact)
            {
                if (c.Id == id)
                {
                    db.contact.Remove(c);
                }
            }
            db.SaveChanges();

        }

        public void DeleteAddress(int id)
        {
            foreach (Address a in db.address)
            {
                if (a.Id == id)
                {
                    db.address.Remove(a);
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

        public List<Address> SearchAddress(string name)
        {

            List<Address> addressist = new List<Address>();
            int id = 0;
            foreach (var i in db.contact)
            {
                if (i.FirstName.ToLower().Equals(name.ToLower()))
                {
                    id = i.Id;
                }
            }
            foreach (var i in db.address)
            {
                if (i.Contact.Id == id)
                {
                    addressist.Add(i);
                }
            }
            return addressist;
        }

        public bool EditContact(Contact c)
        {
            var contact = db.contact.SingleOrDefault(x => x.Id == c.Id);
            contact.FirstName = c.FirstName;
            contact.LastName = c.LastName;
            contact.contactNo = c.contactNo;
            db.SaveChanges();
            return true;
        }

        public void editAddress(Address t)
        {
            var address = db.address.SingleOrDefault(x => x.Id == t.Id);
            address.address = t.address;
            db.SaveChanges();
        }

    }
}