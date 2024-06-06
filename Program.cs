using System.Globalization;

namespace Week_5_Challenge_Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numDict = new Dictionary<int, int>();

            int[] nums = {4,1,2,1,2};

            foreach(int i in nums) 
            {
                if (nums.Length == 1) 
                {
                    Console.WriteLine(i);
                }
                else if (!numDict.ContainsKey(i))
                {
                    numDict[i] = 1;
                }
                else 
                {
                    numDict[i]++;
                }
            ;
            
            }
            foreach(int num in numDict.Keys) 
            {
                if (numDict[num] == 1) 
                {
                    Console.WriteLine(num);
                }
            }
        }   
    }
}
