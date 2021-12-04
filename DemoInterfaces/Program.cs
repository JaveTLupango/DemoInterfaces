using System;

namespace DemoInterfaces
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var dog = new Dog("Goshy", "arf");
            var cat = new Cat("Ming2x", "Meow");
            dog.Details();
            cat.Details();
        }
    }
}

internal interface IAnimal
{
    void Details();
}

internal class Dog : IAnimal
{
    public string name { get; set; }
    public string sound { get; set; }

    public Dog(string name, string sound)
    {
        this.name = name;
        this.sound = sound;
    }

    public void Details()
    {
        Console.WriteLine(" - - - - - - -  - -");
        Console.WriteLine("Dog");
        Console.WriteLine("Name:" + name);
        Console.WriteLine("Sound" + sound);
    }
}

internal class Cat : IAnimal
{
    public string name { get; set; }
    public string sound { get; set; }

    public Cat(string name, string sound)
    {
        this.name = name;
        this.sound = sound;
    }

    public void Details()
    {
        Console.WriteLine(" - - - - - - -  - -");
        Console.WriteLine("Cat");
        Console.WriteLine("Name:" + name);
        Console.WriteLine("Sound" + sound);
        Console.WriteLine(" - - - - - - -  - -");
    }
}