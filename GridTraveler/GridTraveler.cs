namespace DynamicProgramming
{
    public class GridTraveler
    {
        public static long BruteForce(int m, int n)
        {
            if (n == 1 && m == 1)
                return 1;
            if (n <= 0 || m <= 0)
                return 0;

            return BruteForce(m - 1, n) + BruteForce(m, n - 1);
        }


        public static long Memo(int m, int n) => SolveMemo(m, n, new Dictionary<string, long>());
        
        
        private static long SolveMemo(int m, int n, Dictionary<string, long> memo)
        {
            string key = m+","+n;
            if(memo.ContainsKey(key))
                return memo[key];
            if (n == 1 && m == 1)
                return 1;
            if (n <= 0 || m <= 0)
                return 0;

            memo[key] = SolveMemo(m - 1, n, memo) + SolveMemo(m, n - 1, memo);
            return memo[key];
        }

    }
}