using System.Xml.Linq;

namespace AbstractFactory
{
    class Audi : Vehicle
    {
        public Audi() : base("Sedan", "All", "Red", 2000, 4, 170) { }

        public override void ShowInfo()
        {
            Console.WriteLine("Audi - Vehicle");
            base.ShowInfo();
        }
    }
}