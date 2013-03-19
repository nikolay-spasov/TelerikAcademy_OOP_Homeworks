using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_School.School
{
    public class Student : Person
    {
        private short id;

        public Student(short id, string name, string comments)
        {
            Id = id;
            Name = name;
            Comments = comments;
        }

        public Student(short id, string name) : this(id, name, null) { }

        public short Id
        {
            get
            {
                return id;
            }

            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(
                        "Student id must be greater than or equal to 1");
                }

                this.id = value;
            }
        }
    }
}
