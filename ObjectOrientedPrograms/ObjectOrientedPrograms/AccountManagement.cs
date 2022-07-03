using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ObjectOrientedPrograms
{
    internal class AccountManagement
    {
        private static string path = @"H:\Accounts.json";
        public static void DriverMethod()
        {
            AccountManagement ac = new AccountManagement();
            Console.WriteLine("Welcome to Stock Accounts\n" +
                "Enter 1 to dispaly account report\n" +
                "Enter 2 to remove an account\n" +
                "Enter 3 to Add a New account");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Enter Name: ");
                    ac.AcReport(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Enter Name: ");
                    ac.Remove(Console.ReadLine());
                    break;
                case 3:
                    ac.Add();
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }

        public void Add()
        {
            string jfile = File.ReadAllText(path);

            List<StockAccount> ls;
            if (jfile.Length < 1)
            {
                ls = new List<StockAccount>();
            }
            else
            {
                ls = JsonConvert.DeserializeObject<List<StockAccount>>(jfile);
            }

            Console.WriteLine("enter the Name: ");
            StockAccount ac = new StockAccount();
            ac.Fill(Console.ReadLine());

            ls.Add(ac);

            string serial = JsonConvert.SerializeObject(ls);
            File.WriteAllText(path, serial);
            Console.WriteLine("done");

            using (StreamWriter stream = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(stream, ls);
            }

            Console.WriteLine("Successfully added");
        }
        public void Remove(string name)
        {
            string jfile = File.ReadAllText(path);

            List<StockAccount> ls;
            if (jfile.Length < 1)
            {
                ls = new List<StockAccount>();
            }
            else
            {
                ls = JsonConvert.DeserializeObject<List<StockAccount>>(jfile);
            }

            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].Name.Equals(name))
                {
                    ls.Remove(ls[i]);
                    break;
                }
            }

            using (StreamWriter stream = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(stream, ls);
            }

            Console.WriteLine("removed successfully");
        }
        public void AcReport(string name)
        {
            string jfile = File.ReadAllText(path);

            List<StockAccount> ls;
            if (jfile.Length < 1)
            {
                ls = new List<StockAccount>();
            }
            else
            {
                ls = JsonConvert.DeserializeObject<List<StockAccount>>(jfile);
            }

            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].Name.Equals(name))
                {
                    ls[i].PrintReport();
                    break;
                }
            }
        }
    }
}
