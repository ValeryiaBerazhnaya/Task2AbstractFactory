using AbstractFactory;

class Program
{
    static void Main()
    {
        ICarFactory vehicleFactory = new VehicleFactory();
        ICarFactory cargoFactory = new CargoFactory();
        ICarFactory tankFactory = new TankFactory();

        Vehicle car = vehicleFactory.CreateVehicle();
        Cargo truck = cargoFactory.CreateCargo();
        Tank tank = tankFactory.CreateTank();

        car?.ShowInfo();
        truck?.ShowInfo();
        tank?.ShowInfo();
    }
}