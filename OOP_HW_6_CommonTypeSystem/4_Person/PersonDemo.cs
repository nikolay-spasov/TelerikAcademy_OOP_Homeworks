using System;

class PersonDemo
{
    static void Main()
    {
        Person p1 = new Person("Ivan Ivanov");
        Person p2 = new Person("Vasil Vasilev", 25);

        Console.WriteLine(p1);
        Console.WriteLine(p2);
    }
}

