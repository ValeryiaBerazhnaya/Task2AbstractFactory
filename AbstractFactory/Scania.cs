using System.Xml.Linq;

namespace AbstractFactory
{
    class Scania : Cargo
    {
        public Scania() : base(20, 500, 4, 2000, 4, 170) { }

        public override void ShowInfo()
        {
            Console.WriteLine("Scania - Cargo");
            base.ShowInfo();
        }
    }
}