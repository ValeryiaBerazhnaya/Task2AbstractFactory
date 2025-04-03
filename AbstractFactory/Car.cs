using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class Car
    {
        public double Weight { get; set; }
        public double Length { get; set; }
        public double MaxSpeed { get; set; }

        public abstract void ShowInfo();
    }
}
