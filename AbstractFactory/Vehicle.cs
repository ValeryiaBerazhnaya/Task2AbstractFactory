using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Vehicle : Car
    {
        public string? WheelDrive { get; set; }
        public string? Class { get; set; }
        public string? Color { get; set; }
    }
}
