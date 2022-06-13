using DynamicProgramming;

Console.WriteLine(CanSum.Memo(7, new int[]{2, 3}));
Console.WriteLine(CanSum.Memo(7, new int[]{2, 4}));
Console.WriteLine(CanSum.Memo(7, new int[]{2, 3, 4, 7}));
Console.WriteLine(CanSum.Memo(300, new int[]{7, 14}));