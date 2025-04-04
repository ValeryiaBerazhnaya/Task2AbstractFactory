using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Vehicle : Car
    {
        public string WheelDrive { get; set; }
        public string Class { get; set; }
        public string Color { get; set; }

        public Vehicle(string carClass, string wheelDrive, string color, int weight, int length, int maxSpeed)
        {
            Class = carClass;
            WheelDrive = wheelDrive;
            Color = color;
            Weight = weight;
            Length = length;
            MaxSpeed = maxSpeed;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Weight = {Weight}kg, Lenght = {Length}m, Max speed = {MaxSpeed}km/h");
            Console.WriteLine($"Class: {Class}, Wheel drive: {WheelDrive}, Color: {Color}");
        }
    }
}
