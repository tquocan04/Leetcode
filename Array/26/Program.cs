int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];

//HashSet<int> hashSet = [.. nums];

////Console.WriteLine(hashSet);

Solution solution = new();

int k = solution.RemoveDuplicates(nums);
Console.WriteLine(k);

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        HashSet<int> hashSet = [.. nums];

        int i = 0;

        foreach (int index in hashSet)
        {
            nums[i] = index;
            i++;
        }

        return hashSet.Count;
    }
}