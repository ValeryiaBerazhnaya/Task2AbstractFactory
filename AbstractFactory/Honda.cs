using System.Xml.Linq;

namespace AbstractFactory
{
    public class Honda : Vehicle
    {
        public Honda()
        {
            Weight = 1400;
            Length = 4.5;
            MaxSpeed = 220;
            WheelDrive = "back";
            Class = "hatchback";
            Color = "white";
        }
    }
}