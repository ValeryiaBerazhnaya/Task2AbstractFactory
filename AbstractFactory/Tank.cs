using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Tank : Car
    {
        public double ProjectileCaliber { get; set; }
        public int ShotsPerMinute { get; set; }
        public int CrewSize { get; set; }
    }
}
