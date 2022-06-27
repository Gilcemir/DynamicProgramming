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
    }
}