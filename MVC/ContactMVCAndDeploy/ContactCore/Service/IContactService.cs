using ContactCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactCore.Service
{
   public interface IContactService
    {
        List<Contact> contacts();
        void insertContact(Contact c);

        void deleteContct(int id);
        void editContact(Contact c);


    }
}
