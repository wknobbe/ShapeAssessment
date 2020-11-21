using System;

namespace ShapeAssessment
{
    public class Triangle : IMeasurable
    {
        public double BaseLength {get;set;}
        public double Height {get;set;}
        public Triangle(double baselength, double height)
        {
            BaseLength = baselength;
            Height = height;
        }
        public double Area()
        {
            double area = (.5) * BaseLength * Height;
            Math.Round(area,2);
            Console.WriteLine("The area of a triangle with base " + BaseLength + " and height " + Height + " is " + area);
            return area;
        }
    }
}