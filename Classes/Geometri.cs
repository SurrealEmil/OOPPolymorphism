using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPolymorphism
{
    // This is an abstract class named Geometri
    internal abstract class Geometri
    {
        // This is an abstract method to calculate the area of a geometric shape.
        // It does not have an implementation in this class and must be implemented in derived classes.
        public abstract double Area();
    }
}
