using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class VehicleFactory : ICarFactory
    {
        public Vehicle CreateVehicle(string brand)
        {
            return brand switch
            {
                "Audi" => new Audi(),
                "Honda" => new Honda(),
                "Tesla" => new Tesla(),
                _ => throw new ArgumentException($"Неизвестный бренд: {brand}", nameof(brand))
            };
        }

        public Cargo CreateCargo(string brand) => null;
        public Tank CreateTank(string brand) => null;
    }

}
