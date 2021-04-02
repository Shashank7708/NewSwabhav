using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void deletePerson(int id)
        {
            SwabhavDbContext1 db = new SwabhavDbContext1();
            var li = db.persons.SingleOrDefault(x => x.id == 7);
            db.persons.Remove(li);
            db.SaveChanges();
        }

        public IEnumerable<Person> GetPerson()
        {
            List<Person> li = new List<Person>();
            SwabhavDbContext1 db = new SwabhavDbContext1();
            li = db.persons.ToList();
            return li;
        }

        public void insertPerson(Person p1)
        {
            var p = new Person { id = 2, name = "Sharon", address = "Mumbai" };
            SwabhavDbContext1 db = new SwabhavDbContext1();
            db.persons.Add(p1);
            db.SaveChanges();

        }

        public void updateperson(Person p1)
        {
            SwabhavDbContext1 db = new SwabhavDbContext1();
            var c = (from per in db.persons
                     where per.id == p1.id
                     select per).First();
            c.name = p1.name;
            c.address = p1.address;
            db.SaveChanges();

        }
    }

}
