using System;
using System.Diagnostics;
using Sorting;

public class Program
{
    public static void Main(String[] args)
    {
        var numberArray = new Number[] { new Number(12), new Number(34), new Number(55), new Number(8), new Number(65)};
        var pointArray = new Point[] { new Point(1, 2), new Point(2, 1), new Point(3, 0), new Point(2,4)};
        var numberMaximumFinder = new ConditionFinder<Number>(numberArray, LeftSmallerThanRight);
        var pointMaximumFinder = new ConditionFinder<Point>(pointArray, LeftCloserThanRight);
        Console.WriteLine(numberMaximumFinder.Find());
        Console.WriteLine(pointMaximumFinder.Find());
        Console.ReadKey();
    }

    public static bool LeftSmallerThanRight(Number num1, Number num2)
    {
        return num1.CompareTo(num2) < 0;
    }

    public static bool LeftCloserThanRight(Point p1, Point p2)
    {
        return p1.CompareTo(p2) > 0;
    }
}