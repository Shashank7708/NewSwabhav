using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernetEgContact
{
    class ContactMap: ClassMap<Contact>
    {
        public ContactMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.PhoneNo);
            
               
        }
    }
}
