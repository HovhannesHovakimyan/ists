using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1000, 6);
            Account acc2 = new Account(900, 5);
            Account.MinSum = 200;
            Account.GetSum(1000, 10, 5);
            //acc2.MinSum = 200;
            //Console.WriteLine(acc1.GetSum(1000, 10, 5));
            //Console.WriteLine(acc2.GetSum(1000, 10, 5));

            Console.ReadKey();
        }
    }
    class Account
    {
        //minimal money amount on account opening
        private static decimal minSum = 100;
        public Account(decimal sum, decimal rate)
        {
            if (sum < MinSum) throw new Exception("Amount is not allowed");
            Sum = sum; Rate = rate;
        }
        public static decimal MinSum
        {
            get { return minSum; }
            set { if (value > 0) minSum = value; }
        }
        public decimal Sum { get; private set; } // money amount on account
        public decimal Rate { get; private set; } // rate

        // money amount calculation after given time and rate
        public static decimal GetSum(decimal sum, decimal rate, int period)
        {
            decimal result = sum;
            for (int i = 1; i < period; i++)
                result = result + result * rate / 100;

            return result;
        }
    }
}
