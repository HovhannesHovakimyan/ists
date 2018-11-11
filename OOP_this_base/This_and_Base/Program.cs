using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_and_Base
{
    class Book
    {
        public int ID { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.ID = 1;

            ChangeID(book);

            Console.WriteLine(book.ID);
        }

        static void ChangeID(Book book)
        {
            book.ID = -1;
        }
    }
}
