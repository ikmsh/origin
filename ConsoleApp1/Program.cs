using System;
class Program
{
    static void Main(string[] args)
    {
        Zadacha5();
    }
    static void Zadacha5()
    {
        double x = 2;
        double summa = 0;
        for (double i = 1; i <= 10; i++)
        {
            summa += Math.Pow(x, i) / (x + 1);
        }
        Console.WriteLine(summa);
    }
}