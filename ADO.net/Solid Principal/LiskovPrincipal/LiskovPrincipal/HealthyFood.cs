using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrincipal
{
    class HealthyFood
    {
        public virtual void GatherIngredient(string[] ingredient) { }
        public virtual void Cook() { }
    }

}
