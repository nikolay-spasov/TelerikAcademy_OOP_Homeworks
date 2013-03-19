using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class StudentsDemo
{
    static void Main()
    {
        Student[] students = new Student[]
        {
            new Student("Pesho", "Ivanov", 31),
            new Student("Stefcho", "Grigorov", 17),
            new Student("Zahari", "Asenov", 24),
            new Student("Asen", "Zahariev", 22),
            new Student("Mihail", "Petrov", 20)
        };

        Console.WriteLine("All students:");
        foreach (var s in students)
        {
            Console.WriteLine("\t{0}", s);
        }

        Console.WriteLine("Students whose first name is berfore its last name alphabetically:");
        foreach (var s in GetStudentsWhoseFirstNameIsBeforeLastNameAphabetically(students))
        {
            Console.WriteLine("\t{0}", s);
        }

        var names = from s in students
                    where s.Age >= 18 && s.Age <= 24
                    select new { FirstName = s.FirstName, LastName = s.LastName };

        Console.WriteLine("Name of all students with age between 18 and 24:");
        foreach (var name in names)
        {
            Console.WriteLine("\t{0} {1}", name.FirstName, name.LastName);
        }

        // Sort students with lambda
        //students = students
        //    .OrderByDescending(s => s.FirstName)
        //    .ThenByDescending(s => s.LastName)
        //    .ToArray();

        // Sort students with linq
        students = (from s in students
                    orderby s.FirstName descending,
                            s.LastName descending
                    select s).ToArray<Student>();
                    

        Console.WriteLine("Sorted students:");
        foreach (var s in students)
        {
            Console.WriteLine("\t{0}", s);
        }
    }

    private static List<Student> GetStudentsWhoseFirstNameIsBeforeLastNameAphabetically(
        Student[] students)
    {
        return (from s in students
               where s.FirstName.CompareTo(s.LastName) < 0
               select s).ToList();
    }
}

