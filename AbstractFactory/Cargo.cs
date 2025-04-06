using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Cargo : Car
    {
        public double Tonnage { get; set; }
        public double TankVolume { get; set; }
        public int AxlesAmount { get; set; }
    }
}
