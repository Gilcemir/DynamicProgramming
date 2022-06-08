using System.Diagnostics;
using System.Numerics;
using DynamicProgramming;


int[] testCases = new int[]{0,1,2,10, 40, 45, 100, 500, 1000, 2000};

Stopwatch stopwatch = new Stopwatch();

foreach(int item in testCases)
{
    stopwatch.Start();
    //long fib = Fibonacci.BruteForceFib(item);
    //long fib = Fibonacci.MemoFib(item);
    BigInteger fib = Fibonacci.Memo2(item);
    Console.WriteLine($"n = {item}, fib({item}) = {fib}");
    Console.WriteLine($"Elapsed time is {stopwatch.ElapsedMilliseconds} ms");
    stopwatch.Stop();
}

