using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class CargoFactory : ICarFactory
    {
        public Vehicle CreateVehicle(string brand) => null;

        public Cargo CreateCargo(string brand)
        {
            return brand switch
            {
                "Volvo" => new Volvo(),
                "Man" => new Man(),
                "Scania" => new Scania(),
                _ => throw new ArgumentException($"Неизвестный бренд: {brand}", nameof(brand))
            };
        }

        public Tank CreateTank(string brand) => null;
    }

}