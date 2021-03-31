using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopUpInWindowForm
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);
            Welcome wc = new Welcome();

            Application.Run(wc);
            Console.Read();


        }
    }
}
