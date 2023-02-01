using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square shape1 = new Square(5);
            Console.WriteLine("Area: " + shape1.CalculateArea());
            Console.WriteLine("Perimeter: " + shape1.CalculatePerimeter());

            Rectangle shape2 = new Rectangle(4, 6);
            Console.WriteLine("Area: " + shape2.CalculateArea());
            Console.WriteLine("Perimeter: " + shape2.CalculatePerimeter());

            Triangle shape3 = new Triangle(8, 11, 5);
            Console.WriteLine("Area: " + shape3.CalculateArea());
            Console.WriteLine("Perimeter: " + shape3.CalculatePerimeter());
        }
    }
}
