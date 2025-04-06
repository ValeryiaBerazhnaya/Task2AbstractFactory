namespace AbstractFactory
{
    class Program
    {
        static void Main()
        {
            var audi = CarFactory.CreateVehicle("Audi");
            var honda = CarFactory.CreateVehicle("Honda");
            var volvo = CarFactory.CreateCargo("Volvo");
            var scania = CarFactory.CreateCargo("Scania");
            var abrams = CarFactory.CreateTank("Abrams");
            var tiger = CarFactory.CreateTank("Tiger");

            ShowVehicle(audi);
            ShowVehicle(honda);
            ShowCargo(volvo);
            ShowCargo(scania);
            ShowTank(abrams);
            ShowTank(tiger);

        }

        static void ShowVehicle(Vehicle v)
        {
            Console.WriteLine("Vehicle:");
            Console.WriteLine($"Brand: {v.GetType().Name,-5} | Weight = {v.Weight,6}kg | Length = {v.Length,2}m | Max speed = {v.MaxSpeed,2} km/h");
            Console.WriteLine($"Drive: {v.WheelDrive,-5} | Class: {v.Class,-10} | Color: {v.Color,-10}");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
        }

        static void ShowCargo(Cargo c)
        {
            Console.WriteLine("Cargo:");
            Console.WriteLine($"Brand: {c.GetType().Name, -7} | Weight = {c.Weight, 7}kg | Lenght = {c.Length, 12}m | Max speed = {c.MaxSpeed} km/h");
            Console.WriteLine($"Tonnage = {c.Tonnage}kg | Tank volume = {c.TankVolume}t | Axles amount = {c.AxlesAmount} axles");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
        }
        static void ShowTank(Tank t)
        {
            Console.WriteLine("Tank:");
            Console.WriteLine($"Brand: {t.GetType().Name, 16} | Weight = {t.Weight, 11}kg | Lenght = {t.Length, 3}m | Max speed = {t.MaxSpeed} km/h");
            Console.WriteLine($"Projectile caliber = {t.ProjectileCaliber} | Shots per minute = {t.ShotsPerMinute} | Crew size = {t.CrewSize}");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
        }
    }
}