using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct MyStruct
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"my name is {Name} and I'm {Age} years old.\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct person = new MyStruct();
            person.Name = "Valod";
            person.Age = 18;

            person.DisplayInfo();

            //Delay
            Console.ReadKey();
        }
    }
}
