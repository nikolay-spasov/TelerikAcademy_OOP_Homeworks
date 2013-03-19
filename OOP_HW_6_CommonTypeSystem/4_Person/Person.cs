using System;

public class Person
{
    public string Name { get; set; }
    public byte? Age { get; set; }

    public Person(string name, byte? age)
    {
        Name = name;
        Age = age;
    }

    public Person(string name) : this(name, null) { }

    public override string ToString()
    {
        string age;
        if (this.Age == null)
        {
            age = "not specified";
        }
        else
        {
            age = this.Age.ToString();
        }

        return string.Format("Name: {0}, Age: {1}", Name, age);
    }
}

