using System.Linq;

namespace AdventOfCode
{
    public class FindElfWithMostCalories
    {
        public static int Find()
        {
            var source = new FirstDataSource();
            var data = source.Load();
            var bestElf = data.First();
            foreach (var elf in data.Skip(1))
            {
                if (elf.TotalCalories > bestElf.TotalCalories) bestElf = elf;
            }
            return bestElf.Id;
        }
    }
}