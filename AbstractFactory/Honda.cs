using System.Xml.Linq;

namespace AbstractFactory
{
    class Honda : Vehicle
    {
        public Honda() : base("Sedan", "All", "Red", 2000, 4, 170) { }

        public override void ShowInfo()
        {
            Console.WriteLine("Honda - Vehicle");
            base.ShowInfo();
        }
    }
}