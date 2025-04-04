using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class TankFactory : ICarFactory
    {
        public Vehicle CreateVehicle(string brand) => null;
        public Cargo CreateCargo(string brand) => null;

        public Tank CreateTank(string brand)
        {
            return brand switch
            {
                "Abrams" => new Abrams(),
                "Merkava" => new Merkava(),
                "Tiger" => new Tiger(),
                _ => throw new ArgumentException($"Неизвестный бренд: {brand}", nameof(brand))
            };
        }
    }
}
