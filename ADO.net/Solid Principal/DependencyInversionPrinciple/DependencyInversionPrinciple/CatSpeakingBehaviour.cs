using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class CatSpeakingBehaviour:SpeakBehaviour
    {
        public override string Speak()
        {
            return "Meow Meow";
        }
    }
}
