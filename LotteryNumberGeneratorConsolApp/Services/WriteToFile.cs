using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LotteryNumberGeneratorConsoleApp.Services
{
    public class WriteToFile
    {
        public void WriteLotterySetsToFil(List<Array> lotterySets)
        {
            using (var writer = new StreamWriter(@"C:\Users\SIVA SANKAR\Downloads\Lottery_Set_File.txt"))
            {
                int setCount = 1;
                foreach (var set in lotterySets)
                {
                    StringBuilder lotteryNumber = new StringBuilder();
                    foreach(int number in set)
                    {
                        lotteryNumber.Append(number.ToString("D2"));
                    }
                    writer.WriteLine("Lottery Set {0} is {1}", setCount, lotteryNumber);
                    setCount++;
                }
            }
        }
    }
}
