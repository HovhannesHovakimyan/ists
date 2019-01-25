using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translit_to_Armenian_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // for correctly displaying Armenian characters

            Console.WriteLine("Մուտքագրեք հայերեն բառը անգլերեն տառերով՝ հայերեն տառերի փոխակերպելու համար");

            string input = Console.ReadLine();
            string outt = Transliteration.Front(input);

            Console.WriteLine(outt);

            Console.ReadKey();
        }
    }
}
