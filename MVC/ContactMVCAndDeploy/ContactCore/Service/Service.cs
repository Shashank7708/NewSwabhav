using ContactCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactCore.Service
{
   public class Service
    {
        static List<Contact> contacts = new List<Contact>();
        static int i = 0;
        public List<Contact> getContacts()
        {
            Contact c1 = new Contact { Id = i++, FirstName = "Romy", LastName = "Rajan", contactNo = 4728374 };
            Contact c2 = new Contact { Id = i++, FirstName = "Shehan", LastName = "Shetty", contactNo = 1234567 };
            contacts.Add(c1);
            contacts.Add(c2);
            return contacts;
        }

        public void insertContact(Contact c)
        {
            
            contacts.Add(c);
        }

        public void deleteContct(int id)
        {
            var contact = contacts.SingleOrDefault(x => x.Id == id);
            contacts.Remove(contact);
        }

        public void editContact(Contact c)
        {
            // db.EditContact(c);
        }

    }
}
