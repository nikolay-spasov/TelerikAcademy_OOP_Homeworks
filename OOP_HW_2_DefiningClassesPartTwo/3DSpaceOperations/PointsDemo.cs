using System;
using System.Collections.Generic;

public class PointsDemo
{
    private const string FILE_NAME = "../../Points.txt";

    public static void Main()
    {
        Console.WriteLine("Point O = {0}", Point3D.PointZero);

        Point3D p1 = new Point3D(3, 3, 1);
        Point3D p2 = new Point3D(4, 2, 3);

        Console.WriteLine("p1 = {0}", p1);
        Console.WriteLine("p2 = {0}", p2);

        double distance = Distance.CalculateDistance(p1, p2);
        Console.WriteLine("Distance between p1 and p2 = {0}", distance);

        Path path = new Path(new List<Point3D>()
        {
            p1, p2, Point3D.PointZero, new Point3D(5.6, 3, 20)
        });

        PathSotrage.SavePoint3DPath(path, FILE_NAME);
        Console.WriteLine("Saved path contains: ");
        foreach (var p in path.Points)
        {
            Console.WriteLine("\t{0}", p);
        }

        Path loadedPath = PathSotrage.LoadPoint3DPath(FILE_NAME);
        Console.WriteLine("Loaded path contains: ");
        foreach (var p in loadedPath.Points)
        {
            Console.WriteLine("\t{0}", p);
        }
    }
}

