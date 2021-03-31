using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class Animal
    {
        SpeakBehaviour _behavior;
        public Animal(SpeakBehaviour behaviour)
        {
            this._behavior = behaviour;
        }
        public string ASpeaK
        {
            get=> this._behavior.Speak();
        }

    }
}
