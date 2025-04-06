using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public static class CarFactory
    {
        public static Vehicle CreateVehicle(string brand)
        {
            return brand switch
            {
                "Audi" => new Audi(),
                "Honda" => new Honda(),
                "Tesla" => new Tesla(),
                _ => throw new ArgumentException("Invalid vehicle brand")
            };
        }

        public static Cargo CreateCargo(string brand)
        {
            return brand switch
            {
                "Volvo" => new Volvo(),
                "Man" => new Man(),
                "Scania" => new Scania(),
                _ => throw new ArgumentException("Invalid cargo brand")
            };
        }

        public static Tank CreateTank(string brand)
        {
            return brand switch
            {
                "Abrams" => new Abrams(),
                "Merkava" => new Merkava(),
                "Tiger" => new Tiger(),
                _ => throw new ArgumentException("Invalid tank brand")
            };
        }
    }
}
