using ContactCore.Model;
using ContactCore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactCore.Service
{
   public class ContactService
    {
        static ContactRepository db = new ContactRepository();


        public List<Contact> contacts()
        {
            return db.contactList();
        }

        public void insertContact(Contact c)
        {
            db.insertcontact(c);
        }


        public void deleteContct(int id)
        {
            db.DeleteContact(id);
        }


        public void editContact(Contact c)
        {
            db.EditContact(c);
        }

    }
}
