using System;
using System.Text;

class SubstringDemo
{
    static void Main()
    {
        StringBuilder builder = new StringBuilder("This is a stringBuilder.");

        StringBuilder substring = builder.Substring(10, 13);

        Console.WriteLine("Substring = \"{0}\"", substring);
    }
}

