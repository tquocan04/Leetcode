class Solution
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        // Use stack to store Greater Element
        // Idea: Compare the top value in stack with current value
        // If top_value < current_value -> stack.Pop() && stack.Push(current.value); set dictionary<top_value, current_value>
        // else stack.Push(current_value)
        Dictionary<int, int> dict = [];
        int[] result = new int[nums1.Length];
        Stack<int> stack = [];

        for (int i = 0; i < nums2.Length; i++)
        {
            while (stack.Count > 0 && stack.Peek() < nums2[i])
            {
                dict[stack.Pop()] = nums2[i];
            }
            stack.Push(nums2[i]);
        }

        for (int i = 0; i < nums1.Length; i++)
        {
            result[i] = dict.ContainsKey(nums1[i]) ? dict[nums1[i]] : -1;
        }

        return result;
    }

    static void Main(string[] args)
    {
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();

        int[] nums1 = [.. input1.Split(',', StringSplitOptions.RemoveEmptyEntries)
                                .Select(s => s.Trim())
                                .Select(s => int.Parse(s))];

        int[] nums2 = [.. input2.Split(',', StringSplitOptions.RemoveEmptyEntries)
                                .Select(s => s.Trim())
                                .Select(s => int.Parse(s))];

        Solution sln = new Solution();

        foreach (int num in sln.NextGreaterElement(nums1, nums2))
            Console.Write(num + " ");
    }
}
