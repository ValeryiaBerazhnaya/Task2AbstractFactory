using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class CargoFactory : ICarFactory
    {
        public Vehicle CreateVehicle() => null;

        public Cargo CreateCargo()
        {
            return new Cargo { Tonnage = 5000, TankVolume = 200, AxlesAmount = 6 };
        }

        public Tank CreateTank() => null;
    }
}
