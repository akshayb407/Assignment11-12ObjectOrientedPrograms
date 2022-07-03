using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace ObjectOrientedPrograms
{
    internal class StockAccount
    {
        public double Cash { get; set; }

        public string Name { get; set; }

        public int N { get; set; }

        public List<int> Shares { get; set; }

        public List<string> Stocks { get; set; }

        public List<int> StockPrice { get; set; }

        public DateTime Timing = DateTime.Now;

        public void Fill(string Name)
        {
            Console.WriteLine("Enter the Cash balance");
            this.Cash = double.Parse(Console.ReadLine());

            this.Name = Name;

            Console.WriteLine("Enter the number of Stocks purchased");
            this.N = int.Parse(Console.ReadLine());

            this.Shares = new List<int>();
            this.Stocks = new List<string>();
            this.StockPrice = new List<int>();

            for (int i = 0; i < this.N; i++)
            {
                Console.Write("enter the Name of Stock: ");
                this.Stocks.Add(Console.ReadLine());
                Console.Write("Enter the number of Shares: ");
                this.Shares.Add(int.Parse(Console.ReadLine()));
                Console.Write("Enter the Price/share: ");
                this.StockPrice.Add(this.Shares[i] * int.Parse(Console.ReadLine()));
            }
        }

        public double ValueOf()
        {
            double grandTotal = 0;

            for (int i = 0; i < this.N; i++)
            {
                grandTotal += this.StockPrice[i];
            }

            return grandTotal;
        }
        public void PrintReport()
        {
            Console.WriteLine("{0,-25}{1}", "Customer Name is:", this.Name);
            Console.WriteLine("{0,-25}{1}", "Account Balance is:", this.Cash);
            Console.Write("{0,-25}", "Account opened at:");
            Console.WriteLine("{0:d} {0:t}", this.Timing);
            for (int i = 0; i < this.N; i++)
            {
                Console.WriteLine("{0,-25}{1}", "stock symbol:", this.Stocks[i]);
                Console.WriteLine("{0,-25}{1}", "number of shares:", this.Shares[i]);
                Console.WriteLine("{0,-25}{1}", "total Price of stock is:", this.StockPrice[i]);
            }
        }
    }
}