using System.Diagnostics;
using System.Numerics;
using DynamicProgramming;


int[] testCases = new int[]{0,1,2,10, 40, 45, 100, 500, 1000, 2000, 1000000};

Stopwatch stopwatch = new Stopwatch();

foreach(int item in testCases)
{
    stopwatch.Start();
    BigInteger fib = Fibonacci.Memo2(item);
    Console.WriteLine($"n = {item}, fib({item}) = {fib}");
    Console.WriteLine($"Elapsed time is {stopwatch.ElapsedMilliseconds} ms");
    stopwatch.Stop();
}

Console.WriteLine("Press any key to continue with Matrix solution:");
Console.ReadLine();
stopwatch.Reset();
foreach(int item in testCases)
{
    stopwatch.Start();
    BigInteger fib = Fibonacci.LogN(item);
    Console.WriteLine($"n = {item}, fib({item}) = {fib}");
    Console.WriteLine($"Elapsed time is {stopwatch.ElapsedMilliseconds} ms");
    stopwatch.Stop();
}
