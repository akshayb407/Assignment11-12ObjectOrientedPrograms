using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ObjectOrientedPrograms
{
    public class Program
    {
        public static void Main()
        {
            CardsSimulation simulation = new CardsSimulation();
            simulation.DriverMethod();
        }

    }
}
