using System;
using LotteryNumberGeneratorConsoleApp.Interfaces;
using LotteryNumberGeneratorConsoleApp.Services;

namespace LotteryNumberGeneratorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfSets = 0;
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine("How many sets of Lottery Numbers are required? Please enter the number:");
                try
                {
                    countOfSets = int.Parse(Console.ReadLine());
                    if (countOfSets < 1)
                    {
                        Console.WriteLine("number of sets can not be lesser than 1");
                    }
                    else
                    {
                        validInput = true;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

            var randomNumberGenerator = new RandomNumberGeneratorService();
            var display = new DisplayWithColours();
            var writeToFile = new WriteToFile();
            IGenerateuniqueLotterySets generateuniqueLotterySets = new GenerateUniqueLotterySets(randomNumberGenerator);

            var resultSet = generateuniqueLotterySets.GetUniqueLotterySets(countOfSets);
            display.DisplayLotteryNumbersWithColours(resultSet);
            writeToFile.WriteLotterySetsToFil(resultSet);
        }
    }
}
