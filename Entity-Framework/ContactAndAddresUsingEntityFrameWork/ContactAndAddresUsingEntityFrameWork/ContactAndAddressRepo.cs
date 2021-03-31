using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactAndAddresUsingEntityFrameWork
{
    class ContactAndAddressRepo
    {
        private const int FIRSTNAME = 1;
        private const int LASTNAME = 2;
        private const int PHONENO = 3;


        private static SwabhavDbContext3 db;

        public ContactAndAddressRepo()
        {
            db = new SwabhavDbContext3();
        }

        public List<Contact> contactList()
        {
            return db.contact.ToList();
        }
        public List<Address> addressList()
        {
            return db.address.ToList();
        }

        public void insert(Contact c)
        {
            db.contact.Add(c);
            db.SaveChanges();
        }

        public void DeleteContact(int id)
        {
            foreach(Address a in db.address)
            {
                if (a.Contact.Id == id)
                {
                    db.address.Remove(a);
                }
            }
            foreach(Contact c in db.contact)
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
            foreach(Address a in db.address)
            {
                if (a.Id == id)
                {
                    db.address.Remove(a);
                }
            }
            db.SaveChanges();
        }

        public List<Contact> search(string name)
        {
            List<Contact> contactist = new List<Contact>();
            int id = 0;
            foreach(var i in db.contact)
            {
                if (i.FirstName.ToLower().Equals(name.ToLower()))
                {
                    contactist.Add(i);

                }
            }
            return contactist;
        }

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
            foreach(var i in db.address)
            {
                if (i.Contact.Id == id)
                {
                    addressist.Add(i);
                }
            }
            return addressist;
        }

     public  bool EditContact(int choice, int id, string Modification)
        {
            var contact = db.contact.SingleOrDefault(x => x.Id == id);
            if (contact != null)
            {

                if (choice == FIRSTNAME)
                {
                   contact.FirstName= Modification;

                }
                else if (choice == LASTNAME)
                {
                    contact.LastName = Modification;
                }
                else if (choice == PHONENO)
                {
                    int mobile = Convert.ToInt32(Modification);
                    contact.contactNo = mobile;


                }
            }
            
            db.SaveChanges();
            return true;
        }

    }
}
