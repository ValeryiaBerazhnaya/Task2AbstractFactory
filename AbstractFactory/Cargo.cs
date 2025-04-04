using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Cargo : Car
    {
        public double Tonnage { get; set; }
        public double TankVolume { get; set; }
        public int AxlesAmount { get; set; }

        public Cargo(double tonnage, double tankVolume, int axlesAmount, int weight, int length, int maxSpeed)
        {
            Tonnage = tonnage;
            TankVolume = tankVolume;
            AxlesAmount = axlesAmount;
            Weight = weight;
            Length = length;
            MaxSpeed = maxSpeed;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Weight = {Weight}kg, Lenght = {Length}m, Max speed = {MaxSpeed}km/h");
            Console.WriteLine($"Tonnage {Tonnage}, Tank Volume: {TankVolume}, Axles: {AxlesAmount}");
        }
    }
}
