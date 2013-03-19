using System;
using System.Linq;

class Numbers
{
    static void Main()
    {
        int[] numbers = GetNumbers();

        var divisibleBy3And7Lambda = numbers.Where(n => n % 3 == 0 && n % 7 == 0);
        Console.WriteLine("Lambda:");
        foreach (var n in divisibleBy3And7Lambda)
        {
            Console.Write("{0} ", n);
        }
        Console.WriteLine();

        var divisibleBy3And7LINQ = from n in numbers
                                   where n % 3 == 0 && n % 7 == 0
                                   select n;
        Console.WriteLine("LINQ:");
        foreach (var n in divisibleBy3And7Lambda)
        {
            Console.Write("{0} ", n);
        }
        Console.WriteLine();
    }

    private static int[] GetNumbers()
    {
        int[] result = new int[64];
        for (int i = 0; i < 64; i++)
        {
            result[i] = i + 1;
        }

        return result;
    }
}

