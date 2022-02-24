using System;

namespace _00.Demos
{
    class Cat
    {
        // new Cat()
        public Cat()
        {
            this.Name = "Default catName";
            this.Weight = 5;
            this.Age = 1;
        }

        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.IsAlive = true;
        }

        public Cat(string name, int age, double weight)
        {
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
            this.IsAlive = true;
        }

        public string Breed { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public double Weight { get; set; }

        public bool IsAlive { get; set; }

        public bool IsOverweight
        {
            get
            {
                if (this.Weight > 10)
                {
                    return true;
                }

                return false;
            }
        }

        //public bool IsOverweight()
        //{
        //    if (this.Weight > 10)
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        public int CalcualteCatYears(int oneCatYearValue)
        {
            return oneCatYearValue * this.Age;
        }

        public string SayName()
        {
            return $"My name is {this.Name}";
        }
    }

    class ProgramTest
    {
        static void Main(string[] args)
        {
            Cat firstCat = new Cat("Maria", 5);

            //Cat firstCat = new Cat();
            //firstCat.Name = "Maria";
            //firstCat.Age = 5;
            //firstCat.Weight = 5.4;
            //firstCat.IsAlive = true;
            string greeting = firstCat.SayName();
            Console.WriteLine(greeting);
            bool isOverweight = firstCat.IsOverweight;

            Console.WriteLine($"Name: {firstCat.Name} Age: {firstCat.Age}");

            Cat secondCat = new Cat()
            {
                Name = "Maca",
                Age = 6,
                Weight = 33.3,
                IsAlive = true
            };

            secondCat.SayName();
            bool isSecondOverweight = firstCat.IsOverweight;

            Console.WriteLine($"Name: {secondCat.Name} Age: {secondCat.Age}");

            Cat thirdCat = new Cat("Galia");

            Console.WriteLine($"Name: {thirdCat.Name} Age: {thirdCat.Age}");
        }
    }
}
