using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    internal class Triangle
    {
        double _side1;
        double _side2;
        double _side3;

        public Triangle(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public double getPerimeter()
        {
            double perimeter = _side1 + _side2 + _side3;
            Console.WriteLine("Perimeter of a triangle with sidelenghts " + _side1 + ", " + _side2 + "," + _side3 + " is " + perimeter + " cm");
            return perimeter;
        }
        public double getArea()
        {
            double semiperimeter = (_side1 + _side2 + _side3) / 2;
            double area =
                Math.Sqrt(semiperimeter *
                (semiperimeter - _side1) *
                (semiperimeter - _side2) *
                (semiperimeter - _side3));
            Console.WriteLine("Area of a triangle with sidelenghts " + _side1 + ", " + _side2 + "," + _side3 + " is " + area + " cm2");
            return area;
        }
        

    }
}
