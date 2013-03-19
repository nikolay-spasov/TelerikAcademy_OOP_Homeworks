using System;

namespace _3_Animals.Model
{
    public class Kitten : Cat
    {
        public Kitten(int age, string name)
            : base(age, name, 'f') { }
    }
}
