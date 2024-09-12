using System;

class Program
{
    static void Main()
    {
        double step = 1;
        double start = -10;
        double end = 10;

        Console.WriteLine($"{ "a",-10} { "a^2(a)",-10} { "Sqrt a (a)",-10}");

        for (double a = start; a <= end; a += step)
        {
            double x = a * a; 
            double y = Math.Sqrt(a); 
            Console.WriteLine($"{ a,-10:F2} { x,-10:F2} { y,-10:F2}");
        }
    }
}
