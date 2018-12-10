using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ref
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 5;
            ref int refOfX = ref x;

            Console.WriteLine(x); // 5
            Console.WriteLine(refOfX); // 5

            refOfX = 125;
            Console.WriteLine(x); // 125

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            ref int nRef = ref Find(numbers, 4);
            Console.WriteLine(numbers[3]); // 4

            nRef = 45;
            Console.WriteLine(numbers[3]); // 45

            Console.ReadKey();
        }
        static ref int Find(int[] numbers, int number)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return ref numbers[i];
                }
            }
            throw new Exception("Number not found");
        }
    }
}
