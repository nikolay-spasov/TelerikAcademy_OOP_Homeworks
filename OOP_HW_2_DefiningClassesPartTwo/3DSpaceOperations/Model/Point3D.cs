using System;

public struct Point3D
{
    private static readonly Point3D pointZero = new Point3D(0, 0, 0);

    public double X, Y, Z;

    public Point3D(double x, double y, double z) : this()
    {
        X = x;
        Y = y;
        Z = z;
    }

    public static Point3D PointZero
    {
        get { return pointZero; }
    }

    public override string ToString()
    {
        return string.Format("Point3D({0}, {1}, {2})", X, Y, Z);
    }
}

