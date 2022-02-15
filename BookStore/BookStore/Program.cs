using System;

namespace BookStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Check if such a book already exists, if so add a counter to an existing one (For example a book is saved like this "Twilight 7"
            //2.Create a Reader entity which is capable of "borrowing" a book which means getting it from file(therefore removing 1 from counter) and putting it into a private list.
            //3. Create a method in a Reader class to give a book back therefore adding +1 in a file and removing from its private list.

            Console.WriteLine("Hello World!");
        }
    }
}
