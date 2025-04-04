using AbstractFactory;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите тип транспорта (Vehicle, Cargo, Tank):");
        string type = Console.ReadLine();

        Console.WriteLine("Введите марку:");
        string brand = Console.ReadLine();

        ICarFactory factory = new CarFactory();

        if (type == "Vehicle")
        {
            Vehicle vehicle = factory.CreateVehicle(brand);
            vehicle?.ShowInfo();
        }
        else if (type == "Cargo")
        {
            Cargo cargo = factory.CreateCargo(brand);
            cargo?.ShowInfo();
        }
        else if (type == "Tank")
        {
            Tank tank = factory.CreateTank(brand);
            tank?.ShowInfo();
        }
        else
        {
            Console.WriteLine("Неверный тип транспорта.");
        }
        //Dictionary<string, Car> cars = new Dictionary<string, Car>
        //    {
        //        { "audi", new Audi() },
        //        { "honda", new Honda() },
        //        { "tesla", new Tesla() },
        //        { "volvo", new Volvo() },
        //        { "man", new Man() },
        //        { "scania", new Scania() },
        //        { "abrams", new Abrams() },
        //        { "merkava", new Merkava() },
        //        { "tiger", new Tiger() }
        //    };

        //Console.WriteLine("Select car's brand:");
        //string input = Console.ReadLine().ToLower();

        //if (cars.TryGetValue(input, out Car selectedCar))
        //{
        //    Console.WriteLine("\nInformation:");
        //    selectedCar.ShowInfo();
        //}
        //else
        //{
        //    Console.WriteLine("Brand not found. Try again..");
        //}
    }
}