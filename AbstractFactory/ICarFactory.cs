using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    interface ICarFactory
    {
        Vehicle CreateVehicle(string brand);
        Cargo CreateCargo(string brand);
        Tank CreateTank(string brand);
    }
}
