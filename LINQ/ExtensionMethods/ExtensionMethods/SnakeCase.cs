using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
   public static class SnakeCase
    {
        public static string snake(this string s)
        {
            int len = s.Length;
            string str = "";
            
            for(int i = 0; i < len; i++)
            {
                if (s[i] == ' ')
                {
                    str = str + '_';
                }
                else
                {
                    str = str + (s[i]);
                }
                

            }
            return str;
        }
    }
}
