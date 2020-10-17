using System;
using static System.Console;
namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            ForegroundColor = ConsoleColor.Black;
            int count = 1;
            foreach (var color in colors)
            {
                BackgroundColor = color;
                Write("{0,3} ", count++);
                WriteLine(" " + color.ToString());
            }

        }
    }
}