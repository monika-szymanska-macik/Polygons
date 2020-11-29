using System;
using Polygons.Library;


namespace Polygons
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle1 = new Triangle(5);
            DisplayPolygon("Triangle", triangle1);

            var square = new Square(5);
            DisplayPolygon("Square", square);

            var triangle = new Triangle(5);
            DisplayPolygon("Triangle", triangle);

            var octagon = new Octagon(5);
            DisplayPolygon("Octagon", octagon);

            Console.Read();
        }
        public static void DisplayPolygon(string polygonType, dynamic polygon)
        {
            try
            {
                Console.WriteLine($"{polygonType} number of sides {polygon.NumberOfSides}");
               Console.WriteLine($"{polygonType} sides length {polygon.SideLength}");
                Console.WriteLine($"{polygonType} perimeter {polygon.GetPerimeter()}");
                Console.WriteLine($"{polygonType} area {polygon.GetArea()}");
                Console.WriteLine(" ");
            }
            catch(Exception ex)
            {
                Console.WriteLine(
                    $"Exception was thrown while trying to process {polygonType}:\n   {ex.GetType().Name}");
                Console.WriteLine();
            }
}

    }
}
