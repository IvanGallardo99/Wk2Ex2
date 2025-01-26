using System;

namespace Wk2Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangle Area and Perimeter Calculator\n");

            // Enter Length of the rectangle
            Console.Write("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());

            // Enter Width of the rectangle
            Console.Write("Enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            // Calculate the area
            double area = length * width;

            // Calculate the perimeter
            double perimeter = 2 * (length + width);

            // Output the results
            Console.WriteLine("\n Results ");
            Console.WriteLine($"Area of the rectangle: {area:F2}");
            Console.WriteLine($"Perimeter of the rectangle: {perimeter:F2}");

            Console.ReadKey();
        }
    }
}
