using System;
using System.Collections.Generic;
using System.Linq;

public static class IEnumerableExtensions
{
    public static T CalculateSum<T>(this IEnumerable<T> enumerable) where T : IComparable
    {
        dynamic result = 0;
        foreach (var n in enumerable)
        {
            result += n;
        }

        return result;
    }

    public static T CalculateProduct<T>(this IEnumerable<T> enumerable) where T : IComparable
    {
        dynamic result = 1;
        foreach (var n in enumerable)
        {
            result *= n;
        }

        return result;
    }

    public static T FindMin<T>(this IEnumerable<T> enumerable) where T : IComparable
    {
        dynamic min = (dynamic)enumerable.ElementAt(0);

        foreach (var item in enumerable)
        {
            if (item.CompareTo(min) < 0)
            {
                min = item;
            }
        }

        return min;
    }

    public static T FindMax<T>(this IEnumerable<T> enumerable) where T : IComparable
    {
        dynamic max = (dynamic)enumerable.ElementAt(0);

        foreach (var item in enumerable)
        {
            if (item.CompareTo(max) > 0)
            {
                max = item;
            }
        }

        return max;
    }

    public static decimal CalculateAverage<T>(this IEnumerable<T> enumerable) where T : IComparable
    {
        dynamic sum = 0;
        int count = 0;
        foreach (T item in enumerable)
        {
            sum += item;
            count++;
        }

        return (decimal)sum / (decimal)count;
    }
}

