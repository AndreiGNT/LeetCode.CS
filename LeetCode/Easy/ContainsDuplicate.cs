using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class ContainsDuplicate
    {
        public bool ContainsDuplicateFunc(int[] nums)
        {
            HashSet<int> seen = new HashSet<int>();

            foreach (int num in nums)
            {
                if (seen.Contains(num))
                    return true;
                seen.Add(num);
            }

            return false;
        }

        public void ContainsDuplicateTest()
        {
            int[] nums = { 1, 2, 3, 1};
            bool result = ContainsDuplicateFunc(nums);
            Console.WriteLine("Output: " + result);
            Console.WriteLine("Expected: true");
            Console.WriteLine();

            int[] nums1 = { 1, 2, 3, 4 };
            bool result1 = ContainsDuplicateFunc(nums1);
            Console.WriteLine("Output: " + result1);
            Console.WriteLine("Expected: false");
            Console.WriteLine();

            int[] nums2 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            bool result2 = ContainsDuplicateFunc(nums2);
            Console.WriteLine("Output: " + result2);
            Console.WriteLine("Expected: true");
            Console.WriteLine();


        }
    }
}
