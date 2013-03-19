using System;

namespace _2_Humans.Model
{
    public class Student : Human
    {
        private double grade;

        public double Grade
        {
            get { return this.grade; }
            set
            {
                if (value < 2d)
                {
                    throw new ArgumentOutOfRangeException(
                        "Grade cannot be less than 2.");
                }
                grade = value;
            }
        }

        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
    }
}
