using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXML
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement xelement = XElement.Load("C:\\NewSwabhav\\SQL\\Emp.xml");
            IEnumerable <XElement> employees = xelement.Elements();
            Console.WriteLine("Get First name and Jobs:");
            foreach (var employee in employees)
            {
                
                Console.Write(employee.Element("firstname").Value+":");
                Console.WriteLine(employee.Element("title").Value+"\n");
            }
            Console.Read();
        }
    }
}
