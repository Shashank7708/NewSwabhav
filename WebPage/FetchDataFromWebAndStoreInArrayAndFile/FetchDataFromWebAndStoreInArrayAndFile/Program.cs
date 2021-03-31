using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace FetchDataFromWebAndStoreInArrayAndFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new WebClient();
            string text = client.DownloadString(@"https://swabhav-tech.firebaseapp.com/emp.txt");
            string[,] arrayofstring = new string[25, 10];
            int i = 0;
            int size = 0;
            
            while (size != text.Length)
            {
                StringBuilder b=new StringBuilder();
                
                while (text[size] != '\n')
                {
                    b.Append(text[size++]);

                }
               
                Console.WriteLine(b.ToString()+"\t"+size);
                


                 string[] temp= b.ToString().Split(',');

                
                    for(int temp2 = 0; temp2 < temp.Length; temp2++)
                    {
                    Console.WriteLine(temp[temp2]);
                        arrayofstring[i, temp2] = temp[temp2];
                    
                     }i++;
               
            }
            for(int q = 0; q < 23; q++)
            {
                for(int w = 0; w < 10; w++)
                {
                    Console.Write(arrayofstring[q,w]);
                }Console.WriteLine();
            }

            Console.Read();
        }
    }
}
