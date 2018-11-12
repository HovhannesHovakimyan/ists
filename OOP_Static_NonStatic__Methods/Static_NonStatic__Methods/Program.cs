using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_NonStatic__Methods
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string argFirstName, string argLastName)
        {
            FirstName = argFirstName;
            LastName = argFirstName;

            //FormatFullName(FirstName, LastName); //also this can be done
        }

        public static string FormatFullName(string argFirstname, string argLastName)
        {
            return $"{argFirstname} - {argLastName}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Testik", "Testikyan");

            Console.WriteLine(Person.FormatFullName("Testik", "Testikyan"));

            Console.ReadKey();
        }
    }
}
