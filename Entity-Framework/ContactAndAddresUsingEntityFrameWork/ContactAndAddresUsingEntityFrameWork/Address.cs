using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactAndAddresUsingEntityFrameWork
{
    class Address
    {
        public int Id { get; set; }
        public string state { get; set; }
        public string City { get; set; }
        public int Pincode { get; set; }
        public virtual Contact Contact { get; set; }


    }
}
