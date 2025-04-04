using System.Xml.Linq;

namespace AbstractFactory
{
    class Tesla : Vehicle
    {
        public Tesla() : base("Sedan", "All", "Red", 2000, 4, 170) { }

        public override void ShowInfo()
        {
            Console.WriteLine("Tesla - Vehicle");
            base.ShowInfo();
        }
    }
}