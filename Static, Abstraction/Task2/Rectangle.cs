using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class Rectangle:Shape
    {
        double _side1;
        double _side2;
        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
        }

        public override double CalculateArea()
        {
            return _side1 * _side2;
        }

        public override double CalculatePerimeter()
        {
            return (_side1 + _side2) * 2;
        }
    }
}
