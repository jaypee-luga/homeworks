using System.Globalization;

namespace E_TwoNums;

class Program
{
    static void Main(string[] args)
    {
        var nums = new int[] { 2, 7, 11, 15 };
        var target = 9;
        var output = TwoSum(nums, target);
        foreach(var i in output)
            Console.WriteLine(i);
    }

    static int[] TwoSum(int[] nums, int target)
    {
        var indices = new List<int>();
        for (var i=0; i<nums.Length; i++)
        {
           var x = target - nums[i];
           var indexOfX = nums.ToList().IndexOf(x);

           if (indexOfX != -1 && indexOfX != i)
           {
               indices.AddRange(new int[]{i,indexOfX});
               break;
           }
        }

        return indices.ToArray();
    }
}