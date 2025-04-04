using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Tank : Car
    {
        public double ProjectileCaliber { get; set; }
        public int ShotsPerMinute { get; set; }
        public int CrewSize { get; set; }

        public Tank(double projectleCaliber, int shotsPerMinute, int crewSize, int weight, int length, int maxSpeed)
        {
            ProjectileCaliber = projectleCaliber;
            ShotsPerMinute = shotsPerMinute;
            CrewSize = crewSize;
            Weight = weight;
            Length = length;
            MaxSpeed = maxSpeed;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Weight = {Weight}kg, Lenght = {Length}m, Max speed = {MaxSpeed}km/h");
            Console.WriteLine($"Tank: Caliber {ProjectileCaliber}, Shots/min: {ShotsPerMinute}, Crew: {CrewSize}");
        }
    }
}
