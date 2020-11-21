using System;

namespace ShapeAssessment
{
    public class Circle : IMeasurable
    {
        public double Radius {get;set;}
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Area()
        {
            double area = (3.14) * Radius * Radius;
            Math.Round(area,2);
            Console.WriteLine("The area of a circle with radius " + Radius + " is " + area);
            return area;
        }
    }
}