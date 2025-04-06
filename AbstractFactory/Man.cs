using System.Xml.Linq;

namespace AbstractFactory
{
    public class Man : Cargo
    {
        public Man()
        {
            Weight = 8000;
            Length = 8.0;
            MaxSpeed = 120;
            Tonnage = 20;
            TankVolume = 400;
            AxlesAmount = 3;
        }
    }
}