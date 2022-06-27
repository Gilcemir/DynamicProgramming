using DynamicProgramming;

var testCase1 = HowSum.BruteForce(7, new int[] { 2, 3 });
var testCase2 = HowSum.BruteForce(7, new int[] { 5, 3, 4, 7 });
var testCase3 = HowSum.BruteForce(7, new int[] { 2, 4 });
var testCase4 = HowSum.BruteForce(300, new int[]{7, 14});

List<List<int>> tests = new List<List<int>>();
tests.Add(testCase1);
tests.Add(testCase2);
tests.Add(testCase3);
tests.Add(testCase4);

foreach (var testCase in tests)
{
    Console.WriteLine("Initalizing: ");
    if (testCase == null)
    {
        Console.WriteLine("Not found sum");
        break;
    }
    foreach (int num in testCase)
        Console.Write(num + " ");
    Console.WriteLine();

}