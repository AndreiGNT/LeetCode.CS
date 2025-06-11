using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class FindDisappearedNumbers
    {

        public IList<int> FindDisappearedNumbersFunc(int[] nums)
        {
            foreach (int num in nums)
            {
                int i = Math.Abs(num) - 1;
                nums[i] = -1 * Math.Abs(nums[i]);
            }

            var missing = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                if (num > 0 )
                    missing.Add(i + 1);
            }

            return missing;
        }

        public IList<int> FindDisappearedNumbersFunc0(int[] nums)
        {
            var oneToN = new HashSet<int>();   
            var n = nums.Length;
            for (int i = 1; i <= n; i++)
                oneToN.Add(i);

            foreach (int num in nums)
                if (oneToN.Contains(num))
                    oneToN.Remove(num);
            
            return oneToN.ToArray();
        }

        public void FindDisappearedNumbersTest()
        {
            int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missing  = FindDisappearedNumbersFunc(nums);
            Console.WriteLine("Expected: 5, 6");
            Console.Write("Output: ");
            foreach (int num in missing) 
                Console.Write(num + " ");
            Console.WriteLine();

        }
    }
}
