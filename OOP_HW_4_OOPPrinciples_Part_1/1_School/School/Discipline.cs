using System;

namespace _1_School.School
{
    public class Discipline : ICommentable
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            Name = name;
            NumberOfLectures = numberOfLectures;
            NumberOfExercises = numberOfExercises;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "Number of lectures cannot be negative");
                }
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "Number of exercises cannot be negative");
                }
                this.numberOfExercises = value;
            }
        }

        public string Comments { get; set; }
    }
}
