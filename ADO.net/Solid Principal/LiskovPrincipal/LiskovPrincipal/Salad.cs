using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrincipal
{
    class Salad:HealthyFood
    {
        public override void GatherIngredient(string[] ingredient)
        {
            List<string> ingredient1 = ingredient.ToList();
            ingredient1.Add("Oliveoil");
            ingredient1.Add("salt");
        }
        public override void Cook()
        {
            
        }
    }
}
