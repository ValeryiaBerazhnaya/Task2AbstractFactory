using System.Xml.Linq;

namespace AbstractFactory
{
    class Man : Cargo
    {
        public Man() : base(20, 500, 4, 2000, 4, 170) { }

        public override void ShowInfo()
        {
            Console.WriteLine("Man - Cargo");
            base.ShowInfo();
        }
    }
}