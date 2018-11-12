using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Overload
{
    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Human() { }

        public Human(string name)
        {
            Name = name;
        }

        public Human(string name, int age) : this(name)
        {
            Age = age;
        }
    }

    class Freak : Human
    {
        public string DrugType { get; set; }

        public Freak(string name, int age, string drugType) : base(name, age)
        {
            DrugType = drugType;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
