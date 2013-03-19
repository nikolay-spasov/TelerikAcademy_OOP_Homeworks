using System;

public static class Distance
{
    public static double CalculateDistance(Point3D p, Point3D q)
    {
        double x = (q.X - p.X);
        double y = (q.Y - p.Y);
        double z = (q.Z - p.Z);

        return Math.Sqrt(x * x + y * y + z * z);
    }
}
