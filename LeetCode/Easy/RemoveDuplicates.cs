using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class RemoveDuplicates
    {
        public int RemoveDuplicatesFunc(int[] nums)
        {
            if (nums.Length == 1) return 1;

            int firstPointer = 0;

            for (int secPointer = 1; secPointer < nums.Length; secPointer++)
            {
                if (nums[firstPointer] != nums[secPointer])
                {
                    firstPointer++;
                    nums[firstPointer] = nums[secPointer];
                }
            }

            return firstPointer + 1;
        }

        public int RemoveDuplicatesFirstIdeia(int[] nums)
        {
            int[] uniqueNums = new int[nums.Length];
            uniqueNums[0] = nums[0];

            int k = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    uniqueNums[k] = nums[i];
                    k++;
                }
            }

            for (int i = 1; i < k; i++)
                nums[i] = uniqueNums[i];

            return k;
        }

        public void RemoveDuplicatesTest()
        {
            int[] nums = [1, 1, 1, 2, 3, 3, 3, 4, 5, 5, 6, 6, 6, 6];
            int result = RemoveDuplicatesFunc(nums);
            Console.WriteLine("Expected k = 6");
            Console.WriteLine("Result k = " + result);
            Console.Write("Result nums = ");
            for (int i = 0; i < result; i++)
            {
                Console.Write(nums[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();

            int[] nums1 = [0];
            int result1 = RemoveDuplicatesFunc(nums1);
            Console.WriteLine("Expected k = 1");
            Console.WriteLine("Result k = " + result1);
            Console.Write("Result nums = ");
            for (int i = 0; i < result1; i++)
            {
                Console.Write(nums1[i] + ", ");
            }
        }
    }
}
