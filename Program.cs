﻿using System;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shape Test
            Shape shape = new Shape();
            Console.WriteLine(shape);


            shape = new Shape("red", false);
            Console.WriteLine(shape);

            // Circle Test
            Circle circle = new Circle();
            Console.WriteLine(circle);
            Resizeable resizeable = (Circle)circle;
            resizeable.Resize(20);
            Console.WriteLine(circle);
            circle = new Circle(3.5);
            Console.WriteLine(circle);
            Resizeable resizeable2 = (Circle)circle;
            resizeable2.Resize(20);
            Console.WriteLine(circle);
            circle = new Circle(3.5, "indigo", false);
            Console.WriteLine(circle);

            // Square Test
            Square square = new Square();
            Console.WriteLine(square);
            Resizeable resizeable3 = (Square)square;
            resizeable.Resize(20);
            Console.WriteLine(square);
            square = new Square(2.3);
            Console.WriteLine(square);

            square = new Square(5.8, "yellow", true);
            Console.WriteLine(square);
        }
    }
}