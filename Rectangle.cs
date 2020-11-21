using System;

namespace ShapeAssessment
{
    public class Rectangle : IMeasurable
    {
        public double LongSide {get;set;}
        public double ShortSide {get;set;}
        public Rectangle(double longSide, double shortSide)
        {
            LongSide = longSide;
            ShortSide = shortSide;
        }
        public double Area()
        {
            double area = LongSide * ShortSide;
            Math.Round(area,2);
            Console.WriteLine("The area of a rectangle with sides " + LongSide + " and " + ShortSide + " is " + area);
            return area;
        }
    }
}