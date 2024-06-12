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
        var hash = new Dictionary<int, int>();
        for(int index = 0; index <= nums.Length - 1; index++)
        {
            if(hash.ContainsKey(target - nums[index]))   
                return new int[] {index, hash[target - nums[index]]};
            else
                hash.TryAdd(nums[index], index);
        }
        
        return default;
    }
}