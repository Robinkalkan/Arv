using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
    public string Species { get; set; }
    public bool Senses { get; set; }

    public Animal(string name, int age, double weight, string species, bool senses)
    {
        Name = name;
        Age = age;
        Weight = weight;
        Species = species;
        Senses = senses;
    }

public void MakeSound()
{
    Console.WriteLine("Djuret Gör ett läte.");
}

public void Eat()
{
    Console.WriteLine("Djuret Gör ett läte.");
}

public void Sleep()
{
    Console.WriteLine("Djuret Gör ett läte.");
}

    public void Roar()
    {
        Console.WriteLine("The tiger is roaring.");
    }
}