/*
20. Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the coordinates of point 1:");
        Console.Write("X1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the coordinates of point 2:");
        Console.Write("X2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        double distance = CalculateDistance(x1, y1, x2, y2);
        Console.WriteLine("Distance between the two points is: " + distance);
    }

    static double CalculateDistance(double x1, double y1, double x2, double y2)
    {
        double deltaX = x2 - x1;
        double deltaY = y2 - y1;
        double distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
        return distance;
    }
}
