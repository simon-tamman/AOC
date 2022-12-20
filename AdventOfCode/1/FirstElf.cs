using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public class FirstElf
    {
        public int Id { get; }
        private readonly List<FirstFood> food = new();
        public IEnumerable<FirstFood> Food => food;

        public int TotalCalories => food.Sum(x => x.Calories);

        public FirstElf(int id)
        {
            Id = id;
        }

        public void AddFood(int calories)
        {
            food.Add(new FirstFood(calories));
        }
    }
}