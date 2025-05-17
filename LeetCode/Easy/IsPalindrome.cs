namespace LeetCode.Easy
{
    internal class IsPalindrome
    {
        public bool IsPalindromeFunc(int num)
        {
            if (num != 0 && (num < 0 || num % 10 == 0))
            {
                return false;
            }

            int secHalfNum = 0;
            while (num > secHalfNum)
            {
                secHalfNum = (secHalfNum * 10) + (num % 10);
                num = num / 10;
            }

            return num == secHalfNum || secHalfNum / 10 == num;
        }

        public void IsPalindromeTest()
        {
            int testNum = -121;
            bool result = IsPalindromeFunc(testNum);
            Console.WriteLine("Tested number: " + testNum);
            Console.WriteLine("Is palindrome: " + result);
            Console.WriteLine(" ");

            int testNum1 = 121;
            bool result1 = IsPalindromeFunc(testNum1);
            Console.WriteLine("Tested number: " + testNum1);
            Console.WriteLine("Is palindrome: " + result1);
            Console.WriteLine(" ");

            int testNum2 = 1221;
            bool result2 = IsPalindromeFunc(testNum2);
            Console.WriteLine("Tested number: " + testNum2);
            Console.WriteLine("Is palindrome: " + result2);
            Console.WriteLine(" ");

            int testNum3 = 0;
            bool result3 = IsPalindromeFunc(testNum3);
            Console.WriteLine("Tested number: " + testNum3);
            Console.WriteLine("Is palindrome: " + result3);
            Console.WriteLine(" ");

            int testNum4 = 123454321;
            bool result4 = IsPalindromeFunc(testNum4);
            Console.WriteLine("Tested number: " + testNum4);
            Console.WriteLine("Is palindrome: " + result4);
            Console.WriteLine(" ");

            int testNum5 = 10;
            bool result5 = IsPalindromeFunc(testNum5);
            Console.WriteLine("Tested number: " + testNum5);
            Console.WriteLine("Is palindrome: " + result5);
            Console.WriteLine(" ");

        }
    }
}
