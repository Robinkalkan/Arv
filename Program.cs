namespace Zoo;

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

public class Dog : Animal
{
    public string Breed { get; set; }

    public Dog(string name, int age, double weight, string breed)
        : base(name, age, weight, "Dog", true)
    {
        Breed = breed;
    }

    public void Fetch()
    {
        Console.WriteLine("Hunden jagar en boll.");
    }
}

public class Cat : Animal
{
    public bool IsLazy { get; set; }

    public Cat(string name, int age, double weight, bool isLazy)
        : base(name, age, weight, "Cat", true)
    {
        IsLazy = isLazy;
    }

    public void Purr()
    {
        Console.WriteLine("Katten spinner.");
    }
}

public class Tiger : Cat
{
    public bool HasStripes { get; set; }

    public Tiger(string name, int age, double weight, bool hasStripes)
        : base(name, age, weight, true)
    {
        HasStripes = hasStripes;
    }

    public void Roar()
    {
        Console.WriteLine("Tigern Ryter.");
    }
}

public class Wolf : Animal
{
    public bool IsPackAnimal { get; set; }

    public Wolf(string name, int age, double weight, bool isPackAnimal)
        : base(name, age, weight, "Wolf", true)
    {
        IsPackAnimal = isPackAnimal;
    }

    public void Howl()
    {
        Console.WriteLine("Vargen ylar.");
    }
}

public class Lion : Animal
{
    public bool HasMane { get; set; }

    public Lion(string name, int age, double weight, bool hasMane)
        : base(name, age, weight, "Lion", true)
    {
        HasMane = hasMane;
    }

    public void Hunt()
    {
        Console.WriteLine("Lejonet Jagar sitt byte.");
    }
}


class Program
{
    static void Main()
    {
        Animal lion = new Lion("Lionboss", 12, 234, true);
        Dog chowchow = new Dog("Pandora", 9, 24, "Chowchow");
        Cat siameseCat = new Cat("Cattycat", 4, 10, false);
        Tiger bengalTiger = new Tiger("Tigery", 34, 180, true);
        Wolf grayWolf = new Wolf("gråvargen", 20, 111, true);

        lion.MakeSound();
        chowchow.MakeSound();
        siameseCat.MakeSound();
        bengalTiger.MakeSound();
        grayWolf.MakeSound();

        Console.WriteLine("-----------");

        chowchow.Fetch();
        grayWolf.Howl();
        siameseCat.Purr();
        bengalTiger.Roar();
        if (lion is Lion lionObj)
        {
            lionObj.Hunt();
        }
    }


}









