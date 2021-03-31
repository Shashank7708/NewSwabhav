using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {   //I have created an abstract Class SpeakBehaviour which is inherited by Cat and DOg
            //Override speak Behavour
            //Thenn Created new class Animal and in constructure send innherit class and assign it to SpeakBehavour 
            //instance Variable
            Animal cat = new Animal(new DogSpeakingBehaviour());
            Animal dog = new Animal(new CatSpeakingBehaviour());

            Console.WriteLine(cat.ASpeaK);                       //meow meow
            Console.WriteLine(dog.ASpeaK);                       //woof woof
            Console.ReadLine();

        }
    }
}
