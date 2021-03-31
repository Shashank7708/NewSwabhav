using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactDb
{
    interface IContactRepository
    {
        List<Contact> GetContact();
        List<Contact> SearchContact(string name);
        bool AddContact(Contact c);
        bool EditContact(int choice, int id, string Modification);
       bool DeleteContact(int id);

    }
}
