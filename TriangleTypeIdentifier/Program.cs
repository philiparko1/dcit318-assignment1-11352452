using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter three sides of a triangle:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        string type = (a == b && b == c) ? "Equilateral" :
                      (a == b || a == c || b == c) ? "Isosceles" : "Scalene";

        Console.WriteLine($"Triangle type: {type}");
    }
}