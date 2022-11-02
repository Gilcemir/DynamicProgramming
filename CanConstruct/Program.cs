using DynamicProgramming;

var testCases = new List<KeyValuePair<string,List<string>>>
{
    new ("abcdef", new List<string>{"ab", "abc", "cd", "def", "abcd"}),
    new ("skateboard", new List<string>{"bo", "rd", "ate", "t", "ska", "sk", "boar"}),
    new ("enterapotentpot", new List<string>{"a", "p", "ent", "enter", "o", "t"}),
    new ("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new List<string>{"e", "ee", "eee", "eeee", "eeeee", "eeeeee"})
};

//bruteforce

// foreach (var testCase in testCases)
// {
//     var isPossible = CanConstruct.BruteForce(testCase.Key, testCase.Value);
//
//     Console.WriteLine("Current test case: ");
//     Console.WriteLine($"Target: {testCase.Key}, wordBank = {String.Join(", ", testCase.Value)}");
//
//     var str = isPossible ? "" : "im";
//     Console.WriteLine($"It is {str}possible");
// }

foreach (var testCase in testCases)
{
    var isPossible = CanConstruct.Memo(testCase.Key, testCase.Value);

    Console.WriteLine("Current test case: ");
    Console.WriteLine($"Target: {testCase.Key}, wordBank = {String.Join(", ", testCase.Value)}");

    var str = isPossible ? "" : "im";
    Console.WriteLine($"It is {str}possible");
}
Console.ReadKey();
