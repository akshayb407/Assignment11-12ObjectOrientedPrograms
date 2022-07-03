using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ObjectOrientedPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 0 for InventoryManagement\n");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 0:
                    InventoryManagement.DiverMethod();
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }

        }
    }
}
