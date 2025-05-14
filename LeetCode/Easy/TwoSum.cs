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
            // test 1
            //int target = 7;
            //int[] nums = [0, 1, 2, 3, 4, 5, 6, 7];
            ////            0  1  2  3  4  5  6  7

            //// test 2
            //int target = 13;
            //int[] nums = [9, 3, 7, 2, 1, 10, 5, 4];
            ////            0  1  2  3  4   5  6  7

            //// test 3
            //int target = 11;
            //int[] nums = [1, 1, 1, 1, 1, 9, 2, 1];
            ////            0  1  2  3  4  5  6  7

            // test 4
            int target = 1;
            int[] nums = [0, 0, 1];
            //            0  1  2 

            int[]? display = TwoSumFunc(nums, target);

            if (display != null)
            {
                Console.WriteLine(display[0]);
                Console.WriteLine(display[1]);
            }
            else
            {
                Console.WriteLine("Null");
            }
        }
    }
}
