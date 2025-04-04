using System.Xml.Linq;

namespace AbstractFactory
{
    class Tiger : Tank
    {
        public Tiger() : base(20, 500, 4, 2000, 4, 170) { }

        public override void ShowInfo()
        {
            Console.WriteLine("Tiger - Tank");
            base.ShowInfo();
        }
    }
}