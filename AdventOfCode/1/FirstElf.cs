using System.Collections.Generic;

namespace AdventOfCode
{
    public class FirstElf
    {
        private readonly List<FirstFood> food = new List<FirstFood>();
        public IEnumerable<FirstFood> Food => food;

        public void AddFood(int calories)
        {
            food.Add(new FirstFood(calories));
        }
    }
}