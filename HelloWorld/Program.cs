using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Wat is uw naam?");
            string username = Console.ReadLine();
            Console.WriteLine("Welkom in Developer Land " + username + "!");
            Console.WriteLine("Het attractiepark voor ontwikkelaars over de hele wereld.");
            Console.ReadKey();
        }
    }
}
