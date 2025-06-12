using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class RangeSumQuery
    {
        private List<int> _prefixSums = [];
        public RangeSumQuery(int[] nums)
        {
            int sum = 0;
            for (int i =  0; i < nums.Length; i++)
            {
                sum += nums[i];
                _prefixSums.Add(sum);
            }
        }

        public int SumRange(int left, int right)
        {
            int sum = _prefixSums[right];
            if (left > 0)
                sum -= _prefixSums[left - 1];

            return sum;
        }

        // Testing cases
        //
        //int[] nums = { -2, 0, 3, -5, 2, -1 };
        //RangeSumQuery rangeSumQuery = new RangeSumQuery(nums);
        //int result = rangeSumQuery.SumRange(0, 3);
        //Console.WriteLine(result);

        //int result1 = rangeSumQuery.SumRange(3, 5);
        //Console.WriteLine(result1);
    }
}
