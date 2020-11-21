using System;

namespace ShapeAssessment
{
    public class Square : IMeasurable
    {
        public double Side {get;set;}
        public Square(double side)
        {
            Side = side;
        }
        public double Area()
        {
            double area = Side * Side;
            Math.Round(area,2);
            Console.WriteLine("The area of a square with sides " + Side + " is " + area);
            return area;
        }
    }
}