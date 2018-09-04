using LegoMinifigures.Heads;
using System;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new TomHead();

            var figure = new Minifigure(head);

            figure.DoStuff();

            Console.ReadLine();
        }
    }
}
