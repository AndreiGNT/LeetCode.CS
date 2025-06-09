using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class MissingNumber
    {
        public int MissingNumberFunc(int[] nums)
        {
            int n = nums.Length;
            int missing = n * (n + 1) / 2;

            foreach (int num in nums)
                missing -= num;

            return missing;
        }

        public void MissingNumberTest()
        {
            int[] nums = [0, 1];
            int result = MissingNumberFunc(nums);
            Console.WriteLine("Output: " + result);
            Console.WriteLine("Expected: 2");
            Console.WriteLine();

            int[] nums1 = [9, 6, 4, 2, 3, 5, 7, 0, 1];
            int result1 = MissingNumberFunc(nums1);
            Console.WriteLine("Output: " + result1);
            Console.WriteLine("Expected: 8");
        }
    }
}
