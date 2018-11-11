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
        protected void Oyaxnal()
        {
            Console.WriteLine("Gorci gnal ka ban ka... Knik spasi heto");
        }

        public void SayBarlusner()
        {
            Console.WriteLine("Bayylusner boooloriin");
        }
    }

    class UltraAlkash : Alkash
    {
        public void BujieqIndz()
        {
            Console.WriteLine("chay tveq, mernum em!");
        }

        public void SayBarlusner()
        {
            Console.WriteLine("prrrrivet. buuuuu araaaa");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Alkash mard1 = new Alkash
            {
                name = "Valodik",
                sex = "male",
                gradus = 40
            };

            Console.WriteLine(mard1.name);
            Console.WriteLine(mard1.sex);
            Console.WriteLine($"{mard1.gradus}% lus-astx oxi");

            mard1.SayBarlusner();


            UltraAlkash mard2 = new UltraAlkash
            {
                name = "Saqulik",
                sex = "male",
                gradus = 80
            };

            Console.WriteLine($"\n{mard2.name}");
            Console.WriteLine(mard2.sex);
            Console.WriteLine($"{mard2.gradus}% tnakan qashac pshenichni arax");
            mard2.SayBarlusner();
            mard2.BujieqIndz();

            Console.ReadKey();
        }
    }
}
