using System.Numerics;
namespace DynamicProgramming
{
    public class GridTraveler
    {

        //brute force
        public static long BruteForce(int m, int n)
        {
            if (n == 1 && m == 1)
                return 1;
            if (n <= 0 || m <= 0)
                return 0;

            return BruteForce(m - 1, n) + BruteForce(m, n - 1);
        }

        //memoized solution
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

        public static long Combinatorial(int m, int n)
        {
            int r = m - 1;
            int d = n - 1;
            int length = r + d;

            return Binomial(length, d);
        }
        private static long Binomial(int n, int k){
            long ans = 1;

            for(int i = 1; i <= k; i++)
                ans = ans *(n - k + i)/i; 

            return ans;
        }
    }
}