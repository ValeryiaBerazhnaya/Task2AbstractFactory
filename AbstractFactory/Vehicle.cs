using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Vehicle : Car
    {
        public string WheelDrive { get; set; }
        public string Class { get; set; }
        public string Color { get; set; }

        public override void ShowInfo()
        {
            Console.WriteLine($"Vehicle: {Class}, Color: {Color}, Drive: {WheelDrive}");
        }
    }
}
