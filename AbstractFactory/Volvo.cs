using System.Xml.Linq;

namespace AbstractFactory
{
    class Volvo : Cargo
    {
        public Volvo() : base(20, 500, 4, 2000, 4, 170) { }

        public override void ShowInfo() 
        {
            Console.WriteLine("Volvo - Cargo");
            base.ShowInfo();
        }
    }
}