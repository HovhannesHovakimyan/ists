using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N natural number:");
            int n = Convert.ToInt32(Console.Read());

            int i;
            float n1 = 1, result = 1;

            for (i = 1; i < n; i++)
            {
                n1 *= i;
                result += 1 / n1;
            }

            Console.WriteLine($"result: {result}");
            Console.ReadKey();
        }
    }
}