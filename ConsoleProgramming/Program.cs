using System;

namespace ConsoleProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, enter your name ");
            var name = Console.ReadLine();
            Console.WriteLine("Surname: ");
            var sname = Console.ReadLine();
            Console.WriteLine("Hello, "+ name + " "+ sname);
        }
    }
}