using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Demos
{
    public class Dog
    {
        public Dog()
        {
            Age = 0;
        }

        public Dog(string name, string breed)
        {
            Name = name;
            Breed = breed;
            Age = 1;
        }

        public Dog(string name, string breed, int age)
        {
            Name = name;
            Breed = breed;
            Age = age * 12;
        }

        public string Name { get; set; }

        public string Breed { get; set; }

        public int Age { get; set; }

        public void Bark()
        {
            Console.WriteLine($"{Name}: Bau Bau");
        }
    }
}
