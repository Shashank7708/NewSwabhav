using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkUpdateDeleteInsert
{
    class Program
    {
      public static  DbEntities db = new DbEntities();
        static void Main(string[] args)
        {
            Add();
            Delete();
            Update();
            Console.WriteLine("Success");
            Console.ReadLine();
        }
        public static void Add()
        {
           // db.Customers.Add(new Customer { CustomerID = 101, FIrstName = "Rahul", LastName = "Shetye", City = "Mumbai", Address = "Palghar" });
           // db.Customers.Add(new Customer { CustomerID = 102, FIrstName = "Romy", LastName = "Daniel", City = "Vasai", Address = "Palghar" });
          //  db.Customers.Add(new Customer { CustomerID = 103, FIrstName = "Sharon", LastName = "Daniel", City = "Virar", Address = "Palghar" });
          //  db.SaveChanges();
        }
        public static void Delete()
        {
            foreach(var e in db.Customers)
            {
                if (e.FIrstName.Equals("Romy"))
                {
                    db.Customers.Remove(e);
                }
                else
                {
                    Console.WriteLine("Custoer id={0} and Name{1}", e.CustomerID, e.FIrstName);
                }
            }
            db.SaveChanges();
        }
        public static void Update()
        {
            var result = db.Customers.SingleOrDefault(b => b.CustomerID == 3);
            if (result != null)
            {
                result.FIrstName = "Romy";
            }
            db.SaveChanges();
        }
    }
}
