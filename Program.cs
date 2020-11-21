using System;

namespace ShapeAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            IMeasurable[] shapes = new IMeasurable[]
            {
                new Circle(5),
                new Rectangle(5,4),
                new Square(10),
                new Triangle(5,4),
            };
            double totalArea = 0;
            foreach (var shape in shapes)
            {
                totalArea += shape.Area();
            }
            Console.WriteLine("The total area of the shapes is " + totalArea);
        }
    }
}
