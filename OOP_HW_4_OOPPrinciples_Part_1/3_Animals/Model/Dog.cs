using System;

namespace _3_Animals.Model
{
    public class Dog : Animal
    {
        public Dog(int age, string name, char sex)
            : base(age, name, sex) { }

        public override void MakeSound()
        {
            Console.WriteLine("Woof.");
        }
    }
}
