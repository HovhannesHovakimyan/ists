using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate2
{
    delegate void AccountStateHandler(string message);

    class Account
    {
        int sum;
        AccountStateHandler deleg;

        public void RegisterHandler(AccountStateHandler deleg)
        {
            this.deleg += deleg;
        }
        public void UnRegisterHandler(AccountStateHandler deleg)
        {
            this.deleg -= deleg;
        }

        public Account(int sum)
        {
            this.sum = sum;
        }
        public void Put(int sum)
        {
            this.sum += sum;
            if (deleg != null)
            {
                deleg($"added {sum} amount of money on your account");
            }
        }
        public void Withdraw(int sum)
        {
            if (this.sum >= sum)
            {
                this.sum -= sum;
                if (deleg != null)
                {
                    deleg($"withdrawed {sum} amount of money from your account");
                }
            }
            else
            {
                if (deleg != null)
                {
                    deleg($"not enough money on your account to withdraw amount of {sum}");
                }
            }
        }
    }

    class Program
    {
        static void Display(string message)
        {
            Console.WriteLine(message);
        }
        static void ColorDisplay(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            Account account = new Account(100);

            account.RegisterHandler(Display);
            account.Put(100);

            account.Withdraw(100);

            account.UnRegisterHandler(Display);
            account.RegisterHandler(ColorDisplay);
            account.Withdraw(150);

            account.RegisterHandler(Display);
            account.UnRegisterHandler(ColorDisplay);
            account.Put(200);

            Console.ReadKey();
        }
    }
}
