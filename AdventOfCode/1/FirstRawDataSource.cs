using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode
{
    public class FirstRawDataSource : AdventOfCodeRawDataSource
    {
        public IEnumerable<string?> LoadRawData()
        {
            using var stream = Load();
            using TextReader reader = new StreamReader(stream);
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                yield return line;
            }
        }

        protected override string FileNameAndExtension => "1.txt";
    }
}