using System.Linq;
namespace DynamicProgramming
{
    public class AllConstruct
    {
        public static List<List<string>> BruteForce(string target, List<string> wordBank)
        {
            if (string.IsNullOrEmpty(target))
            {
                //here we return [[]]
                return new List<List<string>>{new List<string>()};
            }

            //here we return []
            var result = new List<List<string>>();
            
            //so if theres no match, the result will be an [].
            foreach (var word in wordBank)
            {
                if (target.StartsWith(word))
                {
                    var remainder = target.Substring(word.Length);
                    var suffixWays = BruteForce(remainder, wordBank);
                    var targetWays = suffixWays.AsEnumerable();
                    foreach (var targetWay in targetWays)
                    {
                        targetWay.Add(word);
                    }
                    result.AddRange(targetWays);
                }
            }

            return result;
        }

        public static List<List<string>> Memo(string target, List<string> wordBank) => MemoConcrete(target, wordBank, new Dictionary<string, List<List<string>>>
        {
            {"", new List<List<string>>{new List<string>()}}
        });
        private static List<List<string>> MemoConcrete(string target, List<string> wordBank, Dictionary<string, List<List<string>>> memo)
        {
            if (memo.ContainsKey(target))
                return memo[target];

            //here we return []
            var result = new List<List<string>>();
            
            //so if theres no match, the result will be an [].
            foreach (var word in wordBank)
            {
                if (target.StartsWith(word))
                {
                    var remainder = target.Substring(word.Length);
                    var suffixWays = MemoConcrete(remainder, wordBank, memo);
                    var targetWays = suffixWays.AsEnumerable();
                    foreach (var targetWay in targetWays)
                    {
                        targetWay.Add(word);
                    }
                    result.AddRange(targetWays);
                }
            }

            memo[target] = result;
            return result;
        }
    }
}