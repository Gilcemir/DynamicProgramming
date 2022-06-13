namespace DynamicProgramming
{
    public class CanSum
    {
        public static bool BruteForce(int target, int[] nums)
        {
            //base cases
            if(target == 0) return true;
            if(target < 0) return false;

            foreach(int candidate in nums)
            {
                int remainder = target - candidate;
                if(BruteForce(remainder, nums))
                    return true;
            }
            
            return false;
        }

        public static bool Memo(int target, int[]nums) => SolveMemo(target, nums, new Dictionary<int, bool>());

        private static bool SolveMemo(int target, int[]nums, Dictionary<int, bool> memo)
        {
            if(memo.ContainsKey(target)) return memo[target];
            if(target == 0) return true;
            if(target < 0) return false;

            foreach(int candidate in nums)
            {
                int remainder = target - candidate;
                if(SolveMemo(remainder, nums, memo))
                {
                    memo[target] = true;
                    return true;
                } 
                
            }
            memo[target] = false;
            return false;
        }
    }
}