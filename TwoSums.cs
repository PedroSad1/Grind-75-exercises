using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] nums = { 3, 2, 3 };
        int target = 6;
        var result = TwoSum(nums, target);

        foreach (var value in result)
        {
            Console.WriteLine(value);
        }
    }

    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int result = target - nums[i];

            if (map.ContainsKey(result))
                return new int[] { map[result], i };

            map.Add(nums[i], i);
        }

        return null;
    }

}
