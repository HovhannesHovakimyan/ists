using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Human
    {
        private int age;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (age > 0)
                {
                    age = value;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human mard1 = new Human();
            Console.WriteLine("Enter you age:");
            mard1.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"My age is {mard1.Age}");
        }
    }
}
