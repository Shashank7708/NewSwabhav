using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLParserUsingComposition
{
    class Program
    {
        static void Main(string[] args)
        {
           ControlGroup html = new ControlGroup("html");
            ControlGroup body = new ControlGroup("body");
            ControlGroup div = new ControlGroup("div");

            html.AddControl(body);
            body.AddControl(div);

            div.AddControl(new Control("input", "text", "username"));
            div.AddControl(new Control("br"));


            StringBuilder sb = html.ParseHtml();
            CreateHtmlFile(sb);
            Console.Read();

        }

        static void CreateHtmlFile(StringBuilder sb)
        {
            try
            {
                File.WriteAllText(@"C:\NewSwabhav\CreatedHtmlUsingConsole.html", sb.ToString());
                Console.WriteLine("File Created");
                string[] readfile = File.ReadAllLines(@"C:\NewSwabhav\CreatedHtmlUsingConsole.html");
                foreach(string i in readfile)
                {
                    Console.WriteLine(i);
                }
            }
            catch(Exception e) { }
        }
    }
}
