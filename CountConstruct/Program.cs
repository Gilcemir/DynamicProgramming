using DynamicProgramming;

var testCases = new List<KeyValuePair<string,List<string>>>
{
    new ("purple", new List<string>{"purp", "p", "ur", "le", "purpl"}),//2
    new ("abcdef", new List<string>{"ab", "abc", "cd", "def", "abcd"}),//1
    new ("skateboard", new List<string>{"bo", "rd", "ate", "t", "ska", "sk", "boar"}),//0
    new ("enterapotentpot", new List<string>{"a", "p", "ent", "enter","ot", "o", "t"}),//4
    new ("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new List<string>{"e", "ee", "eee", "eeee", "eeeee", "eeeeee"})//0
};

//bruteforce

 // foreach (var testCase in testCases)
 // {
 //     var numWays = CountConstruct.BruteForce(testCase.Key, testCase.Value);
 //
 //     Console.WriteLine("Current test case: ");
 //     Console.WriteLine($"Target: {testCase.Key}, wordBank = {String.Join(", ", testCase.Value)}");
 //
 //     Console.WriteLine($"Number of ways: {numWays}");
 // }
 
foreach (var testCase in testCases)
{
    var numWays = CountConstruct.Memo(testCase.Key, testCase.Value);

    Console.WriteLine("Current test case: ");
    Console.WriteLine($"Target: {testCase.Key}, wordBank = {String.Join(", ", testCase.Value)}");

    Console.WriteLine($"Number of ways: {numWays}");
}