using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePrincipalEg
{
    class Cricket:Game
    {
      public override void initialize()
        {
            Console.WriteLine("Initialize cricket Game");
        }
        public override void startPlay()
        {
            Console.WriteLine("Start Playing Cricket");
        }
        public override void endPlay()
        {
            Console.WriteLine("End Playing Cricket");
        }
    }
}
