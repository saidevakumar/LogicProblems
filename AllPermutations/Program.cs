// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

Console.WriteLine("Hello, World!");
PrintResult(Permute(new int[] { 1,2,3,4 }));

static IList<IList<int>> Permute(int[] list)
{
    var lst = new List<IList<int>>();
    return DoPermute(list, 0, list.Length - 1, lst);
}

static IList<IList<int>> DoPermute(int[] nums, int start, int end, IList<IList<int>> lst)
{
    if (start == end)
    {
        lst.Add(new List<int>(nums));
    }
    else
    {
        for (int i = start; i <= end;i++)
        {
            Swap(ref nums[start], ref nums[i]);
            DoPermute(nums, start + 1, end, lst);
            Swap(ref nums[start], ref nums[i]);
        }
    }

    return lst;
}

static void Swap(ref int a, ref int b)
{
    var temp = a;
    a = b;
    b = temp;
}

static void PrintResult(IList<IList<int>> lists)
{
    Console.WriteLine("[");
    foreach (var list in lists)
    {
        Console.WriteLine($"    [{string.Join(',', list)}]");
    }
    Console.WriteLine("]");
}