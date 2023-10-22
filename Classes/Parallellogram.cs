using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPolymorphism
{
    // This is a class named Parallellogram that inherits from the Geometri class
    internal class Parallellogram : Geometri
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Parallellogram()
        {
            Base = 5;
            Height = 8;
        }

        // This is an overridden method to calculate the area of the parallelogram
        public override double Area()
        {
            Console.Write($"Area Parallellogram\t:");
            // Calculate the area of the parallelogram using the formula: Base * Height
            return Base * Height;
        }
    }
}
