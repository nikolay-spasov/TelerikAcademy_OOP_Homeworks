﻿using System;

public class VersionDemo
{
    static void Main()
    {
        Type type = typeof(SampleClass);

        foreach (var attr in type.GetCustomAttributes(false))
        {
            if (attr is VersionAttribute)
            {
                Console.WriteLine("This is version {0} of the {1} class.",
                    (attr as VersionAttribute).Version, type.FullName);
            }
        }
    }
}

