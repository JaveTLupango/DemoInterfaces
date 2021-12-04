using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog("Goshy", "arf");
            var cat = new Cat("Ming2x", "Meow");
            dog.Details();
            cat.Details();
        }
    }
}

interface IAnimal
{
    void Details();
}

class Dog : IAnimal
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


class Cat : IAnimal
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