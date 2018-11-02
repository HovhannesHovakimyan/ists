using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task33
{
    class Program
    {
        class Car
        {
            // Fields
            public string Title; // Car brand
            public double Fuel; // Fuel in reservoir
            public double RateFuel; // Fuel consumption

            // Methods
            public void Go() // Car movement
            {
                if(Fuel < RateFuel)
                {
                    Console.WriteLine($"Your {Title} run out of fuel");
                }
                else
                {
                    Fuel = Fuel - RateFuel;
                    Console.WriteLine($"You {Title} car has {Fuel} units of fuel");
                }
            }
        }
        static void Main(string[] args)
        {
            Car car1 = new Car
            {
                Title = "BMW",
                Fuel = 8,
                RateFuel = 2.2
            };

            Car car2 = new Car
            {
                Title = "Mercedes",
                Fuel = 9,
                RateFuel = 2.8
            };

            int count = 0;

            while(car1.Fuel > car1.RateFuel || car2.Fuel > car2.RateFuel)
            {
                car1.Go();
                car2.Go();
                count++;
                Console.WriteLine($"\t{count} km left");
            }

            Console.ReadKey();
        }
    }
}
