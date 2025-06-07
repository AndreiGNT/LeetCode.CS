using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class MajorityElement
    {
        public int MajorityElementFunc(int[] nums)
        {
            int numResult = nums[0];
            int totalNumResult = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (totalNumResult == 0)
                {
                    numResult = nums[i];
                    totalNumResult++;
                }
                else if (nums[i] == numResult)
                    totalNumResult++;
                else if (nums[i] != numResult)
                    totalNumResult--;
            }

            return numResult;
        }

        public void MajorityElementTest()
        {
            int[] nums = {2, 2, 1, 1, 1, 2, 2};
            int majority = MajorityElementFunc(nums);
            Console.WriteLine("Majority element is: " + majority);
        }
    }
}
