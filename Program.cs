using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    enum ShapeType
    {
        Circle,
        Square,
        Triangle
    }

    static void Main()
    {
        ShapeType shape = ShapeType.Circle;
        double radius = 5.0;
        double sideLength = 4.0;
        double baseLength = 6.0;
        double height = 8.0;

        double area = 0.0;

        switch (shape)
        {
            case ShapeType.Circle:
                area = CalculateCircleArea(radius);
                break;
            case ShapeType.Square:
                area = CalculateSquareArea(sideLength);
                break;
            case ShapeType.Triangle:
                area = CalculateTriangleArea(baseLength, height);
                break;
            default:
                Console.WriteLine("Invalid shape.");
                break;
        }

        if (area > 0)
        {
            Console.WriteLine($"The area of the selected {shape} is: {area}");
        }

        Console.ReadLine();
    }
    static double CalculateCircleArea(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }
    static double CalculateSquareArea(double sideLength)
    {
        return Math.Pow(sideLength, 2);
    }
    static double CalculateTriangleArea(double baseLength, double height)
    {
        return 0.5 * baseLength * height;
    }
}
