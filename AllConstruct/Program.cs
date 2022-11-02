using DynamicProgramming;

var testCases = new List<KeyValuePair<string,List<string>>>
{
    new ("purple", new List<string>{"purp", "p", "ur", "le", "purpl"}),//2
    /*
     * [
     *  [ purp, le],
     *  [p, ur, p, le]
     * ]
     */
    new ("abcdef", new List<string>{"ab", "abc", "cd", "def", "abcd", "ef", "c"}),//4
    /*
     * [
     *  [ab, cd, ef],
     *  [ab, c, def],
     *  [abc, def],
     *  [abcd, ef]
     * ]
     */
    new ("skateboard", new List<string>{"bo", "rd", "ate", "t", "ska", "sk", "boar"}),//0
    new ("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new List<string>{"e", "ee", "eee", "eeee", "eeeee", "eeeeee"})//0
};

// foreach (var testCase in testCases)
// {
//     var numWays = AllConstruct.BruteForce(testCase.Key, testCase.Value);
//
//     Console.WriteLine("Current test case: ");
//     Console.WriteLine($"Target: {testCase.Key}, wordBank = {String.Join(", ", testCase.Value)}");
//
//     foreach (var numWay in numWays)
//     {
//         Console.WriteLine(String.Join(", ", numWay));
//     }
// }

foreach (var testCase in testCases)
{
    var numWays = AllConstruct.Memo(testCase.Key, testCase.Value);

    Console.WriteLine("Current test case: ");
    Console.WriteLine($"Target: {testCase.Key}, wordBank = {String.Join(", ", testCase.Value)}");

    foreach (var numWay in numWays)
    {
        Console.WriteLine(String.Join(", ", numWay));
    }
}