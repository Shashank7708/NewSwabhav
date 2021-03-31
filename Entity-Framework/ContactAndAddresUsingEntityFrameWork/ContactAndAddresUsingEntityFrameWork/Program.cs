using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactAndAddresUsingEntityFrameWork
{
    class Program
    {
        const int ADD = 1;
        const int DELETECONTACT = 2;
        const int DELETEADDRESS = 3;
        const int EDITCONTACT = 4;
        const int GetAContact = 5;
        const int ADRESSOFPARTICULARPERSON = 6;
        const int EXIT = 7; 
      
        



        public static SwabhavDbContext3 db = new SwabhavDbContext3();
       public static ContactAndAddressRepo contactrepo = new ContactAndAddressRepo();
        static void Main(string[] args)
        {
            /*
            Contact contact = new Contact { Id = 1, FirstName = "Romy", LastName = "Rajan", contactNo = 98927396 };
            Address address = new Address { Id = 1, state = "Maharashtra", City = "Vasai", Pincode = 401208 };

            address.Contact = contact;
            contact.Addresseslist.Add(address);

            db.contact.Add(contact);
            db.SaveChanges();
            */

            ShowContactList();
            ShowAddressList();
            int choice = 0;
            while (choice != 5)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Select:");
                    Console.WriteLine("1.ADD 2.DELETECONTACT 3.DELETEADDRESS 4.EditContact 5.GetContact-Detail 6.GetAddrees-Details 7.EXIT");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                    case ADD:
                        insert();
                        break;
                    case DELETECONTACT:
                        deleteContact();
                        break;
                    case DELETEADDRESS :
                        deleteAddress();
                        break;
                    
                    case EDITCONTACT:
                        modifyContact();
                        break;
                    case GetAContact:
                        GetContact();
                        break;
                    case ADRESSOFPARTICULARPERSON:
                        GetAddressOfParticularContact();
                        break;
                    case EXIT:
                        break;
                    default:
                        Console.WriteLine("----Invalid Choice----");
                        break;
                }
            
                }
            Console.WriteLine("SUCCESSFULLY EXITED");
            Console.ReadLine();
        }

        public static void ShowContactList()
        {
            Console.WriteLine("\n---------CONTACT LIST--------------");
            List<Contact> contactList = contactrepo.contactList();
            foreach(Contact i in contactList)
            {
                Console.WriteLine($"{i.Id,2}{i.FirstName} {i.LastName} {i.contactNo}");
            }

        }
        public static void ShowAddressList()
        {
            Console.WriteLine("\n---------ADDRESS LIST--------------");
            List<Address> addresslist = contactrepo.addressList();
            Console.WriteLine();
            foreach(Address i in addresslist)
            {
                Console.WriteLine($"{i.Contact.Id,3}{i.state,10} {i.City,10} {i.Pincode,10}");
            }
        }

        public static void GetContact()
        {
            Console.WriteLine("Search:");
            Console.Write("First-Name: ");
            string name = Console.ReadLine();
           List<Contact> contacts= contactrepo.search(name);
            foreach(var i in contacts)
            {
                Console.WriteLine($"{i.Id,3} {i.FirstName,15} {i.LastName,15} {i.contactNo,11}");
            }

        }
        public static void GetAddressOfParticularContact()
        {
            Console.WriteLine("Search:");
            Console.Write("First-Name: ");
            string name = Console.ReadLine();
            List<Address> addresses = contactrepo.SearchAddress(name);
            foreach (var i in addresses)
            {
                Console.WriteLine($"{i.Id,3} {i.state,12} {i.City,12} {i.Pincode,8} {i.Contact.FirstName,10}");
            }

        }

        public static void insert()
        { Console.WriteLine("ADD");
            Console.Write("First-Name: ");
            string firstname = Console.ReadLine();
            Console.Write("Last-Name: ");
            string lastname = Console.ReadLine();
            

            bool sizenotequalto10 = true;
            int phoneno = 0;
            while (sizenotequalto10 == true)
            {
                Console.Write("PhoneNo: ");
                phoneno = int.Parse(Console.ReadLine());
                if (phoneno.ToString().Length == 9 || phoneno.ToString().Length==6)
                {
                    sizenotequalto10 = false;
                }
                else
                {
                    Console.WriteLine("Invalid Phone No");
                }
            }

            Contact contact = new Contact { FirstName = firstname, LastName = lastname, contactNo = phoneno };
            List<Address> addresslist = new List<Address>();
            int add;
            int a = 0;
            do
            {
                if (a == 0)
                {
                    Console.WriteLine("Address: ");
                }
                else
                {
                    Console.WriteLine("ALternate Address:");
                }
                Console.Write("State: ");
                string state = Console.ReadLine();
                Console.Write("City:");
                string city = Console.ReadLine();
                Console.Write("Pincode: ");



                int pincode = int.Parse(Console.ReadLine());
                Address address = new Address { state = state, City = city, Pincode = pincode };
                address.Contact = contact;
                contact.Addresseslist.Add(address);
                addresslist.Add(address);
                Console.WriteLine("\nPress '1' to add Alternate Address:");
                add = int.Parse(Console.ReadLine());
                a++;

            } while (add == 1);

            contactrepo.insert(contact);
            Console.WriteLine("Added Successully!");
        }

        static   int commonDeleteMethod()
        {
            Console.Write("Enter Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("To Verify:");
            Console.Write("Enter First-Name: ");
            string firstname = Console.ReadLine();
            foreach (var i in contactrepo.addressList())
            {
                if (i.Contact.FirstName.ToLower().Equals(firstname.ToLower())&& i.Id==id)

                    break;
                else
                {
                    Console.WriteLine("OOPS:Wrong Name\n Please Come Again:");
                    return 0;
                }
            }
            return id;
        }

       
        public static void deleteContact()
        {

            Console.Write("Enter Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("To Verify:");
            Console.Write("Enter First-Name: ");
            string firstname = Console.ReadLine();
            foreach (var i in contactrepo.contactList())
            {
                if (i.FirstName.ToLower().Equals(firstname.ToLower()) && i.Id == id)

                    break;
                else
                {
                    Console.WriteLine("OOPS:Wrong Name\n Please Come Again:");
                    
                }
            }
            contactrepo.DeleteContact(id);
            Console.WriteLine("DELETED SUCCESSFULLY!");
        }

        public static void deleteAddress()
        {

            Console.Write("Enter Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("To Verify:");
            Console.Write("Enter First-Name: ");
            string firstname = Console.ReadLine();
            foreach (var i in contactrepo.addressList())
            {
                if (i.Contact.FirstName.ToLower().Equals(firstname.ToLower()) && i.Id == id)

                    break;
                else
                {
                    Console.WriteLine("OOPS:Wrong Name\n Please Come Again:");

                }
            }
            contactrepo.DeleteContact(id);
            Console.WriteLine("DELETED SUCCESSFULLY!");
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
            List<Contact> comtactlist = contactrepo.contactList();
            bool contact = db.contact.Any(x => x.Id == id);
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

            else if (choice == PHONENO)
            {
                while (sizenotequalto10 == true)
                {
                    Console.Write("New-PhoneNo: ");
                    phoneno = int.Parse(Console.ReadLine());
                    if (phoneno.ToString().Length == 9)
                    {

                        contactrepo.EditContact(id, choice, phoneno.ToString());
                        ShowContactList();
                        return;

                    }
                    else
                    {
                        Console.WriteLine("Invalid Phone No");
                    }
                }
            }
            else { Console.Write("Invalid-Choice "); return; }

            string name = Console.ReadLine();
            bool success = contactrepo.EditContact(id, choice, name);
            IsSuccessFull(success);
            ShowContactList();


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
    }
}
