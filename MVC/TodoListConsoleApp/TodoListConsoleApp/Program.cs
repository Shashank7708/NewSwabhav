using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListConsoleApp
{
    class Program
    {
       static List<ToDoList> todolist = new List<ToDoList>();
      static  int count = 0;

        static void Main(string[] args)
        { int choice = 0;

            while (choice != 5)
            {

                Console.WriteLine("Select:");
                Console.WriteLine("1.Add 2.Delete 3.Update 4.Show To-Do-List");
                 choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        add();
                        break;
                    case 2:
                        Delete();
                        break;
                    case 3:
                        Edit();
                        break;
                    case 4:SHowList();break;
                    case 5:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
                if (choice == 5) { break; }
            }
            Console.ReadLine();

        }


        public static void add()
        {
            Console.Write("Enter TaskName: ");
            string task1 = Console.ReadLine();
            Console.Write("Enter Date: ");
            string date1 = Console.ReadLine();
            Console.Write("Enter Status: ");
            string status1 = Console.ReadLine();
            ToDoList t = new ToDoList { id = count++, task = task1, date = date1, done = status1 };
            todolist.Add(t);

        }
       
    public static void SHowList()
           {
            foreach(var i in todolist)
            {
                Console.WriteLine($"{i.id,3} {i.task} {i.date} {i.done}");
            }
           }
    
        public static void Delete()
        { 
            Console.WriteLine("Enter id : ");
            int id = int.Parse(Console.ReadLine());
            ToDoList e = new ToDoList();
            foreach (var i in todolist)
            {
                if (i.id == id)
                {
                    e = i;
                }
            }
            todolist.Remove(e);

        }

        public static void Edit()
        { Console.WriteLine("ENter your id:");
            int id =int.Parse( Console.ReadLine());
            Console.WriteLine("Select: ");
            Console.WriteLine("1.Date 2.Status");
            string g="a";
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:Console.WriteLine("Enter new Date");
                     g = Console.ReadLine();
                    break;
                case 2:Console.WriteLine("Enter status");
                     g = Console.ReadLine();
                    break;
                    
            }
            foreach(var i in todolist)
            {
                if (i.id == id)
                {
                    if (choice == 1) { i.date = g; }
                    else { i.done = g; }
                }
                
            }
        }




    }






    
    }
