using System;

namespace SingleNumber
{
    class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int result = 0;
            foreach (var num in nums)
            {
                result ^= num;  // XOR
            }
            return result;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            string input = Console.ReadLine();
            int[] nums = Array.ConvertAll(input.Split(' '), int.Parse);

            Console.WriteLine(solution.SingleNumber(nums));
        }
    }
}