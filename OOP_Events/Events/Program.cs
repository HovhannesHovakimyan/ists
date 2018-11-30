using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    delegate void AccountStateHandler(object sender, AccountEventArgs e);

    class AccountEventArgs
    {
        public string Message { get; }
        public int Sum { get; }
        public AccountEventArgs(string message, int sum)
        {
            Message = message;
            Sum = sum;
        }
    }

    class Account
    {
        int sum;
        //AccountStateHandler deleg;

        public event AccountStateHandler Added; // (already done) Delegate that represents this event
        public event AccountStateHandler Adding; // (before its done)
        public event AccountStateHandler Withdrawn; // (already done)

        //public void RegisterHandler(AccountStateHandler deleg)
        //{
        //    this.deleg += deleg;
        //}
        //public void UnRegisterHandler(AccountStateHandler deleg)
        //{
        //    this.deleg -= deleg;
        //}

        public Account(int sum)
        {
            this.sum = sum;
        }
        public void Put(int sum)
        {
            if (Adding != null) Adding(this, new AccountEventArgs($"{this.sum} amount of money is being added on your account", sum));
            this.sum += sum;
            if (Added != null) Added(this, new AccountEventArgs($"added {sum} amount of money on your account", sum));
        }
        public void Withdraw(int sum)
        {
            if (this.sum >= sum)
            {
                this.sum -= sum;
                if (Withdrawn != null) Withdrawn(this, new AccountEventArgs($"withdrawed {sum} amount of money from your account", sum));
            }
            else
            {
                if (Withdrawn != null) Withdrawn(this, new AccountEventArgs($"not enough money on your account to withdraw amount of {sum}", sum));
            }
        }
    }

    class Program
    {
        static void Display(object sender, AccountEventArgs e)
        {
            Console.WriteLine($"Amount of transaction: {e.Sum}");
            Console.WriteLine(e.Message);
        }
        static void ColorDisplay(object sender, AccountEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Amount of transaction: {e.Sum}");
            Console.WriteLine(e.Message);
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            Account account = new Account(100);

            //account.RegisterHandler(Display);
            account.Added += Display;
            account.Put(100);

            account.Withdrawn -= Display;
            account.Withdrawn += ColorDisplay;
            account.Withdraw(100);

            //account.UnRegisterHandler(Display);
            //account.RegisterHandler(ColorDisplay);
            account.Withdraw(150);

            //account.RegisterHandler(Display);
            //account.UnRegisterHandler(ColorDisplay);
            account.Put(200);

            Console.ReadKey();
        }
    }
}
