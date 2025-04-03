using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class TankFactory : ICarFactory
    {
        public Vehicle CreateVehicle() => null;

        public Cargo CreateCargo() => null;

        public Tank CreateTank()
        {
            return new Tank { ProjectileCaliber = 120, ShotsPerMinute = 10, CrewSize = 4 };
        }
    }
}
