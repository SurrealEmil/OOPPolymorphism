using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPolymorphism
{
    // This is a class named Cirkel that inherits from the Geometri class
    internal class Cirkel : Geometri
    {
        public double Radius { get; set; }

        public Cirkel()
        {
            Radius = 5;
        }

        // This is an overridden method to calculate the area of the circle
        public override double Area()
        {
            Console.Write("Area Cirkel\t\t:");
            // Calculate the area of the circle using the formula: π * r^2
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

}
