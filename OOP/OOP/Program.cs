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
                if (value > 0)
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
            Human mard1 = new Human
            {
                Age = 30
            };

            Printmethod(mard1);
        }

        static void Printmethod(Human mard1)
        {
            int age = mard1.Age;

            Console.WriteLine($"my age is {age}");
            Console.ReadKey();
        }
    }
}
