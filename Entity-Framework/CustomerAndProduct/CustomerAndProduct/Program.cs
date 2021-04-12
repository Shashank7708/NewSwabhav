using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAndProduct
{
    class Program
    { public static SwabhavDbContext1 db = new SwabhavDbContext1();
        static void Main(string[] args)
        {
            // Create();
            //Update();
            // Delete();
            //Print Sum of All Product Cost
            var allproductcost =db.products.Sum(x=>x.productCost);
            Console.WriteLine("AllProduct Cost:"+allproductcost);



            Console.WriteLine("\nJoin:");
            //Join
            var product = from i in db.products
                          join j in db.customers on i.customer.customerid equals j.customerid
                          select new { i.pid, i.productName, j.customerid, j.customerName };
            foreach(var i in product)
            {
                Console.WriteLine($"{i.pid} {i.productName} {i.customerName} {i.customerid}");
            }


            //OrderBy
            Console.WriteLine("\nOrderBy Clause:");
            var arrangeproductOnName = from i in db.products
                                 orderby i.productName
                                 select new {i.pid,i.productName,i.productCost,i.customer };
            foreach (var i in arrangeproductOnName)
            {
                Console.WriteLine($"{i.pid} {i.productName} {i.productCost} {i.customer.customerid} {i.customer.customerName}");
            }

            // Console.WriteLine("\nFetch all Products of Customer1");
            //var customer1 = db.customers.Where(x => x.customerid == 1).Select(x=>x);
            Console.WriteLine("\nGet all Product where id greater than 2:");
           // var prouct = db.products.Where(x => x.pid > 2).Select(x=>new {x.pid,x.productName }).ToList();
            var x1 = from i in db.products
                    where i.pid > 2
                    select new { i.pid, i.productName };
            foreach(var i in x1)
            {
                Console.WriteLine($"{i.pid} {i.productName}");
            }

            var countproduct = db.products.Count();
            Console.WriteLine("Total no of Product:" + countproduct);

              
            Console.WriteLine("success");
            Console.ReadLine();
        }

        private static void Delete()
        {
           foreach(var p in db.products)
            {
                if (p.productName.Equals("Tablet"))
                {
                    db.products.Remove(p);
                }
                
            }
            db.SaveChanges();

        }

        private static void Update()
        {
            var result = db.customers.SingleOrDefault(b => b.customerName.Equals("Rahul"));
            if (result != null)
            {
                result.customerName = "rahul";
            }
            

            db.SaveChanges();
        }

        private static void Create()
        {
          /*  Customer c1 = new Customer { customerid = 101, customerName = "Rahul", address = "vasai" };

            Product p1 = new Product { pid = 1, productName = "Tablet", productCost = 40000 };
            Product p2 = new Product { pid = 2, productName = "Iphone", productCost = 50000 };
            Product p3 = new Product { pid = 3, productName = "Android", productCost = 25000 };

            p1.customer = c1;
            p2.customer = c1;
            p3.customer = c1;

            c1.CustomerProduct.Add(p1);
            c1.CustomerProduct.Add(p2);
            c1.CustomerProduct.Add(p3);


            db.customers.Add(c1);
            */
          //Adding New Custoer to group by clause
            Customer c2 = new Customer { customerid = 102, customerName = "Romy", address = "vasai" };
            Product pc2 = new Product { pid = 4, productName = "BlackBerry", productCost = 20000 };
            pc2.customer = c2;
            c2.CustomerProduct.Add(pc2);
            db.customers.Add(c2);

            db.SaveChanges();
        }
    }
}
