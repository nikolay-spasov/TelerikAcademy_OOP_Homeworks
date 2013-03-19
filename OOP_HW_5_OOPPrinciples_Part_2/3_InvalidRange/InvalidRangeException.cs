using System;

public class InvalidRangeException<T> : ApplicationException
{
    private T start;
    private T end;

    public InvalidRangeException(T start, T end, string message, Exception innerException)
        : base(message, innerException)
    {
        this.start = start;
        this.end = end;
    }

    public InvalidRangeException(T start, T end, string message)
        : this(start, end, message, null) { }

    public InvalidRangeException(T start, T end)
        : this(start, end,
            string.Format("Provided values were not in the range [{0}, {1}]", start, end))
    {

    }
}

