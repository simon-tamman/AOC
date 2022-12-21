namespace AdventOfCode._2
{
    public class RpsStrategy
    {
        public Option OpponentOption { get; }
        public Option PlayerOption { get; }
        
        public RpsStrategy(Option opponentOption, Option playerOption)
        {
            OpponentOption = opponentOption;
            PlayerOption = playerOption;
        }

        public int CalculateScore()
        {
            var score = (int)PlayerOption;
            score += (int)CalculateResult(OpponentOption, PlayerOption);
            return score;
        }

        private static Result CalculateResult(Option opponentOption, Option playerOption)
        {
            if (opponentOption == playerOption) return Result.Draw;
            return opponentOption switch
            {
                Option.Rock => playerOption == Option.Scissors ? Result.Lose : Result.Win,
                Option.Paper => playerOption == Option.Rock ? Result.Lose : Result.Win,
                Option.Scissors => playerOption == Option.Paper ? Result.Lose : Result.Win,
                _ => throw new WtfException("Unexpected option: " + opponentOption)
            };
        }
    }
}