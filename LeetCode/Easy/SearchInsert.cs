using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class SearchInsert
    {
        public int SearchInsertFunc(int[] nums, int target)
        {
            int lowIdx = 0;
            int highIdx = nums.Length - 1;

            while (lowIdx <= highIdx)
            {
                int midleIdx = (highIdx + lowIdx) / 2;

                if (nums[midleIdx] == target)
                    return midleIdx;

                if (nums[midleIdx] > target)
                    highIdx = midleIdx - 1;
                else
                    lowIdx = midleIdx + 1;
            } 
            return lowIdx;
        }

        public void SearchInsertTest()
        {
            int[] nums = [ 1, 2, 3, 5, 6 ];
            int target = 2;
            int result = SearchInsertFunc(nums, target);
            Console.WriteLine("The expected idx should be: 1");
            Console.WriteLine("Index of the target " + target + " is: " + result);
            Console.WriteLine();

            int[] nums1 = [1, 2, 3, 5, 6];
            int target1 = 7;
            int result1 = SearchInsertFunc(nums1, target1);
            Console.WriteLine("The expected idx should be: 5");
            Console.WriteLine("Index of the target " + target1 + " is: " + result1);

        }
    }
}
