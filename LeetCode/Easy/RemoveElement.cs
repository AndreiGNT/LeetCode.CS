using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class RemoveElement
    {
        public int RemoveElementFunc(int[] nums, int val)
        {
            int pointerFirst = 0;

            for (int pointerSec = 0;  pointerSec < nums.Length; pointerSec++)
            {
                if (nums[pointerSec] != val)
                {
                    nums[pointerFirst] = nums[pointerSec];
                    pointerFirst++;
                }
            }
            return pointerFirst;
        }

        public void RemoveElementsTest()
        {
            int[] nums = [3, 2, 2, 3];
            int val = 3;
            int result = RemoveElementFunc(nums, val);
            Console.WriteLine("Value to be removed: " + val);
            Console.WriteLine("Expected k = 2");
            Console.WriteLine("Result k = " + result);
            Console.Write("Result nums = ");
            for (int i = 0; i < result; i++)
            {
                Console.Write(nums[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();

            int[] nums1 = [0, 1, 2, 2, 3, 0, 4, 2];
            int val1 = 2;
            int result1 = RemoveElementFunc(nums1, val1);
            Console.WriteLine("Value to be removed: " + val1);
            Console.WriteLine("Expected k = 5");
            Console.WriteLine("Result k = " + result1);
            Console.Write("Result nums = ");
            for (int i = 0; i < result1; i++)
            {
                Console.Write(nums1[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();

            int[] nums2 = [3, 3, 3, 3, 3, 3, 3, 3, 3, 3];
            int val2 = 2;
            int result2 = RemoveElementFunc(nums2, val2);
            Console.WriteLine("Value to be removed: " + val2);
            Console.WriteLine("Expected k = 10");
            Console.WriteLine("Result k = " + result2);
            Console.Write("Result nums = ");
            for (int i = 0; i < result2; i++)
            {
                Console.Write(nums2[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();


        }
    }
}
