using System.ComponentModel;
using System.Reflection;

public class Program
{
    static void Main(string[] args)
    {

        var nums1 = new int[] { 3, 2, 1 };
        var nums = new int[] { 1, 2 };
        var nums2 = new int[] { 2, 2, 3, 1 };
        var allnums = new List<int[]>() { nums1, nums, nums2 };

        foreach (var i in allnums)
        {
            Console.WriteLine(ThirdMaximumNumber.ThirdMax(i));
        }
    }
}

public static class ThirdMaximumNumber {
    public static int ThirdMax(int[] nums)
    {
        var distinctNums = nums.Distinct().OrderByDescending(x => x).ToList();

        if (distinctNums.Count >= 3)
        {
            return distinctNums[2];
        }
        else
        {
            return distinctNums[0];
        }
    }
}
