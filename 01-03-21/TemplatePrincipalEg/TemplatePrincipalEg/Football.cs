using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePrincipalEg
{
    class Football:Game
    {
        public override void initialize()
        {
            Console.WriteLine("Initialize Football Game");
        }
        public override void startPlay()
        {
            Console.WriteLine("Start Playing Football");
        }
        public override void endPlay()
        {
            Console.WriteLine("End Playing Football");
        }
    }
}
