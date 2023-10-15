using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    internal class Square
    {
        double _side;


        public Square (double side)
        {
            _side = side;
        }

        public double getArea()
        {
            double area = _side * _side;
            Console.WriteLine("Area of a square with sidelenght " + _side + " " + "is " + area + " cm2");
            return area;
        }

        public double getPerimeter()
        {
            double perimeter = _side + _side + _side + _side;
            Console.WriteLine("Perimeter of a square with sidelenght " + _side + " " + "is " + perimeter + " cm");
            return perimeter;
        }

        public double getCubeVolume()
        {
            double volume = _side * _side * _side;
            Console.WriteLine("Volume of a cube with sidelenght " + _side + " " + "is " + volume + " cm3");
            return volume;
        }
    }
}
