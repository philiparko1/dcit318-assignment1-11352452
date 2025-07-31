using System;

class Program
{
    static void Main()
    {
        const double regularPrice = 10.0;
        const double discountedPrice = 7.0;

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        double price = (age <= 12 || age >= 65) ? discountedPrice : regularPrice;
        Console.WriteLine($"Ticket price: GHC{price}");
    }
}