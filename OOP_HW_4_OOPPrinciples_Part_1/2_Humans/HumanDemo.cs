using _2_Humans.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Humans
{
    class HumanDemo
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Pesho", "Ivanov", 2),
                new Student("Zahari", "Aleksandrov", 4),
                new Student("Aleksander", "Zashev", 3),
                new Student("George", "Fakename", 5),
                new Student("Mitko", "Strahilov", 4.33),
                new Student("Zahari", "Aleksandrov", 4),
                new Student("Aleksander", "Zashev", 3),
                new Student("George", "Fakename", 5.50),
                new Student("Pesho", "Ivanov", 2.1),
                new Student("Zahari", "Aleksov", 4.25),
            };

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Sasho", "Tomov", 5000m, 1),
                new Worker("Stefcho", "Grigorov", 250m, 10),
                new Worker("Sasho", "Tomov", 500m, 1),
                new Worker("Stefcho", "Grigorov", 250m, 10),
                new Worker("Albena", "Petrova", 15.60m, 1),
                new Worker("Stefcho", "Grigorov", 250m, 10),
                new Worker("Sasho", "Tomov", 5m, 1),
                new Worker("George", "Grigorov", 1m, 10),
                new Worker("Sasho", "Stefanov", 540m, 1),
                new Worker("Beti", "Grigorova", 368m, 10),
            };

            students = students.OrderBy(s => s.Grade).ToList();
            workers = workers.OrderByDescending(w => w.MoneyPerHour()).ToList();

            Console.WriteLine("Students sorted by grade:");
            foreach (var s in students)
            {
                Console.WriteLine("\t{0} {1} {2:f2}", s.FirstName, s.LastName, s.Grade);
            }

            Console.WriteLine("Workers sorted by money per hour:");
            foreach (var w in workers)
            {
                Console.WriteLine("\t{0} {1} {2:c} per hour.", w.FirstName, w.LastName, w.MoneyPerHour());
            }

            List<Human> all = students.Concat<Human>(workers)
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .ToList<Human>();

            Console.WriteLine("All humans sorted by first and last name:");
            foreach (var h in all)
            {
                Console.WriteLine("\t{0} {1}", h.FirstName, h.LastName);
            }
        }
    }
}
