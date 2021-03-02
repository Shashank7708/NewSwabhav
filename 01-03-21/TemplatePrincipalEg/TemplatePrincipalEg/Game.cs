using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePrincipalEg
{
   abstract class Game
    {
        public abstract void initialize();
        public abstract void startPlay();
        public abstract void endPlay();

        //template method
        public void play()
        {   //iitialzie the game
            initialize();
            //start the game
            startPlay();
            //end the game
            endPlay();
        }
    }
}
