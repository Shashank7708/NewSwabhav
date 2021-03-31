using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernetEgContact
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            using (var session = NHibernatHelper.OpenSession())
            {
                using(var transaction = session.BeginTransaction())
                {
                    var contact = new Contact
                    {
                        FirstName = "Rahul",
                        LastName = "Shetye",
                        PhoneNo = 989273965
                    };
                    session.Save(contact);
                    transaction.Commit();
                    Console.WriteLine("Success");

                }
            }
            */
            //  insert("Romy", "Rajan",98913123);
            // insert("Rohan", "Singh",123145);
            //insert("Vishal", "Singh", 52535252);
            //insert("Rahul", "Shetye", 32522353);

            //  insert("Shehan", "Shetty", 233245);
            //   update();
            // Delete();
            using (var session = NHibernatHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var contacts = session.Query<Contact>().Where(x => x.Id == 1).Where(x=>x.FirstName=="Vishal").ToList();
                    foreach(var i in contacts)
                    {
                        Console.WriteLine($"{i.Id} {i.FirstName} {i.LastName} {i.PhoneNo}");
                    }
                }
            }
            Console.WriteLine("Success");

                    Console.ReadLine();
        }

        public static void insert(string firstname,string lastname,int mobileno)
        {
            using (var session = NHibernatHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var contact = new Contact
                    {
                        FirstName = firstname,
                        LastName = lastname,
                        PhoneNo = mobileno
                    };
                    session.Save(contact);
                    transaction.Commit();
                    Console.WriteLine("Success");

                }
            }

        }

        public static void update()
        {

            using (var session = NHibernatHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var contactlst = session.QueryOver<Contact>().List<Contact>();
                    Contact contact = new Contact(); ;
                    foreach(var c in contactlst)
                    {
                        if (c.Id == 2)
                        {
                            c.FirstName = "Dummy";
                            contact = c;
                        }
                    }
                    session.SaveOrUpdate(contact);
                    transaction.Commit();
                    Console.WriteLine("Success");

                }
            }
        }

        public static void Delete()
        {
            using (var session = NHibernatHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var contactlst = session.QueryOver<Contact>().List<Contact>();
                    Contact contact = new Contact(); ;
                    foreach (var c in contactlst)
                    {
                        if (c.Id == 2)
                        {
                            
                            contact = c;
                        }
                    }
                    session.Delete(contact);
                    transaction.Commit();
                    Console.WriteLine("Success");

                }

            }
    }}
}
