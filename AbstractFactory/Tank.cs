using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Tank : Car
    {
        public double ProjectileCaliber { get; set; }
        public int ShotsPerMinute { get; set; }
        public int CrewSize { get; set; }

        public override void ShowInfo()
        {
            Console.WriteLine($"Tank: Caliber {ProjectileCaliber}, Shots/min: {ShotsPerMinute}, Crew: {CrewSize}");
        }
    }
}
