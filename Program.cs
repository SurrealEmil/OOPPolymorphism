namespace OOPPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an array of Geometri objects to store different geometric shapes
            Geometri[] shapes = new Geometri[5];
            {
                // Initialize the array with instances of various geometric shapes
                shapes[0] = new Ellips();
                shapes[1] = new Cirkel();
                shapes[2] = new Fyrkant();
                shapes[3] = new Rektangel();
                shapes[4] = new Parallellogram();
            }

            // Iterate through the array of shapes and calculate and print their areas
            foreach (Geometri shape in shapes)
            {
                Console.WriteLine($"{Math.Round(shape.Area(), 2)}");
            }
        }
    }
}