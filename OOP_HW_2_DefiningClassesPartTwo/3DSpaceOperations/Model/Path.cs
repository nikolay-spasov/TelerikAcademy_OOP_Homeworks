using System;
using System.Linq;
using System.Collections.Generic;

public class Path
{
    public List<Point3D> Points;

    public Path()
    {
        Points = new List<Point3D>();
    }

    public Path(ICollection<Point3D> points)
    {
        Points = points.ToList();
    }
}

