using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PostAbdCategory
{
   public class Category
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<Post> Post { get; set; } = new List<Post>();

    }
}
