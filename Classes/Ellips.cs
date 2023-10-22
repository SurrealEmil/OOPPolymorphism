using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPolymorphism
{
    // This is a class named Ellips that inherits from the Geometri class
    internal class Ellips : Geometri
    {
        public double LongRadius { get; set; }
        public double ShortRadius { get; set; }

        public Ellips()
        {
            LongRadius = 4;
            ShortRadius = 2;
        }

        // This is an overridden method to calculate the area of the ellipse
        public override double Area()
        {
            Console.Write("Area Ellips\t\t:");
            // Calculate the area of the ellipse using the formula: π * LongRadius * ShortRadius
            return Math.PI * LongRadius * ShortRadius;
        }
    }
}
