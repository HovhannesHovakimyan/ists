using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        delegate void Message();
        delegate int Operation(int x, int y);

        static void Display() //compatible with Message() delegate
        {
            Console.WriteLine("Hello");
        }

        static void Main(string[] args)
        {
            Message message; //delegate determines a type, so variable can be that type
            message = Display; //give a method which variable will point to

            //massage = new Message(Display); //another way to pass method by creating object and passing method to it's constructor

            //message.Invoke();  //another way to call delegate
            message();

            Console.ReadKey();
        }
    }
}
