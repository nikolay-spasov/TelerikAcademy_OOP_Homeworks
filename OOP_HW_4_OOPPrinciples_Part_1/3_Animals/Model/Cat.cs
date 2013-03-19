using System;

namespace _3_Animals.Model
{
    public class Cat : Animal
    {
        public Cat(int age, string name, char sex)
            : base(age, name, sex) { }

        public override void MakeSound()
        {
            Console.WriteLine("Miau.");
        }
    }
}
