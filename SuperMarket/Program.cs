using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Employee details press 1 Item Details press 2");
            int Result = Convert.ToInt32(Console.ReadLine());
            Program program = new Program();

            if (Result == 1)
                program.Employee();
            else
                program.Item();

            Console.ReadKey();
        }
        public  void Employee()
        {
            Console.WriteLine(" Available Operation");
            Console.WriteLine("   1.  Add Employees");
            Console.WriteLine("   2.  Update Employees");
            Console.WriteLine("   3.  Delete Employees");
            Console.WriteLine("   4.  View Employees");

            bool Repeat = true;
            int Input;
            EmployeeManager Emp = new EmployeeManager();
            while (Repeat)
            {
                Console.WriteLine("Press any Key 1 To 4");
                Input = Convert.ToInt32(Console.ReadLine());
                switch (Input)
                {
                    case 1:
                        Emp.AddEmployee();
                        break;
                    case 2:
                        Emp.Update();
                        Emp.View();
                        break;
                    case 3:
                        Emp.Delete();
                        Emp.View();
                        break;
                    case 4:
                        Emp.View();
                        break;
                    default:
                        Console.WriteLine(" Please press 1 To 4");
                        break;

                }
                Console.WriteLine("Do you wnt to contiune if  yes press 1");
                int Loop = Convert.ToInt32(Console.ReadLine());
                if (Loop == 1)
                    Repeat = true;
                else
                    Repeat = false;


            }
           

        }
       public void Item()
        {
            Console.WriteLine(" Available Operation");
            Console.WriteLine("   1.  Add Item");
            Console.WriteLine("   2.  Update Item");
            Console.WriteLine("   3.  Delete Item");
            Console.WriteLine("   4.  View Item");

            bool Repeat = true;
            int Input;
            ItemManager Item = new ItemManager();
            while (Repeat)
            {
                Console.WriteLine("Press any Key 1 To 4");
                Input = Convert.ToInt32(Console.ReadLine());
                switch (Input)
                {
                    case 1:
                        Item.AddItem();
                        Item.ViewItem();
                        break;
                    case 2:
                        Item.UpdateItem();
                        Item.ViewItem();
                        break;
                    case 3:
                        Item.DeleteItem();
                        Item.ViewItem();
                        break;
                    case 4:
                        Item.ViewItem();
                        break;
                    default:
                        Console.WriteLine(" Please press 1 To 4");
                        break;

                }
                Console.WriteLine("Do you wnt to contiune if  yes press 1");
                int Loop = Convert.ToInt32(Console.ReadLine());
                if (Loop == 1)
                    Repeat = true;
                else
                    Repeat = false;


            }

        }
    }
}
