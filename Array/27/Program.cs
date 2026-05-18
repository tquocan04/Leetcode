int[] nums = [3, 2, 2, 3];

Solution solution = new();

int k = solution.RemoveElement(nums, 3);
Console.WriteLine(k);

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int length = nums.Length;
        
        int k = 0;

        for (int i = 0; i < length; i++)
        {
            if (nums[i] != val)
            {
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }
}