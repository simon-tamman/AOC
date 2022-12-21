using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode._2
{
    public class SecondDataSource
    {
        public IEnumerable<RpsStrategy> Load(Strategy strategy = Strategy.Part1)
        {
            var raw = new SecondRawDataSource();
            foreach (var line in raw.LoadRawData())
            {
                if (line == null) throw new WtfException("Line in input file unexpectedly null");
                var opponent = line.First();
                var player = line.Skip(2).First();
                var opponentOption = ConvertOpponentOption(opponent);
                var playerOption = strategy == Strategy.Part1 ? ConvertPlayerOptionStrategy1(player) : ConvertPlayerOptionStrategy2(player, opponentOption);
                yield return new RpsStrategy(opponentOption, playerOption);
            }
        }

        private static Option ConvertPlayerOptionStrategy1(char player)
        {
            return player switch
            {
                'X' => Option.Rock,
                'Y' => Option.Paper,
                'Z' => Option.Scissors,
                _ => throw new WtfException("Unexpected player option: " + player)
            };
        }
        
        private static Option ConvertPlayerOptionStrategy2(char player, Option opponent)
        {
            return player switch
            {
                'X' => opponent switch
                {
                    Option.Rock => Option.Scissors,
                    Option.Paper => Option.Rock,
                    _ => Option.Paper
                },
                'Y' => opponent,
                'Z' => opponent switch
                {
                    Option.Rock => Option.Paper,
                    Option.Paper => Option.Scissors,
                    _ => Option.Rock
                },
                _ => throw new WtfException("Unexpected player option: " + player)
            };
        }

        private static Option ConvertOpponentOption(char opponent)
        {
            return opponent switch
            {
                'A' => Option.Rock,
                'B' => Option.Paper,
                'C' => Option.Scissors,
                _ => throw new WtfException("Unexpected opponent option: " + opponent)
            };
        }
    }

    public enum Strategy
    {
        Part1 = 0,
        Part2 = 1
    }
}