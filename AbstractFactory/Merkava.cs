using System.Xml.Linq;

namespace AbstractFactory
{
    class Merkava : Tank
    {
        public Merkava() : base(20, 500, 4, 2000, 4, 170) { }

        public override void ShowInfo()
        {
            Console.WriteLine("Merkava - Tank");
            base.ShowInfo();
        }
    }
}