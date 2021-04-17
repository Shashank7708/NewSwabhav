using ChainOfResponsibilityPattern.Interface;
using ChainOfResponsibilityPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IChain add = new Add();
            IChain subtract = new Subtract();
            IChain multiply = new Multiply();
            IChain division = new Division();
            add.SetNextChain(subtract);
            subtract.SetNextChain(multiply);
            multiply.SetNextChain(division);

            Numbers numbers = new Numbers(4,2,"subtraction");
            var result=add.Calculate(numbers);
            if (result != (-0.00))
            {
                Console.WriteLine($"Number1: {numbers.Number1}\nNumber2: {numbers.Number2}\nResult: {result}");
            }
            else
            {
                Console.WriteLine("Invalid operation");
            }
            Console.ReadLine();
        }
    }
}
