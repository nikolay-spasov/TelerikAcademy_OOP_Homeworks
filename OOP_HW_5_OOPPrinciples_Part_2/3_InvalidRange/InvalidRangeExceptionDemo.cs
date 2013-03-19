using System;

public class InvalidRangeExceptionDemo
{
    private const int MIN = 1;
    private const int MAX = 100;

    private static readonly DateTime MIN_DATE = new DateTime(1980, 1, 1);
    private static readonly DateTime MAX_DATE = new DateTime(2013, 12, 31);

    static void Main()
    {
        // Modify values to test.
        int n = -1;
        DateTime date = new DateTime(1979, 1, 1);

        try
        {
            if (n < MIN || n > MAX)
            {
                throw new InvalidRangeException<int>(MIN, MAX,
                    string.Format("N is outside of the range [{0}, {1}]", MIN, MAX));
            }
        }
        catch (InvalidRangeException<int> ire)
        {
            Console.WriteLine(ire.Message);
            Console.WriteLine(ire.StackTrace);
        }

        Console.WriteLine();

        try
        {
            if (date < MIN_DATE || date > MAX_DATE)
            {
                // Using the default message
                throw new InvalidRangeException<DateTime>(MIN_DATE, MAX_DATE);
            }
        }
        catch (InvalidRangeException<DateTime> ire)
        {
            Console.WriteLine(ire.Message);
            Console.WriteLine(ire.StackTrace);
        }
    }
}

