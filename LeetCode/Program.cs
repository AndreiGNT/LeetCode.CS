using LeetCode.Easy;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { -2, 0, 3, -5, 2, -1 };
        RangeSumQuery rangeSumQuery = new RangeSumQuery(nums);
        int result = rangeSumQuery.SumRange(0, 3);
        Console.WriteLine(result);

        int result1 = rangeSumQuery.SumRange(3, 5);
        Console.WriteLine(result1);


    }
}