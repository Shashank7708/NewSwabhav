using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqtoFIle
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"C:\Windows\System32";

            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(folderPath);

            IEnumerable<System.IO.FileInfo> fileList = dir.GetFiles("*.*", System.IO.SearchOption.TopDirectoryOnly);

          var orderbysize=  fileList.OrderBy(x => x.Length);

           
            foreach (var i in orderbysize)
            {
                Console.WriteLine(i.FullName);
            }
            var top3 = fileList.OrderByDescending(x => x.Length).Take(3);
            Console.WriteLine("Top 3 Files");
            foreach (var i in top3)
            {
                Console.WriteLine(i.FullName);
            }

            Console.WriteLine("Biggest Directory:");
            var top3dir = fileList.OrderByDescending(x => x.Directory.Name).First();
            
            Console.WriteLine(top3dir.Name+":Top Directory" +top3dir.Directory);
            Console.ReadLine();
        }
    }
}
