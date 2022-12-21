using System;
using System.Linq;

namespace AdventOfCode
{
    public class FirstAnswers
    {
        public static int FindMostCalories()
        {
            var source = new FirstDataSource();
            var data = source.Load();
            var bestElf = data.First();
            foreach (var elf in data.Skip(1))
            {
                if (elf.TotalCalories > bestElf.TotalCalories) bestElf = elf;
            }
            return bestElf.TotalCalories;
        }
        
        public static int FindSumOfTopThreeCalories()
        {
            var source = new FirstDataSource();
            var data = source.Load().ToList();
            data.Sort(SortByHighestCalories);
            return data.Take(3).Sum(x => x.TotalCalories);
        }

        private static int SortByHighestCalories(FirstElf a, FirstElf b) => b.TotalCalories.CompareTo(a.TotalCalories);
    }
}