using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactDb
{
    class ContactEFRepository : IContactRepository
    {
        private const int FIRSTNAME = 1;
        private const int LASTNAME = 2;
        private const int PHONENO = 3;

        public SwabhavDbContext contactDb;

        public ContactEFRepository(SwabhavDbContext contactdb)
        {
            this.contactDb = contactdb;
        }

        List<Contact> IContactRepository.GetContact()
        {
            return contactDb.contacts.ToList();
        }

        List<Contact> IContactRepository.SearchContact(string name)
        {
            List<Contact> contacts = new List<Contact>();
            foreach (Contact c in contactDb.contacts)
            {
                if (c.FirstName.ToLower().Equals(name.ToLower()) || c.LastName.ToLower().Equals(name.ToLower()))
                {
                    contacts.Add(c);
                }
            }
            return contacts;
        }

        bool IContactRepository.AddContact(Contact c)
        {
            contactDb.contacts.Add(c);
            contactDb.SaveChanges();
            return true;
        }

        bool IContactRepository.DeleteContact(int id)
        {
            foreach (Contact c in contactDb.contacts)
            {
                if (c.Id==id)
                {
                    contactDb.contacts.Remove(c);
                    
                    
                }
            }
            contactDb.SaveChanges();
            return true;
            
        }

        bool IContactRepository.EditContact(int choice, int id, string Modification)
        {
            foreach (Contact c in contactDb.contacts)
            {
                if (c.Id == id)
                {
                    if (choice == FIRSTNAME)
                    {
                        c.FirstName = Modification;

                    }
                    else if (choice == LASTNAME)
                    {
                        c.LastName = Modification;
                     }
                  else  if (choice == PHONENO)
                    {
                        int mobile = Convert.ToInt32(Modification);
                        c.PhoneNo = mobile;
                        

                    }
                }
            }
            contactDb.SaveChanges();
            return true;
        }

    }

}            
        

 