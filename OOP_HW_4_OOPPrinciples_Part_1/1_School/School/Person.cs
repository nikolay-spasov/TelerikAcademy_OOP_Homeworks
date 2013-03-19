using System;

namespace _1_School.School
{
    public abstract class Person : ICommentable
    {
        public string Name { get; protected set; }

        public string Comments { get; set; }
    }
}
