using System.Xml.Linq;

namespace AbstractFactory
{
    public class Audi : Vehicle
    {
        public Audi()
        {
            Weight = 1500;
            Length = 4.7;
            MaxSpeed = 250;
            WheelDrive = "front";
            Class = "sedan";
            Color = "black";
        }
    }
}