using System;

namespace _3_Animals.Model
{
    public abstract class Animal : ISound
    {
        private int age;
        private char sex;

        public Animal(int age, string name, char sex)
        {
            Age = age;
            Name = name;
            Sex = sex;
        }

        public int Age
        {
            get { return this.age; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "Age cannot be negative");
                }
                age = value;
            }
        }

        public string Name { get; protected set; }

        public char Sex 
        {
            get { return this.sex; }
            protected set
            {
                if (value != 'm' && value != 'f')
                {
                    throw new ArgumentException(
                        "Sex must be 'm' or 'f'.");
                }
                sex = value;
            }
        }

        public abstract void MakeSound();
    }
}
