using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactAndAddresNhibernate
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var session = Helper16.OpenSession())
            {
                using(var transaction = session.BeginTransaction())
                {     /*
                    var contact = new Contact { FirstName = "Rahul", LastName = "Shetye", PhoneNo = 989273965 };
                    var address = new Address { City = "Mumbai", pincode = 401204 };
                    address.Contact = contact;
                    contact.Address.Add(address);

                    session.Save(address);
                    session.Save(contact);
                    
                    var contact2 = new Contact { FirstName = "Romy", LastName = "Rajan", PhoneNo =123456789 };
                    var address1 = new Address { City = "Mumbai", pincode = 401204 };
                    var address2 = new Address { City = "Nagpur", pincode = 402102 };
                    address1.Contact = contact2;
                    address2.Contact = contact2;
                    contact2.Address.Add(address1);
                    contact2.Address.Add(address2);

                    session.Save(address);
                    session.Save(contact);
                    session.Save(address1);
                    session.Save(address2);
                    session.Save(contact2);
                    */
                    /*
                    var deletecontact = session.Get<Contact>(2);
                    session.Delete(deletecontact);
                    */

                    Console.WriteLine("COntact And Address Table Created using NHibernate ");

                    transaction.Commit();
                        Console.WriteLine("Table Created");

                }
            }
            Console.ReadLine();
        }
    }
}
