using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustAndOrderAndLineItem
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var session = Helper16.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {   
                   /* var customer = new Customer { name = "Romy", address = "Andheri" };
                    var order = new Order { };
                    var lineitem = new LineItem { Itemname = "Maggi", PerCost = 150, quantity = 2 };

                    lineitem.Order=order;

                    if (order is Order)
                    {
                        order.LineItem.Add(lineitem);
                    }
                    order.Customer = customer;
                    customer.Order.Add(order);
                    session.Save(lineitem);
                    session.Save(order);

                    session.Save(customer);

                    
                    var orders = session.CreateCriteria<Order>().List<Order>();
                    foreach(var i in orders)
                    {
                        Console.WriteLine($"{i.Oid} {i.LineItem.Count} {i.Customer.name}");
                    }
                    
                    var custoer1 = new Customer { name = "Romy", address = "Vasai" };
                    var customer0 = new Customer { name = "Sharon", address = "Mumbai" };
                    var customer2 = new Customer { name = "Chinmay", address = "Vasai" };
                    var customer3 = new Customer { name = "Shehan", address = "Mumbai" };

                    var maggi = new LineItem { Itemname = "Maggi", PerCost = 150, quantity = 3 };
                    var Iphone = new LineItem { Itemname = "Iphone", PerCost = 40000, quantity = 1 };
                    var Ipad = new LineItem { Itemname = "Ipad", PerCost = 15000, quantity = 1 };
                    var Laptop = new LineItem { Itemname = "Laptop", PerCost = 30000, quantity = 1 };
                    var Earphone = new LineItem { Itemname = "Earphone", PerCost =600, quantity = 2 };

                    
                    var order2 = new Order { };
                    var order3 = new Order { };

                    maggi.Order=order2;
                    Iphone.Order=order2;
                    Ipad.Order=order3;
                    Laptop.Order=order3;
                    Earphone.Order=order3;

                    order2.LineItem.Add(maggi);
                    order2.LineItem.Add(Iphone);
                    order3.LineItem.Add(Ipad);
                    order3.LineItem.Add(Laptop);
                    order3.LineItem.Add(Earphone);

                    order2.Customer = customer2;
                    order3.Customer = customer3;

                    customer2.Order.Add( order2);
                    customer2.Order.Add( order3);

                    session.Save(maggi);
                    session.Save(Iphone);
                    session.Save(Ipad);
                    session.Save(Laptop);
                    session.Save(Earphone);

                    session.Save(order2);
                    session.Save(order3);

                    session.Save(customer0);
                    session.Save(customer2);
                    session.Save(customer3);
                    
                    //  var customer = session.Get<Customer>(1);
                    // session.Delete(customer);
                   */
                  Queries();
                   
                    Console.WriteLine("DOne");

                }
            }
            Console.ReadLine();
        }

        public static void Queries()
        {
            using (var session = Helper16.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Console.WriteLine("All Customer:");
                    var customerlist = session.CreateCriteria<Customer>().List<Customer>();
                    foreach(var i in customerlist)
                    {
                        Console.WriteLine($"{i.id,4} {i.name,10} {i.address,10}");
                    };

                    var lineitem = from i in session.CreateCriteria<LineItem>().List<LineItem>()
                                   orderby i.Itemname,i.PerCost descending
                                   select new { i.itemid,i.Itemname,i.PerCost,i.quantity};
                    Console.WriteLine("Order BY Name:");
                    foreach(var i in lineitem)
                    {
                        Console.WriteLine($"{i.itemid,3} {i.Itemname,10} {i.PerCost,10} {i.quantity,10}");
                    }
                    var orderlist = from i in session.CreateCriteria<Order>().List<Order>()
                                    select new { i.Oid };
                    Console.WriteLine("Group by Quantity"); 
                    var list1 = (from i in session.CreateCriteria<LineItem>().List<LineItem>()
                               group i by i.quantity) ;
                    foreach(var i in list1 )
                    {
                        Console.WriteLine($"{i.Key} {i.Count()}");
                    }
                    var sumOfAllItem = session.QueryOver<LineItem>().List<LineItem>().Sum((x => x.PerCost));
                    Console.WriteLine($"Sum: {sumOfAllItem}");
                    var countcustomer = session.QueryOver<Customer>().List<Customer>().Count();
                    Console.WriteLine("No Of Customer: {0}",countcustomer);
                    
                    transaction.Commit();
                }
            }
            Console.ReadLine();
        }

    }

}

