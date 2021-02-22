using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class DogSpeakingBehaviour:SpeakBehaviour
    {
        public override string Speak()
        {
            return "Woof Woof";
        }

    }
}
