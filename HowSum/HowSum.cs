namespace DynamicProgramming
{
    public class HowSum
    {
        public static List<int> BruteForce(int target, int[] nums)
        {
            if(target == 0)
                return new List<int>();
            if(target < 0)
                return null;
            
            foreach(var num in nums)
            {
                int remainder = target - num;
                List<int> result = BruteForce(remainder, nums);
                if(result != null)
                {
                    result.Add(num);
                    return result;
                }
            }
            return null;
        }
        public static List<int> Memo(int target, int[]nums) => SolveMemo(target, nums, new Dictionary<int, List<int>>());
        public static List<int> SolveMemo(int target, int[] nums, Dictionary<int, List<int>> memo)
        {
            if(memo.ContainsKey(target)) return memo[target];
            if(target == 0)
                return new List<int>();
            if(target < 0)
                return null;
            
            foreach(var num in nums)
            {
                int remainder = target - num;
                List<int> result = SolveMemo(remainder, nums, memo);
                if(result != null)
                {
                    result.Add(num);
                    memo[target] = result;
                    return memo[target];
                }
            }
            memo[target] = null;
            return null;
        }
    }
}