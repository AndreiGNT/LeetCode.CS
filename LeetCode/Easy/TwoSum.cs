namespace LeetCode.Easy
{
    internal class TwoSum
    {
        public int[]? TwoSumFunc(int[] nums, int target)
        {
            Dictionary<int, int> potentialResults = [];

            for (int i = 0; i < nums.Length; i++)
            {
                int currentValue = nums[i];
                int potentialResult = target - currentValue;

                if (potentialResults.ContainsKey(potentialResult))
                {
                    return [i, potentialResults[potentialResult]];
                }

                if (!potentialResults.ContainsKey(currentValue))
                {
                    potentialResults.Add(currentValue, i);
                }
            }
            return null;
        }

        public void TwoSumTest()
        {
            int target1 = 7;
            int[] nums1 = [0, 1, 2, 3, 4, 5, 6, 7];
            //             0  1  2  3  4  5  6  7
            int[]? result1 = TwoSumFunc(nums1, target1);
            if (result1 != null)
            {
                Console.WriteLine("The indicies: " + result1[0]);
                Console.WriteLine(" " + result1[1]);
            }
            else
            {
                Console.WriteLine("There is no numbers that sum up to the target");
            }

            // test 2
            int target2 = 13;
            int[] nums2 = [9, 3, 7, 2, 1, 10, 5, 4];
            //            0  1  2  3  4   5  6  7
            int[]? result2 = TwoSumFunc(nums2, target2);
            if (result1 != null)
            {
                Console.WriteLine("The indicies: " + result2[0]);
                Console.WriteLine(" " + result2[1]);
            }
            else
            {
                Console.WriteLine("There is no numbers that sum up to the target");
            }


            // test 3
            int target3 = 11;
            int[] nums3 = [1, 1, 1, 1, 1, 9, 2, 1];
            //            0  1  2  3  4  5  6  7
            int[]? result3 = TwoSumFunc(nums3, target3);
            if (result1 != null)
            {
                Console.WriteLine("The indicies: " + result3[0]);
                Console.WriteLine(" " + result3[1]);
            }
            else
            {
                Console.WriteLine("There is no numbers that sum up to the target");
            }

            // test 4
            int target4 = 1;
            int[] nums4 = [0, 0, 1];
            //            0  1  2 
            int[]? result4 = TwoSumFunc(nums4, target4);
            if (result1 != null)
            {
                Console.WriteLine("The indicies: " + result4[0]);
                Console.WriteLine(" " + result4[1]);
            }
            else
            {
                Console.WriteLine("There is no numbers that sum up to the target");
            }
        }
    }
}
