using System;
using System.Collections.Generic;

namespace LotteryNumberGeneratorConsoleApp.Interfaces
{
    public interface IGenerateuniqueLotterySets
    {
        public List<Array> GetUniqueLotterySets(int number);
    }
}
