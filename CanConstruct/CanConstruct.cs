namespace DynamicProgramming
{

    public class CanConstruct
    {
/*
 * in this case you can whether subtract the target string from the word in wordbank if it begins with the word or if it ends.
 * You should only take care to do the same (begins with or ends with).
 */
        public static bool BruteForce(string target, List<string> wordBank)
        {
            if (string.IsNullOrEmpty(target))
                return true;

            foreach (var word in wordBank)
            {
                if (target.StartsWith(word))
                {
                    var remainder = target.Substring(word.Length);
                    if (BruteForce(remainder, wordBank))
                        return true;
                }
            }

            return false;
        }

        public static bool Memo(string target, List<string> wordBank) =>
            Memoized(target, wordBank, new Dictionary<string, bool>());
        private static bool Memoized(string target, List<string> wordBank, Dictionary<string, bool> memo)
        {
            if (memo.ContainsKey(target))
                return memo[target];
            if (string.IsNullOrEmpty(target))
            {
                memo[target] = true;
                return true;
            }

            foreach (var word in wordBank)
            {
                if (target.StartsWith(word))
                {
                    var remainder = target.Substring(word.Length);
                    if (Memoized(remainder, wordBank, memo))
                    {
                        memo[target] = true;
                        return true;
                    }
                }
            }

            memo[target] = false;
            return false;
        }
    }
}