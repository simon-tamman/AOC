using System.Collections.Generic;

namespace AdventOfCode
{
    public class FirstDataSource
    {
        public IEnumerable<FirstElf> Load()
        {
            var raw = new FirstRawDataSource();
            FirstElf? elf = null;
            foreach (var line in raw.LoadRawData())
            {
                if (string.IsNullOrEmpty(line))
                {
                    if (elf != null) yield return elf;
                    elf = new FirstElf();
                }
                else
                {
                    if (elf == null) throw new WtfException("elf should not be null (the first line is empty?)");
                    elf.AddFood(int.Parse(line));
                }
            }
            if (elf == null) throw new WtfException("elf should not be null (the entire file is empty?)");
            yield return elf;
        }
    }
}