using System.Collections.Generic;

namespace AdventOfCode
{
    public class FirstDataSource
    {
        public IEnumerable<FirstElf> Load()
        {
            var raw = new FirstRawDataSource();
            int id = 1;
            var elf = new FirstElf(id++);
            foreach (var line in raw.LoadRawData())
            {
                if (string.IsNullOrEmpty(line))
                {
                    yield return elf;
                    elf = new FirstElf(id++);
                }
                else
                {
                    elf.AddFood(int.Parse(line));
                }
            }
            if (elf == null) throw new WtfException("elf should not be null (the entire file is empty?)");
            yield return elf;
        }
    }
}