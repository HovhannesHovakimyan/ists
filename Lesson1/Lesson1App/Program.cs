using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1App
{
    public class Dog
    {
        private string anun;
        public void hachal()
        {
            Console.WriteLine($"my dog's name is {anun} and he is woofing");
            Console.ReadKey();
        }

        public Dog(string name)
        {
            anun = name;
        }

        // Remaining implementation of Person class.
    }

    class Program
    {

        static void Main(string[] args)
        {
            Dog myDog = new Dog("Sharik");
            myDog.hachal();
        }
    }
}
