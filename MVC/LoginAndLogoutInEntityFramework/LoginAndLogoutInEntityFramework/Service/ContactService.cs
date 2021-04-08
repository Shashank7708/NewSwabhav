using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LoginAndLogoutInEntityFramework.Models;
using LoginAndLogoutInEntityFramework.Repository;

namespace LoginAndLogoutInEntityFramework.Service
{
    public class ContactService
    {
        static List<Contact> contactlist = new List<Contact>();
        static ContactRepo db = new ContactRepo();
        public static List<Contact> getContacts()
        {
          
            return db.GetContact();

        }

        public static void insert(Contact c)
        {
            ContactRepo.Insert(c);
        }

        public static void delete(Contact c)
        {
            db.delete(c);
        }


        public static void update(Contact c)
        {
            db.update(c);
        }

      public static void insertuser(Membership c)
        {
            db.insertUser(c);
        }

        public static List<Membership> members()
        {
           return db.getmembers();
        }


    }
}