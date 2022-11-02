namespace DynamicProgramming
{
    public class CountConstruct
    {
        public static int BruteForce(string target, List<string> wordBank)
        {
            if (string.IsNullOrEmpty(target))
                return 1;

            int sum = 0;

            foreach (var word in wordBank)
            {
                if (target.StartsWith(word))
                {
                    var remainder = target.Substring(word.Length);
                    sum += BruteForce(remainder, wordBank);
                }
            }

            return sum;
        }

        public static int Memo(string target, List<string> wordBank) => Memoize(target, wordBank,
            new Dictionary<string, int>
            {
                {"", 1}
            });
        private static int Memoize(string target, List<string> wordBank, Dictionary<string, int> memo)
        {
            if (memo.ContainsKey(target))
                return memo[target];
            
            int sum = 0;

            foreach (var word in wordBank)
            {
                if (target.StartsWith(word))
                {
                    var remainder = target.Substring(word.Length);
                    sum += Memoize(remainder, wordBank, memo);
                }
            }

            memo[target] = sum;
            return sum;
        }
    }
}