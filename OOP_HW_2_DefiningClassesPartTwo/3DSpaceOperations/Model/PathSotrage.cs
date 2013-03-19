using System;
using System.IO;

public static class PathSotrage
{
    public static void SavePoint3DPath(Path path, string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Point3D point in path.Points)
            {
                writer.WriteLine("{0} {1} {2}", point.X, point.Y, point.Z);
            }
        }
    }

    public static Path LoadPoint3DPath(string fileName)
    {
        Path path = new Path();
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] splt = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                double x = double.Parse(splt[0]);
                double y = double.Parse(splt[1]);
                double z = double.Parse(splt[2]);

                path.Points.Add(new Point3D(x, y, z));
            }
        }

        return path;
    }
}

