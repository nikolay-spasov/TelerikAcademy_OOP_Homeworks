using System;

namespace _3_Animals.Model
{
    public class Frog : Animal
    {
        public Frog(int age, string name, char sex)
            : base(age, name, sex) { }

        public override void MakeSound()
        {
            Console.WriteLine("Quack.");
        }
    }
}
