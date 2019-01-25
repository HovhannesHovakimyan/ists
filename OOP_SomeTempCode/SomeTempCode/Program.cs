using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        class SomeClass
        {
            public static int X { get; set; }
            public static int Y { get; set; }
            public readonly int Z;

            static SomeClass()
            {
                X = 10;
                Y = 20;
            }

            public SomeClass(int z)
            {
                Z = z;
            }
        }
        static void Main(string[] args)
        {

            SomeClass.X = 17;

            Console.WriteLine(SomeClass.X);
            SomeClass d = new SomeClass(89);

            //d.Z = 73;

            Console.WriteLine(d.Z);

            Console.ReadKey();
        }
    }
}