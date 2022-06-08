using System.Numerics;


/*
Classical fibonacci problem;

*/

namespace DynamicProgramming
{
    public class Fibonacci
    {
        /* Time O(n^2), Space O(n) 

            Time: Binary tree of height of n. 
            
            Space is the maximum height of the tree, because its the length of the recursive stack in the memory.

        */
        public static BigInteger BruteForce(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return BruteForce(n - 1) + BruteForce(n - 2);
        }

        /*
            Time: O(n)
            Space: O(n)

            Time: Memoization prevent from recalculating f(x), where 0 <= x < n
            Space: for each x, where 0 <= x <= n fib(x) is stored in the memory, which leads to n length

        */
        public static BigInteger Memo(int n)
        {

            BigInteger[] memo = new BigInteger[n + 1];
            memo[0] = 0;
            if (n > 0)
                memo[1] = 1;

            for (int i = 2; i <= n; i++)
                memo[i] = memo[i - 1] + memo[i - 2];

            return memo[n];
        }

        /*
            Time: O(n)
            Space: O(1)

            Time: Using previous value which was calculated, from 0 to n
            Space: Does not store unused values, which leads to static time complexity

        */        
        public static BigInteger Memo2(int n)
        {
            if (n == 0)
                return 0;
            BigInteger a = 0;
            BigInteger b = 1;

            for(int i = 2; i <= n; i++)
            {
                BigInteger c = a + b;
                a = b;
                b = c;
            }
            return b;
        }
    }
}