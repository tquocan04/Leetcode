string[] strs = { "dog", "racecar", "car" };

var solution = new Solution();

Console.WriteLine(solution.LongestCommonPrefix(strs));

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length < 1 || strs.Length > 200) return "";

        string prefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            while (!strs[i].StartsWith(prefix))
            {
                prefix = prefix.Substring(0, prefix.Length - 1);

                if (prefix == "")
                    return "";
            }
        }

        return prefix;
    }
}