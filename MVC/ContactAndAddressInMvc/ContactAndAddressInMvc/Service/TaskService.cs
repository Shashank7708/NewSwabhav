using ContactAndAddressInMvc.Models;
using ContactAndAddressInMvc.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactAndAddressInMvc.Service
{
    public static class TaskService
    {
       static SwabhavRepository db = new SwabhavRepository();


        public static List<Contact> contacts()
        {
            return db.contactList();
        }

        public static List<Address> address()
        {
            return db.addressList();
        }

        public static void insertContact(Contact c)
        {
            db.insertcontact(c);
        }

        public static void insertAddress(Address a)
        {
            db.insertaddress(a);
        }


        public static void deleteContct(int id)
        {
            db.DeleteContact(id);
        }
        public static void deleteAddress(int id)
        {
            db.DeleteAddress(id);
        }

        public static void editContact(Contact c)
        {
            db.EditContact(c);
        }


        public static void editAddess(Address a)
        {
            db.editAddress(a);
        }


    }
}