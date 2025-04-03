using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Cargo : Car
    {
        public double Tonnage { get; set; }
        public double TankVolume { get; set; }
        public int AxlesAmount { get; set; }

        public override void ShowInfo()
        {
            Console.WriteLine($"Cargo: Tonnage {Tonnage}, Tank Volume: {TankVolume}, Axles: {AxlesAmount}");
        }
    }
}
