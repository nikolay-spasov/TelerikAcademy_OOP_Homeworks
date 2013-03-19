using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_School.School
{
    public class Class : ICommentable
    {
        private List<Teacher> teachers;

        public Class(IEnumerable<Teacher> teachers, string comments)
        {
            Id = Guid.NewGuid().ToString();
            this.teachers = teachers.ToList();
            Comments = comments;
        }

        public Class(IEnumerable<Teacher> teachers) : this(teachers, null) { }

        public string Id { get; private set; }

        public IEnumerable<Teacher> Teachers
        {
            get { return this.teachers; }
        }

        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            teachers.Remove(teacher);
        }

        public string Comments { get; set; } 
    }
}
