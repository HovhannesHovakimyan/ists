using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Animal
    {
        public string Name { get; set; }

        public virtual void GetRoar() //has specificator "virtual"
        {
            Console.WriteLine($"{Name} says some abstract roar\n");
        }
    }

    class Cat : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine($"{Name} says myau-myau\n");
        }
    }
    class Dog : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine($"{Name} says haf-haf\n");
        }
    }
    class Rat : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine($"{Name} says pi-pi-pi\n");
        }
    }
    class Alkash : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine($"{Name} says araaaa hl@ ekeq steee asem\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[4];

            Cat cat = new Cat();
            cat.Name = "Bubusik";

            Dog dog = new Dog();
            dog.Name = "Sharik";

            Rat rat = new Rat();
            rat.Name = "Iriska";

            Alkash mard = new Alkash();
            mard.Name = "Valod";

            animals[0] = cat;
            animals[1] = dog;
            animals[2] = rat;
            animals[3] = mard;

            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].GetRoar();
            }


            Alkash alkash = new Alkash();
            alkash.Name = "Saqulik";

            Animal animal = alkash;
            animal.GetRoar();

            Console.ReadKey();
        }
    }
}
