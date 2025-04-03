using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class VehicleFactory : ICarFactory
    {
        public Vehicle CreateVehicle()
        {
            return new Vehicle { Class = "Sedan", Color = "Red", WheelDrive = "Front" };
        }

        public Cargo CreateCargo()
        {
            return null;
        }

        public Tank CreateTank()
        {
            return null;
        }
    }
}
