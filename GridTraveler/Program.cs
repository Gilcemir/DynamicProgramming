using DynamicProgramming;
using System.Numerics;
using System.Diagnostics;
/*
Description:
Say that you are a traveler on a 2d grid. You begin in the top-left corner and your gol is to travel to the bottom-right corner. You may only move down or right.

In how many ways can you travel to the goal on a grid with dimensions m * n?

Write a function GridTraveler(m, n) that calculates this.

*/
Stopwatch stopwatch = new Stopwatch();
int[][] testCases = new int[5][]
{
    new int[]{1,1},
    new int[]{2,3},
    new int[]{3,2},
    new int[]{3,3},
    new int[]{21,21}
};

foreach(var testCase in testCases)
{
    stopwatch.Start();
    long ans = GridTraveler.Combinatorial(testCase[0], testCase[1]);
    stopwatch.Stop();
    Console.WriteLine($"m = {testCase[0]}, n = {testCase[1]} = {ans}");
    Console.WriteLine($"Elapsed time is  {stopwatch.ElapsedMilliseconds} ms");
}