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



            //converting object instance type
            //every alkash is human, but not every human can be alkash (see DOWNCAST!)

            Human mard = mard1; // this is called UPCAST, converting concrete type to general

            Console.WriteLine($"\n{mard.name}");
            Console.WriteLine(mard.sex);

            mard.sayHello();



            //DOWNCAST, converting general to concrete type
            bool isAlkash = mard is Alkash;

            if (isAlkash)
            {
                Alkash mard3 = (Alkash)mard; // mard karoxacanq Alkash darcnel, vorovhetev na inch vor jamanak araj arden exel er Alkash

                Console.WriteLine($"\n{mard3.name}");
                Console.WriteLine(mard3.sex);
                Console.WriteLine($"{mard3.gradus}% tnakan qashac pshenichni arax");

                mard3.sayHello();
                mard3.SayBarlusner();
            }



            Alkash mard4 = mard as Alkash;

            if (mard4 != null)
            {
                Console.WriteLine("\n");
                Console.WriteLine(mard4.name);
                Console.WriteLine(mard4.sex);
                Console.WriteLine($"{mard4.gradus}% tnakan qashac pshenichni arax");

                mard4.sayHello();
                mard4.SayBarlusner();
            }

                Console.ReadKey();
        }
    }
}
