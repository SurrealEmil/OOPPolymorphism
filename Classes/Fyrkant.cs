using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPolymorphism
{
    // This is a class named Fyrkant that inherits from the Geometri class
    internal class Fyrkant : Geometri
    {
        public double Side { get; set; }

        public Fyrkant()
        {
            Side = 5;
        }

        // This is an overridden method to calculate the area of the square
        public override double Area()
        {
            Console.Write("Area Fyrkant\t\t:");
            // Calculate the area of the square using the formula: Side * Side
            return Math.Pow(Side, 2);
        }
    }
}
