using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPolymorphism
{
    // This is a class named Rektangel that inherits from the Geometri class
    internal class Rektangel : Geometri
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Rektangel() 
        { 
            Base = 5;
            Height = 8;
        }

        // This is an overridden method to calculate the area of the rectangle
        public override double Area()
        {
            Console.Write("Area Rektangel\t\t:");
            // Calculate the area of the rectangle using the formula: Base * Height
            return Base * Height;
        }
    }
}
