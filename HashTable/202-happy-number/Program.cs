class HappyNumber
{
    public class Solution
    {
        private int getNumber(int n)
        {
            int num = 0;
            while (n > 0)
            {
                var temp = n % 10;
                num += temp * temp;
                n /= 10;
            }
            return num;
        }
        
        public bool IsHappy(int n)
        {
            if (n == 1) return true;
            
            HashSet<int> nums = [];
            
            var num = getNumber(n);
            
            while (!nums.Contains(num) && num != 1)
            {
                nums.Add(num);
                num = getNumber(num);
            }
            
            return num == 1;
        } 
    }
    
    internal class Program()
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sln = new Solution();
            Console.WriteLine($"{sln.IsHappy(n)}");
        }
    }
}