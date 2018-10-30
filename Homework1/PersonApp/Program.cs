using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    public class Person
    {
        string firstName;
        string lastName;
        int age;
        int height;

        public void yourQuestion()
        {
            Console.WriteLine("\nHello dear user! Type in please some information about the person you are interested in.\n");

            Console.WriteLine("\nWhat is the first name?");
            string fName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("\nWhat is the last name?");
            string lName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("\nWhat age is that person?");
            string personAge = Convert.ToString(Console.ReadLine());

            Console.WriteLine("\nWhat height that person has (in cm)?");
            string personHeight = Convert.ToString(Console.ReadLine());

            Console.WriteLine($"\n\nIn our database we found {fName} {lName} who is {personAge} years old and has {personHeight}cm height.\n");
            Console.WriteLine("\nThis person can speak, eat, walk and talk...\n");
            Console.WriteLine("\nWhat would you like this person to do now?\n");
            Console.WriteLine("\nType your command\n");

            string inputCommand = Convert.ToString(Console.ReadLine());

            switch (inputCommand)
            {
                case "speak":
                    Console.WriteLine($"{fName} {lName} is speaking with you now");
                    break;
                case "eat":
                    Console.WriteLine($"{fName} {lName} is eating a healthy food now, so this person's {height} height will increase soon!");
                    break;
                case "walk":
                    Console.WriteLine($"{fName} {lName} is walking now to stay lean!");
                    break;
                case "sleep":
                    Console.WriteLine($"{fName} {lName} is sleeping now, so quite please!!!");
                    break;
                default:
                    Console.WriteLine("\nYou probably used a command that this person is not understanding yet. \n\nWe already sent highly trained monkeys to fix this issue...");
                    break;
            }

            Console.WriteLine("\n\nThanks for choosing our service. Now just hit any key to close this program.");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person example = new Person();
            example.yourQuestion();
            Console.ReadKey();
        }
    }
}
