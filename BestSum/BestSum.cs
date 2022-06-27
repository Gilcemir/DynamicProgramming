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