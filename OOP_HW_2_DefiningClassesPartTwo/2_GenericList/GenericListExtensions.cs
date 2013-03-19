using System;

public static class GenericListExtensions
{
    public static T Min<T>(this GenericList<T> list) where T : IComparable
    {
        T min = list[0];

        for (int i = 1; i < list.Count; i++)
        {
            if (list[i].CompareTo(min) < 0)
            {
                min = list[i];
            }
        }

        return min;
    }

    public static T Max<T>(this GenericList<T> list) where T : IComparable
    {
        T max = list[0];

        for (int i = 1; i < list.Count; i++)
        {
            if (list[i].CompareTo(max) > 0)
            {
                max = list[i];
            }
        }

        return max;
    }
}

