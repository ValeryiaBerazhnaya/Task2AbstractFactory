using System.Xml.Linq;

namespace AbstractFactory
{
    public class Scania : Cargo
    {
        public Scania()
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