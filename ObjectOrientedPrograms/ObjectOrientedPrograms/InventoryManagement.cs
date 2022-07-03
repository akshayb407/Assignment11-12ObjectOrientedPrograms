using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ObjectOrientedPrograms
{
    internal class InventoryManagement
    {
        public static void DiverMethod()
        {
            Console.WriteLine("Welcome to Inventory MAnagement");
            InventoryImplementation imp = new InventoryImplementation();
            while (true)
            {
                Console.WriteLine("Enter A to Add\tEnter D to delete an Item");
                char entered = char.Parse(Console.ReadLine());
                switch (entered)
                {
                    case 'A':
                        imp.Add();
                        break;
                    case 'D':
                        imp.Delete();
                        break;
                    default:
                        Console.WriteLine("Enter a valid character");
                        break;
                }
                Console.WriteLine("enter yes/No to conitnue");
                if (Console.ReadLine() != "yes")
                {
                    break;
                }
            }
        }
    }
}
