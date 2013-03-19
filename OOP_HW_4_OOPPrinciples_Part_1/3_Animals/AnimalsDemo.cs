using System;
using System.Collections.Generic;
using _3_Animals.Model;

class AnimalsDemo
{
    static void Main()
    {
        Dog[] dogs = new Dog[]
        {
            new Dog(5, "Sharo", 'm'),
            new Dog(8, "Johnny", 'm'),
            new Dog(2, "Brian", 'm')
        };

        Frog[] frogs = new Frog[]
        {
            new Frog(1, "Kikirica", 'f'),
            new Frog(2, "Jaborana", 'f')
        };

        Cat[] cats = new Cat[]
        {
            new Cat(5, "Pisana", 'f'),
            new Cat(3, "Stefka", 'f'),
            new Cat(7, "Roshko", 'm'),
            new Cat(4, "Maca", 'f')
        };

        Kitten[] kittens = new Kitten[]
        {
            new Kitten(1, "Pisana"),
            new Kitten(1, "Belosnejka"),
            new Kitten(1, "Cecka")
        };

        Tomcat[] tomcats = new Tomcat[]
        {
            new Tomcat(14, "Tom"),
            new Tomcat(7, "Rich"),
            new Tomcat(3, "Roshko 2")
        };

        Console.WriteLine("Average age of Dogs: {0}", AverageAge(dogs));
        Console.WriteLine("Average age of Frogs: {0}", AverageAge(frogs));
        Console.WriteLine("Average age of Cats: {0}", AverageAge(cats));
        Console.WriteLine("Average age of Kittens: {0}", AverageAge(kittens));
        Console.WriteLine("Average age of Tomcats: {0}", AverageAge(tomcats));

        Console.WriteLine("Sounds:");
        Console.Write("\tThe dog says: ");
        dogs[0].MakeSound();
        Console.Write("\tThe frog says: ");
        frogs[0].MakeSound();
        Console.Write("\tThe cat says: ");
        cats[0].MakeSound();
        Console.Write("\tThe kitten says: ");
        kittens[0].MakeSound();
        Console.Write("\tThe tomcat says: ");
        tomcats[0].MakeSound();
    }

    static double AverageAge(IEnumerable<Animal> animals)
    {
        int sum = 0;
        int count = 0;
        foreach (var a in animals)
        {
            sum += a.Age;
            count++;
        }

        return (double)sum / (double)count;
    }
}

