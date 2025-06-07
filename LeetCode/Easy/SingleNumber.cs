using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class SingleNumber
    {
        public int SingleNumberFunc(int[] nums)
        {
            int result = 0;

            foreach (int num in nums) 
            { 
                result = result ^ num;
            }

            return result;
        }

        public void SingleNumberTest()
        {
            int[] nums = { 1, 4, 7, 4, 5, 1, 5 };
            int result = SingleNumberFunc(nums);
            Console.WriteLine("Expected number: 3");
            Console.WriteLine("Output: " + result);
        }
    }

    /* 256 128 64 32 16 8 4 2 1 
     *   0   0  0  0  0 0 0 0 0 
     *   8   7  6  5  4 3 2 1 0  -  (1 * n**2)
     */
}
