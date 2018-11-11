using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Inheritance
{
    class Human
    {
        public string name { get; set; }
        public string sex { get; set; }
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

        public void sayHello()
        {
            Console.WriteLine("Hello people!");
        }
    }

    class Alkash : Human
    {
        public int gradus { get; set; }

        public void sayBarlusner()
        {
            Console.WriteLine("Bayylusner boooloriin");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Alkash mard1 = new Alkash
            {
                name = "Valodik",
                sex = "male"
            };

            Console.WriteLine(mard1.name);
            Console.WriteLine(mard1.sex);

            mard1.sayBarlusner();

            Console.ReadKey();
        }
    }
}
