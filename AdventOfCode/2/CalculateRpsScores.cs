using System.Linq;

namespace AdventOfCode._2
{
    public class CalculateRpsScores
    {
        public static int Calculate(Strategy strategy = Strategy.Part1)
        {
            var datasource = new SecondDataSource();
            var data = datasource.Load(strategy);
            return data.Sum(x => x.CalculateScore());
        }
    }
}