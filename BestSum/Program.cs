using DynamicProgramming;


Console.WriteLine(BestSum.PrintList(BestSum.Memo(7, new int[]{5, 3, 4, 7})));
Console.WriteLine(BestSum.PrintList(BestSum.Memo(8, new int[]{2, 3, 5})));
Console.WriteLine(BestSum.PrintList(BestSum.Memo(8, new int[]{1, 4, 5})));
Console.WriteLine(BestSum.PrintList(BestSum.Memo(7, new int[]{2, 4})));
Console.WriteLine(BestSum.PrintList(BestSum.Memo(100, new int[]{1, 2, 5, 25})));