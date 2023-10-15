namespace Labb5
{ // Johanna Marklund .NET23
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5); // Creating a new object
            c1.getArea();              // calculating area of circle
            c1.getSphereVolume();      // calculating volume of a sphere
            c1.getCircumference();     // calculating circumference of circle
            c1.getSphereArea();        // calculating sphere area

            Circle c2 = new Circle(6);
            c2.getArea();
            c2.getSphereVolume();
            c2.getCircumference();
            c2.getSphereArea();

            Square s1 = new Square(5);
            s1.getArea();
            s1.getPerimeter();
            s1.getCubeVolume();

            Square s2 = new Square(6);
            s2.getArea();
            s2.getPerimeter();
            s2.getCubeVolume();

            Triangle t1 = new Triangle(5,5,5);
            t1.getPerimeter();
            t1.getArea();

            Triangle t2 = new Triangle(6, 6, 6);
            t2.getPerimeter();
            t2.getArea();
        }
    }

    class Circle
    {
        float _pi = 3.141f;
        int _radius;

        public Circle(int radius)
        {
            _radius = radius;
        }

        public double getCircumference()
        {
            double circumference = _pi * (2 * _radius);
            Console.WriteLine("Circumference of a circle with radius " + _radius + " " + "is " + circumference +" cm");
            return circumference;
        }

        public double getArea()
        {
            double area = (_pi * _radius * _radius);
            Console.WriteLine("Area of a circle with radius " + _radius + " " + "is " + area + " cm2");
            return area;
        }
        
        public double getSphereVolume()
        {
            double volume = 4.0 / 3.0 * _pi * _radius * _radius * _radius;
            Console.WriteLine("Volume of a sphere with radius " + _radius +" " +"is " + volume + " cm3");
            return volume;      
        }
        
        public double getSphereArea()
        {
            double area = 4 * _pi * _radius * _radius;
            Console.WriteLine("surface area of a sphere with radius " + _radius + " " + "is " + area + " cm2");
            return area;
        }
    }
}