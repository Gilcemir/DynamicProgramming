namespace DynamicProgramming
{
    public class BestSum
    {
        public static List<int> BruteForce(int target, int[] nums)
        {
            if (target == 0)
                return new List<int>();
            if (target < 0)
                return null;

            List<int> shortestCombination = null;

            foreach (int num in nums)
            {
                int remainder = target - num;
                var remainderCombination = BruteForce(remainder, nums);
                if (remainderCombination != null)
                {
                    remainderCombination.Add(num);
                    //if the combination is shorter than the current "shortest", update it. Also avoid null value
                    if (shortestCombination == null || remainderCombination.Count < shortestCombination.Count)
                    {
                        shortestCombination = remainderCombination;
                    }
                }
            }

            return shortestCombination;
        }

        public static List<int> Memo(int target, int[] nums) => SolveMemo(target, nums, new Dictionary<int, List<int>>());

        private static List<int> SolveMemo(int target, int[] nums, Dictionary<int, List<int>> memo)
        {
            if (memo.ContainsKey(target)) return memo[target];
            
            if (target == 0) return new List<int>();
            
            if (target < 0) return null;
            
            List<int> shortestCombination = null;

            foreach (int num in nums)
            {
                int remainder = target - num;
                var remainderCombination = SolveMemo(remainder, nums, memo);
                if (remainderCombination != null)
                {
                    //copy remainderCombination. This is very important to not duplicate values in the list.
                    var combination = new List<int>(remainderCombination);
                    combination.Add(num);
                    //if the combination is shorter than the current "shortest", update it. Also avoid null value
                    if (shortestCombination == null || combination.Count < shortestCombination.Count)
                    {
                        shortestCombination = new List<int>(combination);
                    }
                }
            }
            memo[target] = shortestCombination;
            return memo[target];

        }

        public static string PrintList(List<int> list)
        {
            try
            {
                return list.Aggregate("", (str, next) => str + " " + next);
            }
            catch
            {
                return "Not possible";
            }
        }
    }

}