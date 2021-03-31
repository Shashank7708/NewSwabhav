
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowForm
{ public delegate void DelegateFun(string name);
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            Case1();
            Console.Read();
            
            
        }
        public static void Case1()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);
           
            Form1 f1 = new Form1();
            f1.Load += log1;
            f1.Load += Case2;
            f1.Load += Case3;

            
            Application.Run(f1);

        }
        public static void log1(object sender,EventArgs e)
        {
            Console.WriteLine("inside Named FUnction");
            string a = "Hello!I am a Bot";
            File.WriteAllText(@"C:\NewSwabhav\Delegate\Form.txt", a);
           
        }

        public static void MessageWizard(DelegateFun fn)
        {
            fn("Rahul");
        }
        public static void Case2(object sender, EventArgs e)
        {

            MessageWizard(delegate (string name)
            {
                Console.WriteLine("Inside Anonymous Function");
                Console.WriteLine("Name:" + name);
            });
        }
        public static void Case3(object sender, EventArgs e)
        {
            MessageWizard((n) =>
            {
                Console.WriteLine("Hello Inside Lamda Function");
                Console.WriteLine("Name:" + n);
            }
            );
        }
        
    }
}
