using System;

class StudentDemo
{
    static void Main()
    {
        Student s1 = new Student("Asen", "Stefanov", "Zashev", 123535124112UL, "Pesho street 1",
            "0881456789", "asen@gmail.com", 4, University.SU, Faculty.FMI, Speciality.ComputerScience);
        Student s2 = new Student("Zlatko", "Strahilov", "Asenov", 1233451232UL, "Pesho street 2",
            "0884564789", "zlatko@gmail.com", 3, University.UNSS, Faculty.IF, Speciality.Economics);

        Console.WriteLine("First student: ");
        Console.WriteLine(s1);
        Console.WriteLine();
        Console.WriteLine("Second student: ");
        Console.WriteLine(s2);

        Console.WriteLine();
        Console.WriteLine("Are first and second student equal? -> {0}", s1.Equals(s2));

        Console.WriteLine();
        Console.WriteLine("Cloning the first student into newStudent.");
        Student newStudent = s1.Clone() as Student;
        Console.WriteLine("NewStudent: ");
        Console.WriteLine(newStudent);

        Console.WriteLine();
        Console.WriteLine("Is new student equal to the first student? -> {0}", newStudent == s1);
        Console.WriteLine("Is new student equal to the second student? -> {0}", newStudent == s2);
        Console.WriteLine("Is the first student < second student? -> {0}", 
            s1.CompareTo(s2) == -1);
        Console.WriteLine("Is the first student > second student? -> {0}",
            s1.CompareTo(s2) == 1);

        Console.WriteLine();
        Console.WriteLine("HashCodes: ");
        Console.WriteLine("First student -> {0}", s1.GetHashCode());
        Console.WriteLine("Second student -> {0}", s2.GetHashCode());
        Console.WriteLine("New student -> {0}", newStudent.GetHashCode());
    }
}

