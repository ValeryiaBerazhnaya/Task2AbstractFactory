using System.Xml.Linq;

namespace AbstractFactory
{
    class Abrams : Tank
    {
        public Abrams() : base(20, 500, 4, 2000, 4, 170) { }

        public override void ShowInfo()
        {
            Console.WriteLine("Abrams - Tank");
            base.ShowInfo();
        }
    }
}