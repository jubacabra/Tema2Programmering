using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Programmering
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int Throw = ran.Next(1, 7);
            while (Throw < 6)
            {
                Throw = ran.Next(1, 7);
                if (Throw == 1)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Du slog 1!");
                }
                if (Throw == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Du slog 2!");
                }
                if (Throw == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Du slog 3!");
                }
                if (Throw == 4)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Du slog 4!");
                }
                if (Throw == 5)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Du slog 5!");
                }
                if (Throw == 6)
                {
                    Console.WriteLine("Du slog 6!");
                }

            }
            
        }
    }
}
