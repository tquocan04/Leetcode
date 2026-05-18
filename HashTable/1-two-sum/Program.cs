class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = []; // HashMap: key-value
        int index1 = 0;
        int index2 = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int x = target - nums[i];
            if (dict.TryGetValue(x, out int value))
            {
                index1 = value;
                index2 = i;
                break;
            }
            
            dict.TryAdd(nums[i], i);
        }

        return [index1, index2];
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int target = int.Parse(Console.ReadLine());
            
            int [] nums = input.Split(',', StringSplitOptions.RemoveEmptyEntries)
                                .Select(s => s.Trim())
                                .Select(s => int.Parse(s))
                                .ToArray();
            
            Solution sln = new();

            var result = sln.TwoSum(nums, target);

            Console.Write($"[{result[0]},{result[1]}]");
        }
    }
}
