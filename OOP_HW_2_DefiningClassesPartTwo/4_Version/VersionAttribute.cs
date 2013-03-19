using System;

[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class |
    AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method,
    AllowMultiple = false)]
public class VersionAttribute : Attribute
{
    public string Version { get; set; }

    public VersionAttribute(string version)
    {
        Version = version;
    }
}

