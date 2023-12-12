// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//abstract class Aniaml
//{
//    public abstract void MakeNoise();
//}

//class Dog : Aniaml
//{
//    public override void MakeNoise()
//    {
//        Console.WriteLine("Wof wof!");
//    }
//}

class Animal
{
    public virtual void MakeNoise()
    {
        Console.WriteLine("Animal makes a noise!");
    }
}

class Dog
{
    public void AddYears(int years)
    {
        Console.WriteLine();
    }

    public void AddYears(double years)
    {
    }
}
