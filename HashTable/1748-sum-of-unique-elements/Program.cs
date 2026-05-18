class Solution
{
    // Time Complexity: O(n)
    // Space Complexity: O(1) - using Dictionary

    public int SumOfUnique(int[] nums)
    {
        int result = 0;
        Dictionary<int, int> dict = [];

        foreach(var x in nums)
        {
            dict[x] = dict.GetValueOrDefault(x) + 1;
            
            if (dict[x] == 1)
                result += x;
            else if (dict[x] == 2)
                result -= x;
        }
        
        return result;    
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int [] nums = [.. input.Split(',', StringSplitOptions.RemoveEmptyEntries)
                                    .Select(s => s.Trim())
                                    .Select(s => int.Parse(s))];
            
            Solution sln = new ();
            Console.WriteLine($"{sln.SumOfUnique(nums)}");
        }
    }
}