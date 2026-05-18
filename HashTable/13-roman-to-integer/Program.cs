// Using HashMap and Loop
namespace _13RomanToInteger;

class Solution
{
    public int RomanToInteger(string s)
    {
        Dictionary<char, int> mapping = new()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int result = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (mapping[s[i]] < mapping[s[i + 1]])
                result -= mapping[s[i]];
            else
                result += mapping[s[i]];
        }

        result += mapping[s[s.Length - 1]];
        return result;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Solution sln = new();
            string input = Console.ReadLine();

            Console.WriteLine(sln.RomanToInteger(input));
        }
    }
}