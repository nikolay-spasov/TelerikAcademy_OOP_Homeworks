using System;
using System.Text;

public static class StringBuilderExtensions
{
    public static StringBuilder Substring(this StringBuilder builder, 
        int index, int length)
    {
        if (index < 0 || length < 1 || index > builder.Length || index + length > builder.Length)
        {
            throw new ArgumentOutOfRangeException(
                "123");
        }

        StringBuilder result = new StringBuilder(index + length);
        for (int i = index; i < index + length; i++)
        {
            result.Append(builder[i]);
        }

        return result;
    }
}

