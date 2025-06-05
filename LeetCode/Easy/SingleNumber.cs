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
            int[] nums = { 1, 4, 3, 4, 5, 1, 5 };
            int result = SingleNumberFunc(nums);
            Console.WriteLine("Expected number: 3");
            Console.WriteLine("Output: " + result);
        }
    }
}
