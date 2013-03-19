using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_School.School
{
    public class Teacher : Person
    {
        private List<Discipline> disciplines;

        public Teacher(string name, IEnumerable<Discipline> disciplines)
        {
            this.Name = name;
            this.disciplines = disciplines.ToList();
        }

        public IEnumerable<Discipline> Disciplines
        {
            get { return this.disciplines; }
        }

        public void AddDiscipline(Discipline discipline)
        {
            disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            disciplines.Remove(discipline);
        }
    }
}
