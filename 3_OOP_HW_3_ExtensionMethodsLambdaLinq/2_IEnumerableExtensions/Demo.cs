using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Demo
{
    static void Main()
    {
        // Note that C# arrays are IEnumerable
        int[] numbers = new int[]
        {
            1, 5, 7, 1, -1, -32, -326
        };

        Console.WriteLine("Sum = {0}", numbers.CalculateSum<int>());
        Console.WriteLine("Product = {0}", numbers.CalculateProduct<int>());
        Console.WriteLine("Min = {0}", numbers.FindMin<int>());
        Console.WriteLine("Max = {0}", numbers.FindMax<int>());
        Console.WriteLine("Average = {0}", numbers.CalculateAverage<int>());
    }
}

