int[] nums1 = [1, 2, 3, 0, 0, 0];
int[] nums2 = [2, 5, 6];

var solution = new Solution();

solution.Merge(nums1, 3, nums2, 3);


public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int length = m + n;

        for (int i = 0; i < n; i++) 
        {
            nums1[i + m] = nums2[i];

        }

        for (int i = 0; i < length - 1; i++)
        {
            for (int j = i + 1; j < length; j++)
            {
                if (nums1[i] > nums1[j])
                {
                    (nums1[j], nums1[i]) = (nums1[i], nums1[j]);
                }
            }
        }

        for (int i = 0; i < length; i++)
        {
            Console.Write(nums1[i]);
        }
    }
}