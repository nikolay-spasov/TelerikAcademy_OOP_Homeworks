using System;

public class Display
{
    private double size;
    private int colors;

    public Display(double size, int colors)
    {
        Size = size;
        Colors = colors;
    }

    public double Size
    {
        get { return this.size; }
        set 
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(
                    "Display size cannot be negative");
            }
            size = value;
        }
    }

    public int Colors
    {
        get { return this.colors; }
        set 
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(
                    "Colors count cannot be negative.");
            }
            this.colors = value; 
        }
    }
}

