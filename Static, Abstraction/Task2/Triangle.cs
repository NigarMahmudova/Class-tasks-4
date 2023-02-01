using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class Triangle:Shape
    {
        double _tbase;
        double _height;
        double _side;
        public Triangle(double tbase, double height, double side)
        {
            _tbase = tbase;
            _height = height;
            _side = side;
        }

        public override double CalculateArea()
        {
            return _height * _tbase * 0.5;
        }

        public override double CalculatePerimeter()
        {
            return _side + _side + _tbase;
        }
    }
}
