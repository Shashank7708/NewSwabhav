using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactDb
{
    class Program
    {

        private const int ADD = 1;
        const int MODIFY = 2;
        const int SEARCHCONTACT = 3;
        const int DELETE = 4;
        const int EXIT = 5;

        

        public static SwabhavDbContext db = new SwabhavDbContext();
      public static  IContactRepository contactRepo = new ContactEFRepository(db);

        static void Main(string[] args)
        {
            Showlist();
            int choice = 0;
            try
            {
                while (choice != 5)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Select:");
                    Console.WriteLine("1.ADD 2.MODIFY 3.SEARCH(Based On Name) 4.DELETE 5.EXIT");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case ADD:
                            addContact();
                            break;
                        case MODIFY:
                            modifyContact();
                            
                            break;
                        case SEARCHCONTACT:
                            Search();
                            break;
                        case DELETE:
                            Delete();
                            break;
                        case EXIT:break;

                    }
                    if (choice == 5) { break; }

                }
                Console.WriteLine("Successfully Exited!");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Success");
            Console.ReadLine();
        }


        public static void Showlist()
        {
            List<Contact> contacts = contactRepo.GetContact();
            foreach(var c in contacts)
            {
                Console.WriteLine($"{c.Id,4} {c.FirstName,10} {c.LastName,10} {c.PhoneNo,10}");
            }
        }

        public static void addContact()
        {
            Console.WriteLine("Add: ");
            Console.Write("FirstName: ");
            string firstname = Console.ReadLine();
            Console.Write("LastName: ");
            string lastName = Console.ReadLine();
            bool sizenotequalto10 = true;
            int phoneno=0;
            while (sizenotequalto10 ==true) 
            {
                Console.Write("PhoneNo: ");
                phoneno =int.Parse(Console.ReadLine());
                if (phoneno.ToString().Length == 9)
                {
                    sizenotequalto10 = false;
                }
                else
                {
                    Console.WriteLine("Invalid Phone No");
                }
            }
            Contact c = new Contact { FirstName = firstname, LastName = lastName, PhoneNo = phoneno };
           
            contactRepo.AddContact(c);
            Console.WriteLine("------------Added Successfully------------");
            Showlist();

        }

        public static void modifyContact()
        {
            bool sizenotequalto10 = true;
            int phoneno = 0;

            const int FIRSTNAME = 1;
            const int LASTNAME = 2;
            const int PHONENO = 3;

            Console.Write("Enter Your Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            List<Contact> comtactlist = contactRepo.GetContact();
            bool contact = db.contacts.Any(x=>x.Id==id);
            if (!contact)
            {
                Console.WriteLine("----Invalid-ID-------");
                return;

            }


            Console.WriteLine("SELECT EDIT:");
            Console.WriteLine("1.FIRST-NAME 2.LAST-NAME 3.PHONENO");
            int choice = Convert.ToInt32(Console.ReadLine());
           
            if (choice == FIRSTNAME) { Console.Write("New First-Name: "); }
            else if (choice == LASTNAME) { Console.Write("New Last-Name: "); }
            
            else if(choice==PHONENO) {
                while (sizenotequalto10 == true)
                {
                    Console.Write("New-PhoneNo: ");
                    phoneno = int.Parse(Console.ReadLine());
                    if (phoneno.ToString().Length == 9)
                    {
                        
                        contactRepo.EditContact(id, choice, phoneno.ToString());
                        Showlist();
                        return;
                        
                    }
                    else
                    {
                        Console.WriteLine("Invalid Phone No");
                    }
                }
            }
            else { Console.Write("Invalid-Choice ");return; }

            string name = Console.ReadLine();
           bool success= contactRepo.EditContact(id, choice, name);
            IsSuccessFull(success);
            Showlist();
           

        }

        public static void IsSuccessFull(bool success)
        {
            if (success == true)
            {
                Console.WriteLine("---------Transaction Successfully----------------");
            }
            else
            {
                Console.WriteLine("----------Error-------------");
            }
        }


        public static void Delete()
        { Console.WriteLine("TO Confirm:");
            Console.Write("Id: ");
            int lastname =int.Parse(Console.ReadLine());
           bool success= contactRepo.DeleteContact(lastname);
            IsSuccessFull(success);
            Showlist();
           
        }
        public static void Search()
        {
            Console.Write("Name:");
            string name = Console.ReadLine();
            List<Contact> contacts = contactRepo.SearchContact(name);
            if (contacts.Count == 0)
            {
                Console.WriteLine("Invalid Name");
            }
            else
            {
                foreach(var c in contacts)
                {
                    Console.WriteLine($"{c.Id,4} {c.FirstName,10} {c.LastName,10} {c.PhoneNo,10}");
                }
            }
        }
    }
}
