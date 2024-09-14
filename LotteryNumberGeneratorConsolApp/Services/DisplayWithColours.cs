using System;
using System.Collections.Generic;

namespace LotteryNumberGeneratorConsoleApp.Services
{
    public class DisplayWithColours
    {
        public void DisplayLotteryNumbersWithColours(List<Array> lotterySets)
        {
            foreach(var set in lotterySets)
            {
                foreach(int number in set)
                {
                    if(number<=9)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    else if(number<=19)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }
                    else if (number <= 29)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }
                    else if (number <= 39)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (number <= 49)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    Console.Write($"{number:D2}");
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}
