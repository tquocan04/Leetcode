public class Solution
{
    public int SingleNumber(int[] nums)
    {

        //Array.Sort(nums);

        //if (nums[0] != nums[1])
        //    return nums[0];
        //int length = nums.Length;
        //for (int i = 1; i < length - 1; i++)
        //{
        //    if (nums[i] != nums[i - 1] && nums[i] != nums[i + 1])
        //        return nums[i];
        //}
        //return nums[length - 1];
        int ones = 0, twos = 0;

        foreach (int num in nums)
        {
            ones = (ones ^ num) & ~twos;
            twos = (twos ^ num) & ~ones;
        }

        return ones;
    }
}