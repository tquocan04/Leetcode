class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        if (strs.Length == 0)
            return [];

        Dictionary<string, IList<string>> hashMap = [];

        for (int i = 0; i < strs.Length; i++)
        {
            string val = strs[i];
            char[] chars = strs[i].ToCharArray();
            Array.Sort(chars);
            var key = new string(chars);

            if (hashMap.TryGetValue(key, out var values))
            {
                values.Add(val);
            }
            else
            {
                hashMap[key] = new List<string> {val};
            }
        }

        var result = new List<IList<string>>(hashMap.Count);

        foreach(var value in hashMap.Values)
        {
            result.Add(value);
        }

        return result;
    }

    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] strs = [..input.Split(',', StringSplitOptions.None)
                                .Select(s => s.Trim())];

        Solution sln = new();

        var result = sln.GroupAnagrams(strs);

        for (int i = 0; i < result.Count; i++)
        {
            foreach (var res in result[i])
                Console.WriteLine(res);
        }
        Console.WriteLine("Hello");
    }
}
