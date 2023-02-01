using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class Square:Shape
    {
        double _side;
        public Square(double side) 
        { 
            this._side = side;
        }

        public override double CalculateArea()
        {
            return _side * _side;
           
        }

        public override double CalculatePerimeter()
        {
            return _side * 4;
        }
    }
}
